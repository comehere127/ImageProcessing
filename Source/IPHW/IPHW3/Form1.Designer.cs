namespace IPHW3
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
			this.Control = new System.Windows.Forms.GroupBox();
			this.txtFile = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnExecute = new System.Windows.Forms.Button();
			this.cbType = new System.Windows.Forms.ComboBox();
			this.cbMatrix = new System.Windows.Forms.ComboBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnChoose = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pbInput = new System.Windows.Forms.PictureBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.pbOutput = new System.Windows.Forms.PictureBox();
			this.Control.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
			this.SuspendLayout();
			// 
			// Control
			// 
			this.Control.Controls.Add(this.txtFile);
			this.Control.Controls.Add(this.label2);
			this.Control.Controls.Add(this.label1);
			this.Control.Controls.Add(this.btnExecute);
			this.Control.Controls.Add(this.cbType);
			this.Control.Controls.Add(this.cbMatrix);
			this.Control.Controls.Add(this.btnReset);
			this.Control.Controls.Add(this.btnChoose);
			this.Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.Control.Location = new System.Drawing.Point(0, 0);
			this.Control.Name = "Control";
			this.Control.Size = new System.Drawing.Size(867, 100);
			this.Control.TabIndex = 0;
			this.Control.TabStop = false;
			this.Control.Text = "Control";
			// 
			// txtFile
			// 
			this.txtFile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.txtFile.Location = new System.Drawing.Point(106, 33);
			this.txtFile.Name = "txtFile";
			this.txtFile.ReadOnly = true;
			this.txtFile.Size = new System.Drawing.Size(252, 29);
			this.txtFile.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(566, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 21);
			this.label2.TabIndex = 7;
			this.label2.Text = "Type";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(522, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 21);
			this.label1.TabIndex = 6;
			this.label1.Text = "Matrix";
			this.label1.Visible = false;
			// 
			// btnExecute
			// 
			this.btnExecute.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.btnExecute.Location = new System.Drawing.Point(684, 30);
			this.btnExecute.Name = "btnExecute";
			this.btnExecute.Size = new System.Drawing.Size(88, 34);
			this.btnExecute.TabIndex = 5;
			this.btnExecute.Text = "Excecute";
			this.btnExecute.UseVisualStyleBackColor = true;
			this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
			// 
			// cbType
			// 
			this.cbType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.cbType.FormattingEnabled = true;
			this.cbType.Items.AddRange(new object[] {
            "Median",
            "Maximum",
            "Minimum"});
			this.cbType.Location = new System.Drawing.Point(532, 33);
			this.cbType.Name = "cbType";
			this.cbType.Size = new System.Drawing.Size(121, 29);
			this.cbType.TabIndex = 4;
			// 
			// cbMatrix
			// 
			this.cbMatrix.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.cbMatrix.FormattingEnabled = true;
			this.cbMatrix.Items.AddRange(new object[] {
            "None",
            "3x3",
            "5x5",
            "7x7",
            "9x9",
            "11x11",
            "13x13"});
			this.cbMatrix.Location = new System.Drawing.Point(488, 33);
			this.cbMatrix.Name = "cbMatrix";
			this.cbMatrix.Size = new System.Drawing.Size(121, 29);
			this.cbMatrix.TabIndex = 3;
			this.cbMatrix.Visible = false;
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.btnReset.Location = new System.Drawing.Point(380, 30);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(88, 34);
			this.btnReset.TabIndex = 2;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnChoose
			// 
			this.btnChoose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.btnChoose.Location = new System.Drawing.Point(12, 31);
			this.btnChoose.Name = "btnChoose";
			this.btnChoose.Size = new System.Drawing.Size(88, 34);
			this.btnChoose.TabIndex = 1;
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
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.pbInput);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox2.Location = new System.Drawing.Point(0, 100);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(431, 429);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Input";
			// 
			// pbInput
			// 
			this.pbInput.Dock = System.Windows.Forms.DockStyle.Left;
			this.pbInput.Location = new System.Drawing.Point(3, 16);
			this.pbInput.Name = "pbInput";
			this.pbInput.Size = new System.Drawing.Size(410, 410);
			this.pbInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbInput.TabIndex = 0;
			this.pbInput.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.pbOutput);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
			this.groupBox3.Location = new System.Drawing.Point(437, 100);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(430, 429);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Output";
			// 
			// pbOutput
			// 
			this.pbOutput.Location = new System.Drawing.Point(12, 19);
			this.pbOutput.Name = "pbOutput";
			this.pbOutput.Size = new System.Drawing.Size(410, 410);
			this.pbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbOutput.TabIndex = 1;
			this.pbOutput.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(867, 529);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.Control);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Control.ResumeLayout(false);
			this.Control.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbOutput)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox Control;
		private System.Windows.Forms.Button btnChoose;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnExecute;
		private System.Windows.Forms.ComboBox cbType;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.PictureBox pbInput;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.PictureBox pbOutput;
		private System.Windows.Forms.TextBox txtFile;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbMatrix;
	}
}

