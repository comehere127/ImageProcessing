namespace IPHW2
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
			this.lbBlur = new System.Windows.Forms.Label();
			this.txtBlur = new System.Windows.Forms.TextBox();
			this.btnExecute = new System.Windows.Forms.Button();
			this.rbGauss = new System.Windows.Forms.RadioButton();
			this.rbEmboss = new System.Windows.Forms.RadioButton();
			this.rbBlur = new System.Windows.Forms.RadioButton();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnChoose = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pbInput = new System.Windows.Forms.PictureBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.pbOutput = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.Control.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
			this.SuspendLayout();
			// 
			// Control
			// 
			this.Control.Controls.Add(this.lbBlur);
			this.Control.Controls.Add(this.txtBlur);
			this.Control.Controls.Add(this.btnExecute);
			this.Control.Controls.Add(this.rbGauss);
			this.Control.Controls.Add(this.rbEmboss);
			this.Control.Controls.Add(this.rbBlur);
			this.Control.Controls.Add(this.btnReset);
			this.Control.Controls.Add(this.btnChoose);
			this.Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.Control.Location = new System.Drawing.Point(0, 0);
			this.Control.Name = "Control";
			this.Control.Size = new System.Drawing.Size(867, 100);
			this.Control.TabIndex = 1;
			this.Control.TabStop = false;
			this.Control.Text = "Control";
			// 
			// lbBlur
			// 
			this.lbBlur.AutoSize = true;
			this.lbBlur.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.lbBlur.Location = new System.Drawing.Point(311, 18);
			this.lbBlur.Name = "lbBlur";
			this.lbBlur.Size = new System.Drawing.Size(99, 21);
			this.lbBlur.TabIndex = 8;
			this.lbBlur.Text = "Blur amount";
			this.lbBlur.Visible = false;
			// 
			// txtBlur
			// 
			this.txtBlur.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.txtBlur.Location = new System.Drawing.Point(419, 13);
			this.txtBlur.Name = "txtBlur";
			this.txtBlur.Size = new System.Drawing.Size(83, 29);
			this.txtBlur.TabIndex = 7;
			this.txtBlur.Visible = false;
			this.txtBlur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBlur_KeyPress);
			// 
			// btnExecute
			// 
			this.btnExecute.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.btnExecute.Location = new System.Drawing.Point(681, 12);
			this.btnExecute.Name = "btnExecute";
			this.btnExecute.Size = new System.Drawing.Size(80, 80);
			this.btnExecute.TabIndex = 6;
			this.btnExecute.Text = "Execute";
			this.btnExecute.UseVisualStyleBackColor = true;
			this.btnExecute.Visible = false;
			this.btnExecute.Click += new System.EventHandler(this.buttonClick);
			// 
			// rbGauss
			// 
			this.rbGauss.AutoSize = true;
			this.rbGauss.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.rbGauss.Location = new System.Drawing.Point(524, 72);
			this.rbGauss.Name = "rbGauss";
			this.rbGauss.Size = new System.Drawing.Size(132, 25);
			this.rbGauss.TabIndex = 5;
			this.rbGauss.TabStop = true;
			this.rbGauss.Text = "Gaussian Filter";
			this.rbGauss.UseVisualStyleBackColor = true;
			this.rbGauss.Click += new System.EventHandler(this.rbChecked);
			// 
			// rbEmboss
			// 
			this.rbEmboss.AutoSize = true;
			this.rbEmboss.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.rbEmboss.Location = new System.Drawing.Point(524, 41);
			this.rbEmboss.Name = "rbEmboss";
			this.rbEmboss.Size = new System.Drawing.Size(84, 25);
			this.rbEmboss.TabIndex = 4;
			this.rbEmboss.TabStop = true;
			this.rbEmboss.Text = "Emboss";
			this.rbEmboss.UseVisualStyleBackColor = true;
			this.rbEmboss.Click += new System.EventHandler(this.rbChecked);
			// 
			// rbBlur
			// 
			this.rbBlur.AutoSize = true;
			this.rbBlur.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.rbBlur.Location = new System.Drawing.Point(524, 13);
			this.rbBlur.Name = "rbBlur";
			this.rbBlur.Size = new System.Drawing.Size(57, 25);
			this.rbBlur.TabIndex = 3;
			this.rbBlur.TabStop = true;
			this.rbBlur.Text = "Blur";
			this.rbBlur.UseVisualStyleBackColor = true;
			this.rbBlur.Click += new System.EventHandler(this.rbChecked);
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.btnReset.Location = new System.Drawing.Point(141, 31);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(123, 34);
			this.btnReset.TabIndex = 2;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.buttonClick);
			// 
			// btnChoose
			// 
			this.btnChoose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.btnChoose.Location = new System.Drawing.Point(12, 31);
			this.btnChoose.Name = "btnChoose";
			this.btnChoose.Size = new System.Drawing.Size(123, 34);
			this.btnChoose.TabIndex = 1;
			this.btnChoose.Text = "Choose";
			this.btnChoose.UseVisualStyleBackColor = true;
			this.btnChoose.Click += new System.EventHandler(this.buttonClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.pbInput);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox2.Location = new System.Drawing.Point(0, 100);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(431, 429);
			this.groupBox2.TabIndex = 2;
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
			this.groupBox3.TabIndex = 3;
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
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
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
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnChoose;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.PictureBox pbInput;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.PictureBox pbOutput;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label lbBlur;
		private System.Windows.Forms.TextBox txtBlur;
		private System.Windows.Forms.Button btnExecute;
		private System.Windows.Forms.RadioButton rbGauss;
		private System.Windows.Forms.RadioButton rbEmboss;
		private System.Windows.Forms.RadioButton rbBlur;
	}
}

