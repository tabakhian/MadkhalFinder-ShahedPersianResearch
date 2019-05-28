namespace ShahedPersianResearchAlgorithmGUI
{
	partial class SelectPoetInitialData
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
			this.btnRecordData = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtNumber = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.lblNumber = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnRecordData
			// 
			this.btnRecordData.Location = new System.Drawing.Point(12, 101);
			this.btnRecordData.Name = "btnRecordData";
			this.btnRecordData.Size = new System.Drawing.Size(263, 41);
			this.btnRecordData.TabIndex = 0;
			this.btnRecordData.Text = "Record";
			this.btnRecordData.UseVisualStyleBackColor = true;
			this.btnRecordData.Click += new System.EventHandler(this.BtnRecordData_Click);
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.txtName.Location = new System.Drawing.Point(65, 12);
			this.txtName.Multiline = true;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(210, 31);
			this.txtName.TabIndex = 1;
			this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtNumber
			// 
			this.txtNumber.Location = new System.Drawing.Point(65, 49);
			this.txtNumber.Multiline = true;
			this.txtNumber.Name = "txtNumber";
			this.txtNumber.Size = new System.Drawing.Size(210, 31);
			this.txtNumber.TabIndex = 2;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(9, 12);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(41, 13);
			this.lblName.TabIndex = 3;
			this.lblName.Text = "Name :";
			// 
			// lblNumber
			// 
			this.lblNumber.AutoSize = true;
			this.lblNumber.Location = new System.Drawing.Point(9, 49);
			this.lblNumber.Name = "lblNumber";
			this.lblNumber.Size = new System.Drawing.Size(50, 13);
			this.lblNumber.TabIndex = 4;
			this.lblNumber.Text = "Number :";
			// 
			// SelectPoetInitialData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(287, 154);
			this.Controls.Add(this.lblNumber);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtNumber);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.btnRecordData);
			this.Name = "SelectPoetInitialData";
			this.Text = "Poet Data";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRecordData;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtNumber;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblNumber;
	}
}