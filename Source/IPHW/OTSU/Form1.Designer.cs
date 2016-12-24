namespace OTSU
{
	partial class Form1
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnChoose = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.pbInput = new System.Windows.Forms.PictureBox();
			this.txtOtsuThreshold = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtOtsuThreshold);
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.btnChoose);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(348, 100);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Control";
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.btnReset.Location = new System.Drawing.Point(119, 38);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(88, 34);
			this.btnReset.TabIndex = 1;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			// 
			// btnChoose
			// 
			this.btnChoose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.btnChoose.Location = new System.Drawing.Point(10, 38);
			this.btnChoose.Name = "btnChoose";
			this.btnChoose.Size = new System.Drawing.Size(88, 34);
			this.btnChoose.TabIndex = 0;
			this.btnChoose.Text = "Choose";
			this.btnChoose.UseVisualStyleBackColor = true;
			this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|bmp files (*.bmp)|*.bmp|All files" +
    " (*.*)|*.*";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.pbInput);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox3.Location = new System.Drawing.Point(0, 102);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(348, 359);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Input";
			// 
			// pbInput
			// 
			this.pbInput.Dock = System.Windows.Forms.DockStyle.Left;
			this.pbInput.Location = new System.Drawing.Point(3, 16);
			this.pbInput.Name = "pbInput";
			this.pbInput.Size = new System.Drawing.Size(340, 340);
			this.pbInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbInput.TabIndex = 2;
			this.pbInput.TabStop = false;
			// 
			// txtOtsuThreshold
			// 
			this.txtOtsuThreshold.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.txtOtsuThreshold.Location = new System.Drawing.Point(278, 40);
			this.txtOtsuThreshold.Name = "txtOtsuThreshold";
			this.txtOtsuThreshold.ReadOnly = true;
			this.txtOtsuThreshold.Size = new System.Drawing.Size(64, 29);
			this.txtOtsuThreshold.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(228, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 21);
			this.label1.TabIndex = 3;
			this.label1.Text = "Otsu";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 461);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox3);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnChoose;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.PictureBox pbInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtOtsuThreshold;
	}
}

