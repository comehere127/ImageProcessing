namespace IPHW7
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
			this.btnProcess = new System.Windows.Forms.Button();
			this.txtFile = new System.Windows.Forms.TextBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnChoose = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.pbOutput = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pbInput = new System.Windows.Forms.PictureBox();
			this.ofdChooseImage = new System.Windows.Forms.OpenFileDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.txtK = new System.Windows.Forms.TextBox();
			this.txtThreshold = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSigma = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtSigma);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtThreshold);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtK);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnProcess);
			this.groupBox1.Controls.Add(this.txtFile);
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.btnChoose);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(714, 111);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Image";
			// 
			// btnProcess
			// 
			this.btnProcess.Enabled = false;
			this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnProcess.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.btnProcess.Location = new System.Drawing.Point(72, 66);
			this.btnProcess.Name = "btnProcess";
			this.btnProcess.Size = new System.Drawing.Size(88, 32);
			this.btnProcess.TabIndex = 12;
			this.btnProcess.Text = "Process";
			this.btnProcess.UseVisualStyleBackColor = true;
			this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
			// 
			// txtFile
			// 
			this.txtFile.Enabled = false;
			this.txtFile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.txtFile.Location = new System.Drawing.Point(178, 12);
			this.txtFile.Name = "txtFile";
			this.txtFile.ReadOnly = true;
			this.txtFile.Size = new System.Drawing.Size(333, 29);
			this.txtFile.TabIndex = 11;
			// 
			// btnReset
			// 
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.btnReset.Location = new System.Drawing.Point(528, 12);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(88, 29);
			this.btnReset.TabIndex = 10;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btn_Click);
			// 
			// btnChoose
			// 
			this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnChoose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.btnChoose.Location = new System.Drawing.Point(72, 12);
			this.btnChoose.Name = "btnChoose";
			this.btnChoose.Size = new System.Drawing.Size(88, 29);
			this.btnChoose.TabIndex = 9;
			this.btnChoose.Text = "Choose";
			this.btnChoose.UseVisualStyleBackColor = true;
			this.btnChoose.Click += new System.EventHandler(this.btn_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 111);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(714, 369);
			this.panel1.TabIndex = 2;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.pbOutput);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox3.Location = new System.Drawing.Point(356, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(356, 369);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Output";
			// 
			// pbOutput
			// 
			this.pbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbOutput.Location = new System.Drawing.Point(3, 16);
			this.pbOutput.Name = "pbOutput";
			this.pbOutput.Size = new System.Drawing.Size(350, 350);
			this.pbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbOutput.TabIndex = 1;
			this.pbOutput.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.pbInput);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(356, 369);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Input";
			// 
			// pbInput
			// 
			this.pbInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbInput.Location = new System.Drawing.Point(3, 16);
			this.pbInput.Name = "pbInput";
			this.pbInput.Size = new System.Drawing.Size(350, 350);
			this.pbInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbInput.TabIndex = 1;
			this.pbInput.TabStop = false;
			// 
			// ofdChooseImage
			// 
			this.ofdChooseImage.FileName = "openFileDialog1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(179, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 25);
			this.label1.TabIndex = 13;
			this.label1.Text = "k";
			// 
			// txtK
			// 
			this.txtK.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtK.Location = new System.Drawing.Point(210, 62);
			this.txtK.Name = "txtK";
			this.txtK.Size = new System.Drawing.Size(78, 29);
			this.txtK.TabIndex = 14;
			this.txtK.Text = "0.04";
			this.txtK.TextChanged += new System.EventHandler(this.txtParametter_TextChanged);
			this.txtK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametter_KeyPress);
			// 
			// txtThreshold
			// 
			this.txtThreshold.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtThreshold.Location = new System.Drawing.Point(395, 62);
			this.txtThreshold.Name = "txtThreshold";
			this.txtThreshold.Size = new System.Drawing.Size(84, 29);
			this.txtThreshold.TabIndex = 16;
			this.txtThreshold.Text = "1000";
			this.txtThreshold.TextChanged += new System.EventHandler(this.txtParametter_TextChanged);
			this.txtThreshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametter_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(294, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 25);
			this.label2.TabIndex = 15;
			this.label2.Text = "Threshold";
			// 
			// txtSigma
			// 
			this.txtSigma.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSigma.Location = new System.Drawing.Point(569, 62);
			this.txtSigma.Name = "txtSigma";
			this.txtSigma.Size = new System.Drawing.Size(80, 29);
			this.txtSigma.TabIndex = 18;
			this.txtSigma.Text = "1.4";
			this.txtSigma.TextChanged += new System.EventHandler(this.txtParametter_TextChanged);
			this.txtSigma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametter_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(495, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 25);
			this.label3.TabIndex = 17;
			this.label3.Text = "Sigma";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(714, 480);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbOutput)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtFile;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnChoose;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.PictureBox pbInput;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.PictureBox pbOutput;
		private System.Windows.Forms.Button btnProcess;
		private System.Windows.Forms.OpenFileDialog ofdChooseImage;
		private System.Windows.Forms.TextBox txtK;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSigma;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtThreshold;
		private System.Windows.Forms.Label label2;
	}
}

