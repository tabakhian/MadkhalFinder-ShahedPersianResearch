using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShahedPersianResearchAlgorithmGUI
{
	public partial class MainForm : Form
	{

		public MainForm()
		{
			InitializeComponent();
			AnalyesdPoets = new List<Models.Poet>();

		}


		public System.Collections.Generic.List<Models.Poet> AnalyesdPoets { get; set; }
		public Models.Poet CurrentProcessingPoet { get; set; }
		public Models.Page currentProcessingPage { get; set; }

		private void BtnAnalyse_Click(object sender, EventArgs e)
		{

			if (string.IsNullOrEmpty(txtExportLocation.Text) || !txtExportLocation.Text.ToLower().Trim().EndsWith(".docx"))
			{
				MessageBox.Show("Please Enter A Valid File URL For Your Export File !");
			}

			try
			{
				Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();
				winword.ShowAnimation = true;
				winword.Visible = true;
				object missing = System.Reflection.Missing.Value;

				Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
				document.Paragraphs.Format.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
				document.Paragraphs.Format.ReadingOrder = WdReadingOrder.wdReadingOrderRtl;

				var AllMadkhals =
					AnalyesdPoets.SelectMany(current => current.Madkhals).GroupBy(currnet => currnet.Text.Trim().ToLower()).ToList().OrderBy(current=>current.Key).ToList();

				Microsoft.Office.Interop.Word.Paragraph paraMadkhalCount = document.Content.Paragraphs.Add(ref missing);
				object styleHeading1Out = "Heading 1";
				paraMadkhalCount.Range.set_Style(ref styleHeading1Out);
				paraMadkhalCount.Range.Font.Name = "B Nazanin";
				paraMadkhalCount.Range.Font.SizeBi = 20;
				paraMadkhalCount.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
				paraMadkhalCount.Range.ParagraphFormat.ReadingOrder = WdReadingOrder.wdReadingOrderRtl;
				paraMadkhalCount.Range.Text = "تعداد کل مدخل ها : " + AllMadkhals.Sum(current =>current.Count()).ToString();
				paraMadkhalCount.Range.InsertParagraphAfter();

				foreach (var madkhalType in AllMadkhals)
				{
					Microsoft.Office.Interop.Word.Paragraph paraMadkhalType = document.Content.Paragraphs.Add(ref missing);
					object styleHeading1 = "Heading 1";
					paraMadkhalType.Range.set_Style(ref styleHeading1);
					paraMadkhalType.Range.Font.Name = "B Nazanin";
					paraMadkhalType.Range.Font.SizeBi = 22;
					paraMadkhalType.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
					paraMadkhalType.Range.ParagraphFormat.ReadingOrder = WdReadingOrder.wdReadingOrderRtl;
					paraMadkhalType.Range.Text = string.Format("{0} : ({1})", madkhalType.Key , madkhalType.Count().ToString());
					paraMadkhalType.Range.InsertParagraphAfter();

					string strMadkhals = string.Empty;
					foreach (var madkhal in madkhalType)
					{
						strMadkhals += string.Format("{0} ({1}/{2}/{3}) ", madkhal.PoetPartContext , madkhal.PoetNumber, madkhal.BeatNumber, madkhal.PageNumber);
						strMadkhals += Environment.NewLine;
					}

					Microsoft.Office.Interop.Word.Paragraph paraMadkhal = document.Content.Paragraphs.Add(ref missing);
					object styleNormal = "Normal";
					paraMadkhal.Range.set_Style(ref styleNormal);
					paraMadkhal.Range.Font.SizeBi = 14;
					paraMadkhal.Range.Font.Name = "B Nazanin";
					paraMadkhal.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
					paraMadkhal.Range.ParagraphFormat.ReadingOrder = WdReadingOrder.wdReadingOrderRtl;
					paraMadkhal.Range.Text = strMadkhals;
					paraMadkhal.Range.InsertParagraphAfter();			
				}

				//Save the document  
				object filename = txtExportLocation.Text;
				document.SaveAs2(ref filename);
				document.Close(ref missing, ref missing, ref missing);
				document = null;
				winword.Quit(ref missing, ref missing, ref missing);
				winword = null;
				MessageBox.Show("Word Document created successfully !!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void BtnNewPoet_Click(object sender, EventArgs e)
		{
			CurrentProcessingPoet = new Models.Poet();
			SelectPoetInitialData formSelectPoetInitialData = new SelectPoetInitialData(CurrentProcessingPoet);
			formSelectPoetInitialData.Show();
			formSelectPoetInitialData.FormClosed += FormSelectPoetInitialData_FormClosed;
		}

		private void FormSelectPoetInitialData_FormClosed(object sender, FormClosedEventArgs e)
		{
			lblCurrentPoetName.Text = CurrentProcessingPoet.Number + " - " + CurrentProcessingPoet.Name + " - " + (CurrentProcessingPoet.IsAnalysed ? "Analysed" : "Not Analysed");
			lstAnalysedPages.Rows.Clear();
		}

		private void BtnNewPage_Click(object sender, EventArgs e)
		{
			currentProcessingPage = new Models.Page();
			txtPoetPageInput.Enabled = true;
			txtCurrentPageNumber.Enabled = true;
		}

		private void BtnRecordPoet_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtSearchLetter.Text))
			{
				MessageBox.Show("Please Select A Search Letter First !");
				return;
			}
			CurrentProcessingPoet.Analyse(txtSearchLetter.Text);
			AnalyesdPoets.Add(CurrentProcessingPoet);
			CurrentProcessingPoet = null;
			lblCurrentPoetName.Text = string.Empty;
			lstAnalysedPoets.Rows.Clear();
			lstAnalysedPages.Rows.Clear();
			AnalyesdPoets.ForEach(current => lstAnalysedPoets.Rows.Add(new string[] { current.Number.ToString(), current.Name, current.Pages.Count().ToString() }));
		}

		private void BtnRecordPage_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtCurrentPageNumber.Text) || string.IsNullOrEmpty(txtPoetPageInput.Text))
			{
				MessageBox.Show("Check The Page Inputs");
				return;
			}

			CurrentProcessingPoet.Pages.Add(currentProcessingPage);
			currentProcessingPage = null;
			txtPoetPageInput.Text = string.Empty;
			txtCurrentPageNumber.Text = string.Empty;
			txtPoetPageInput.Enabled = false;
			txtCurrentPageNumber.Enabled = false;
			lstAnalysedPages.Rows.Clear();
			CurrentProcessingPoet.Pages.ForEach(current => lstAnalysedPages.Rows.Add(new string[] { current.Number.ToString() }));
		}

		private void TxtCurrentPageNumber_TextChanged(object sender, EventArgs e)
		{
			if (currentProcessingPage != null)
			{
				try
				{
					currentProcessingPage.Number = Convert.ToInt32(txtCurrentPageNumber.Text);
				}
				catch (Exception)
				{
					MessageBox.Show("Input Just Numbers !");
				}
			}
		}

		private void TxtPoetPageInput_TextChanged(object sender, EventArgs e)
		{
			if (currentProcessingPage != null)
			{
				currentProcessingPage.Text = txtPoetPageInput.Text;
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			txtPoetPageInput.Enabled = false;
			txtCurrentPageNumber.Enabled = false;
			lstAnalysedPoets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}

		private void LstAnalysedPoets_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int strSelectedIndexNumber = Convert.ToInt32(lstAnalysedPoets.Rows[lstAnalysedPoets.CurrentCell.RowIndex].Cells[0].Value.ToString());
			CurrentProcessingPoet = AnalyesdPoets.Where(current => current.Number == strSelectedIndexNumber).FirstOrDefault();
			lblCurrentPoetName.Text = CurrentProcessingPoet.Number + " - " + CurrentProcessingPoet.Name + " - " + (CurrentProcessingPoet.IsAnalysed ? "Analysed" : "Not Analysed");
			lstAnalysedPages.Rows.Clear();
			CurrentProcessingPoet.Pages.ForEach(current => lstAnalysedPoets.Rows.Add(new string[] { current.Number.ToString() }));
		}

		private void LstAnalysedPages_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
