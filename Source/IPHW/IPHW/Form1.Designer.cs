namespace IPHW
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
			this.btnChoose = new System.Windows.Forms.Button();
			this.pbInput = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbEndInSearch = new System.Windows.Forms.RadioButton();
			this.rbHistoSpe = new System.Windows.Forms.RadioButton();
			this.rbHistoEqual = new System.Windows.Forms.RadioButton();
			this.btnReset = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pbHisInput = new System.Windows.Forms.PictureBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.pbHisOutput = new System.Windows.Forms.PictureBox();
			this.pbOutput = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbHisInput)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbHisOutput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
			this.SuspendLayout();
			// 
			// btnChoose
			// 
			this.btnChoose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.btnChoose.Location = new System.Drawing.Point(43, 38);
			this.btnChoose.Name = "btnChoose";
			this.btnChoose.Size = new System.Drawing.Size(88, 34);
			this.btnChoose.TabIndex = 0;
			this.btnChoose.Text = "Choose";
			this.btnChoose.UseVisualStyleBackColor = true;
			this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
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
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|bmp files (*.bmp)|*.bmp|All files" +
    " (*.*)|*.*";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbEndInSearch);
			this.groupBox1.Controls.Add(this.rbHistoSpe);
			this.groupBox1.Controls.Add(this.rbHistoEqual);
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.btnChoose);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(710, 100);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Control";
			// 
			// rbEndInSearch
			// 
			this.rbEndInSearch.AutoSize = true;
			this.rbEndInSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbEndInSearch.Location = new System.Drawing.Point(313, 69);
			this.rbEndInSearch.Name = "rbEndInSearch";
			this.rbEndInSearch.Size = new System.Drawing.Size(126, 25);
			this.rbEndInSearch.TabIndex = 4;
			this.rbEndInSearch.TabStop = true;
			this.rbEndInSearch.Text = "End In Search";
			this.rbEndInSearch.UseVisualStyleBackColor = true;
			this.rbEndInSearch.Click += new System.EventHandler(this.rbChecked);
			// 
			// rbHistoSpe
			// 
			this.rbHistoSpe.AutoSize = true;
			this.rbHistoSpe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbHistoSpe.Location = new System.Drawing.Point(313, 43);
			this.rbHistoSpe.Name = "rbHistoSpe";
			this.rbHistoSpe.Size = new System.Drawing.Size(204, 25);
			this.rbHistoSpe.TabIndex = 3;
			this.rbHistoSpe.TabStop = true;
			this.rbHistoSpe.Text = "Histogram Specification";
			this.rbHistoSpe.UseVisualStyleBackColor = true;
			this.rbHistoSpe.Click += new System.EventHandler(this.rbChecked);
			// 
			// rbHistoEqual
			// 
			this.rbHistoEqual.AutoSize = true;
			this.rbHistoEqual.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbHistoEqual.Location = new System.Drawing.Point(313, 12);
			this.rbHistoEqual.Name = "rbHistoEqual";
			this.rbHistoEqual.Size = new System.Drawing.Size(196, 25);
			this.rbHistoEqual.TabIndex = 2;
			this.rbHistoEqual.TabStop = true;
			this.rbHistoEqual.Text = "Histogram Equalization";
			this.rbHistoEqual.UseVisualStyleBackColor = true;
			this.rbHistoEqual.Click += new System.EventHandler(this.rbChecked);
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.btnReset.Location = new System.Drawing.Point(152, 38);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(88, 34);
			this.btnReset.TabIndex = 1;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.pbHisInput);
			this.groupBox2.Controls.Add(this.pbInput);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.Location = new System.Drawing.Point(0, 100);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(710, 359);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Input";
			// 
			// pbHisInput
			// 
			this.pbHisInput.Dock = System.Windows.Forms.DockStyle.Right;
			this.pbHisInput.Location = new System.Drawing.Point(367, 16);
			this.pbHisInput.Name = "pbHisInput";
			this.pbHisInput.Size = new System.Drawing.Size(340, 340);
			this.pbHisInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbHisInput.TabIndex = 3;
			this.pbHisInput.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.pbHisOutput);
			this.groupBox3.Controls.Add(this.pbOutput);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox3.Location = new System.Drawing.Point(0, 459);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(710, 359);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Output";
			// 
			// pbHisOutput
			// 
			this.pbHisOutput.Dock = System.Windows.Forms.DockStyle.Right;
			this.pbHisOutput.Location = new System.Drawing.Point(367, 16);
			this.pbHisOutput.Name = "pbHisOutput";
			this.pbHisOutput.Size = new System.Drawing.Size(340, 340);
			this.pbHisOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbHisOutput.TabIndex = 3;
			this.pbHisOutput.TabStop = false;
			// 
			// pbOutput
			// 
			this.pbOutput.Dock = System.Windows.Forms.DockStyle.Left;
			this.pbOutput.Location = new System.Drawing.Point(3, 16);
			this.pbOutput.Name = "pbOutput";
			this.pbOutput.Size = new System.Drawing.Size(340, 340);
			this.pbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbOutput.TabIndex = 2;
			this.pbOutput.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(710, 861);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbHisInput)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbHisOutput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbOutput)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnChoose;
		private System.Windows.Forms.PictureBox pbInput;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.PictureBox pbHisInput;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.PictureBox pbHisOutput;
		private System.Windows.Forms.PictureBox pbOutput;
		private System.Windows.Forms.RadioButton rbEndInSearch;
		private System.Windows.Forms.RadioButton rbHistoSpe;
		private System.Windows.Forms.RadioButton rbHistoEqual;
	}
}

