namespace ShahedPersianResearchAlgorithmGUI
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtPoetPageInput = new System.Windows.Forms.RichTextBox();
			this.btnAnalyse = new System.Windows.Forms.Button();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.btnNewPoet = new System.Windows.Forms.Button();
			this.btnNewPage = new System.Windows.Forms.Button();
			this.btnRecordPoet = new System.Windows.Forms.Button();
			this.btnRecordPage = new System.Windows.Forms.Button();
			this.lstAnalysedPoets = new System.Windows.Forms.DataGridView();
			this.PoetNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PoetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PoetPages = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lstAnalysedPages = new System.Windows.Forms.DataGridView();
			this.PageNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtCurrentPageNumber = new System.Windows.Forms.TextBox();
			this.lblCurrentPoetName = new System.Windows.Forms.Label();
			this.txtSearchLetter = new System.Windows.Forms.TextBox();
			this.txtExportLocation = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.lstAnalysedPoets)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lstAnalysedPages)).BeginInit();
			this.SuspendLayout();
			// 
			// txtPoetPageInput
			// 
			this.txtPoetPageInput.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.txtPoetPageInput.Location = new System.Drawing.Point(472, 38);
			this.txtPoetPageInput.Name = "txtPoetPageInput";
			this.txtPoetPageInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtPoetPageInput.Size = new System.Drawing.Size(756, 566);
			this.txtPoetPageInput.TabIndex = 0;
			this.txtPoetPageInput.Text = "";
			this.txtPoetPageInput.TextChanged += new System.EventHandler(this.TxtPoetPageInput_TextChanged);
			// 
			// btnAnalyse
			// 
			this.btnAnalyse.Location = new System.Drawing.Point(472, 647);
			this.btnAnalyse.Name = "btnAnalyse";
			this.btnAnalyse.Size = new System.Drawing.Size(756, 67);
			this.btnAnalyse.TabIndex = 2;
			this.btnAnalyse.Text = "Export Analyse";
			this.btnAnalyse.UseVisualStyleBackColor = true;
			this.btnAnalyse.Click += new System.EventHandler(this.BtnAnalyse_Click);
			// 
			// btnNewPoet
			// 
			this.btnNewPoet.Location = new System.Drawing.Point(12, 12);
			this.btnNewPoet.Name = "btnNewPoet";
			this.btnNewPoet.Size = new System.Drawing.Size(327, 41);
			this.btnNewPoet.TabIndex = 4;
			this.btnNewPoet.Text = "New Poet";
			this.btnNewPoet.UseVisualStyleBackColor = true;
			this.btnNewPoet.Click += new System.EventHandler(this.BtnNewPoet_Click);
			// 
			// btnNewPage
			// 
			this.btnNewPage.Location = new System.Drawing.Point(345, 12);
			this.btnNewPage.Name = "btnNewPage";
			this.btnNewPage.Size = new System.Drawing.Size(121, 41);
			this.btnNewPage.TabIndex = 5;
			this.btnNewPage.Text = "New Page";
			this.btnNewPage.UseVisualStyleBackColor = true;
			this.btnNewPage.Click += new System.EventHandler(this.BtnNewPage_Click);
			// 
			// btnRecordPoet
			// 
			this.btnRecordPoet.Location = new System.Drawing.Point(12, 59);
			this.btnRecordPoet.Name = "btnRecordPoet";
			this.btnRecordPoet.Size = new System.Drawing.Size(327, 41);
			this.btnRecordPoet.TabIndex = 8;
			this.btnRecordPoet.Text = "Record Poet";
			this.btnRecordPoet.UseVisualStyleBackColor = true;
			this.btnRecordPoet.Click += new System.EventHandler(this.BtnRecordPoet_Click);
			// 
			// btnRecordPage
			// 
			this.btnRecordPage.Location = new System.Drawing.Point(345, 59);
			this.btnRecordPage.Name = "btnRecordPage";
			this.btnRecordPage.Size = new System.Drawing.Size(121, 41);
			this.btnRecordPage.TabIndex = 9;
			this.btnRecordPage.Text = "Record Page";
			this.btnRecordPage.UseVisualStyleBackColor = true;
			this.btnRecordPage.Click += new System.EventHandler(this.BtnRecordPage_Click);
			// 
			// lstAnalysedPoets
			// 
			this.lstAnalysedPoets.AllowUserToAddRows = false;
			this.lstAnalysedPoets.AllowUserToDeleteRows = false;
			this.lstAnalysedPoets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.lstAnalysedPoets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PoetNumber,
            this.PoetName,
            this.PoetPages});
			this.lstAnalysedPoets.Location = new System.Drawing.Point(12, 143);
			this.lstAnalysedPoets.Name = "lstAnalysedPoets";
			this.lstAnalysedPoets.ReadOnly = true;
			this.lstAnalysedPoets.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.lstAnalysedPoets.Size = new System.Drawing.Size(353, 545);
			this.lstAnalysedPoets.TabIndex = 10;
			this.lstAnalysedPoets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LstAnalysedPoets_CellContentClick);
			// 
			// PoetNumber
			// 
			this.PoetNumber.HeaderText = "N";
			this.PoetNumber.Name = "PoetNumber";
			this.PoetNumber.ReadOnly = true;
			this.PoetNumber.Width = 30;
			// 
			// PoetName
			// 
			this.PoetName.HeaderText = "Name";
			this.PoetName.Name = "PoetName";
			this.PoetName.ReadOnly = true;
			this.PoetName.Width = 250;
			// 
			// PoetPages
			// 
			this.PoetPages.HeaderText = "Pg";
			this.PoetPages.Name = "PoetPages";
			this.PoetPages.ReadOnly = true;
			this.PoetPages.Width = 30;
			// 
			// lstAnalysedPages
			// 
			this.lstAnalysedPages.AllowUserToAddRows = false;
			this.lstAnalysedPages.AllowUserToDeleteRows = false;
			this.lstAnalysedPages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.lstAnalysedPages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PageNumber});
			this.lstAnalysedPages.Location = new System.Drawing.Point(371, 143);
			this.lstAnalysedPages.Name = "lstAnalysedPages";
			this.lstAnalysedPages.ReadOnly = true;
			this.lstAnalysedPages.Size = new System.Drawing.Size(95, 545);
			this.lstAnalysedPages.TabIndex = 11;
			this.lstAnalysedPages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LstAnalysedPages_CellContentClick);
			// 
			// PageNumber
			// 
			this.PageNumber.HeaderText = "Number";
			this.PageNumber.Name = "PageNumber";
			this.PageNumber.ReadOnly = true;
			this.PageNumber.Width = 50;
			// 
			// txtCurrentPageNumber
			// 
			this.txtCurrentPageNumber.Location = new System.Drawing.Point(472, 12);
			this.txtCurrentPageNumber.Name = "txtCurrentPageNumber";
			this.txtCurrentPageNumber.Size = new System.Drawing.Size(756, 20);
			this.txtCurrentPageNumber.TabIndex = 12;
			this.txtCurrentPageNumber.TextChanged += new System.EventHandler(this.TxtCurrentPageNumber_TextChanged);
			// 
			// lblCurrentPoetName
			// 
			this.lblCurrentPoetName.AutoSize = true;
			this.lblCurrentPoetName.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.lblCurrentPoetName.Location = new System.Drawing.Point(12, 107);
			this.lblCurrentPoetName.Name = "lblCurrentPoetName";
			this.lblCurrentPoetName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCurrentPoetName.Size = new System.Drawing.Size(0, 20);
			this.lblCurrentPoetName.TabIndex = 13;
			this.lblCurrentPoetName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtSearchLetter
			// 
			this.txtSearchLetter.Location = new System.Drawing.Point(12, 694);
			this.txtSearchLetter.Name = "txtSearchLetter";
			this.txtSearchLetter.Size = new System.Drawing.Size(454, 20);
			this.txtSearchLetter.TabIndex = 14;
			// 
			// txtExportLocation
			// 
			this.txtExportLocation.Location = new System.Drawing.Point(472, 621);
			this.txtExportLocation.Name = "txtExportLocation";
			this.txtExportLocation.Size = new System.Drawing.Size(756, 20);
			this.txtExportLocation.TabIndex = 15;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1240, 726);
			this.Controls.Add(this.txtExportLocation);
			this.Controls.Add(this.txtSearchLetter);
			this.Controls.Add(this.lblCurrentPoetName);
			this.Controls.Add(this.txtCurrentPageNumber);
			this.Controls.Add(this.lstAnalysedPages);
			this.Controls.Add(this.lstAnalysedPoets);
			this.Controls.Add(this.btnRecordPage);
			this.Controls.Add(this.btnRecordPoet);
			this.Controls.Add(this.btnNewPage);
			this.Controls.Add(this.btnNewPoet);
			this.Controls.Add(this.btnAnalyse);
			this.Controls.Add(this.txtPoetPageInput);
			this.Name = "MainForm";
			this.Text = "Main";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.lstAnalysedPoets)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lstAnalysedPages)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox txtPoetPageInput;
		private System.Windows.Forms.Button btnAnalyse;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.Button btnNewPoet;
		private System.Windows.Forms.Button btnNewPage;
		private System.Windows.Forms.Button btnRecordPoet;
		private System.Windows.Forms.Button btnRecordPage;
		private System.Windows.Forms.DataGridView lstAnalysedPoets;
		private System.Windows.Forms.DataGridView lstAnalysedPages;
		private System.Windows.Forms.DataGridViewTextBoxColumn PageNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn PoetNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn PoetName;
		private System.Windows.Forms.DataGridViewTextBoxColumn PoetPages;
		private System.Windows.Forms.TextBox txtCurrentPageNumber;
		private System.Windows.Forms.Label lblCurrentPoetName;
		private System.Windows.Forms.TextBox txtSearchLetter;
		private System.Windows.Forms.TextBox txtExportLocation;
	}
}

