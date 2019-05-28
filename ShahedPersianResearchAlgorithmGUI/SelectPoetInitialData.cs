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
	public partial class SelectPoetInitialData : Form
	{
		public SelectPoetInitialData(Models.Poet poet)
		{
			InitializeComponent();
			Poet = poet;
		}

		public Models.Poet Poet { get; set; }
		private void BtnRecordData_Click(object sender, EventArgs e)
		{
			try
			{
				Poet.Name = txtName.Text;
				Poet.Number = int.Parse(txtNumber.Text);

			}
			catch (Exception)
			{
				MessageBox.Show("Input Field In Right Format !");
			}
		
			this.Close();
		}
	}
}
