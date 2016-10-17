namespace IPHW6
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtThreshold = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnProcess = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtFile = new System.Windows.Forms.TextBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnChoose = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.pbDX = new System.Windows.Forms.PictureBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.pbTheshold = new System.Windows.Forms.PictureBox();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.pbSED = new System.Windows.Forms.PictureBox();
			this.ofdChooseImage = new System.Windows.Forms.OpenFileDialog();
			this.pbInput = new System.Windows.Forms.PictureBox();
			this.pbDY = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbfx = new System.Windows.Forms.Label();
			this.lbfy = new System.Windows.Forms.Label();
			this.lbSED = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lbThreshold = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.panel3.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDX)).BeginInit();
			this.panel4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbTheshold)).BeginInit();
			this.groupBox7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbSED)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbDY)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1079, 111);
			this.panel1.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtThreshold);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.btnProcess);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox2.Location = new System.Drawing.Point(621, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(447, 111);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Control";
			// 
			// txtThreshold
			// 
			this.txtThreshold.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtThreshold.Location = new System.Drawing.Point(172, 49);
			this.txtThreshold.MaxLength = 3;
			this.txtThreshold.Name = "txtThreshold";
			this.txtThreshold.ReadOnly = true;
			this.txtThreshold.Size = new System.Drawing.Size(132, 29);
			this.txtThreshold.TabIndex = 12;
			this.txtThreshold.TextChanged += new System.EventHandler(this.txtThreshold_TextChanged);
			this.txtThreshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThreshold_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(4, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(162, 21);
			this.label4.TabIndex = 11;
			this.label4.Text = "Threshold Parameter";
			// 
			// btnProcess
			// 
			this.btnProcess.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnProcess.Enabled = false;
			this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnProcess.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.btnProcess.Location = new System.Drawing.Point(326, 19);
			this.btnProcess.Name = "btnProcess";
			this.btnProcess.Size = new System.Drawing.Size(80, 80);
			this.btnProcess.TabIndex = 10;
			this.btnProcess.Text = "Process";
			this.btnProcess.UseVisualStyleBackColor = true;
			this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtFile);
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.btnChoose);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(621, 111);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Image";
			// 
			// txtFile
			// 
			this.txtFile.Enabled = false;
			this.txtFile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.txtFile.Location = new System.Drawing.Point(134, 36);
			this.txtFile.Name = "txtFile";
			this.txtFile.ReadOnly = true;
			this.txtFile.Size = new System.Drawing.Size(333, 29);
			this.txtFile.TabIndex = 11;
			// 
			// btnReset
			// 
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.btnReset.Location = new System.Drawing.Point(484, 36);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(88, 29);
			this.btnReset.TabIndex = 10;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnClick);
			// 
			// btnChoose
			// 
			this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnChoose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.btnChoose.Location = new System.Drawing.Point(28, 36);
			this.btnChoose.Name = "btnChoose";
			this.btnChoose.Size = new System.Drawing.Size(88, 29);
			this.btnChoose.TabIndex = 9;
			this.btnChoose.Text = "Choose";
			this.btnChoose.UseVisualStyleBackColor = true;
			this.btnChoose.Click += new System.EventHandler(this.btnClick);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.groupBox4);
			this.panel2.Controls.Add(this.groupBox3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 111);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(356, 741);
			this.panel2.TabIndex = 1;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.pbDY);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox4.Location = new System.Drawing.Point(0, 369);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(356, 369);
			this.groupBox4.TabIndex = 1;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "d(f)/d(y)";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.pbInput);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox3.Location = new System.Drawing.Point(0, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(356, 369);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Input";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.groupBox8);
			this.panel3.Controls.Add(this.groupBox6);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(356, 111);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(356, 741);
			this.panel3.TabIndex = 2;
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.lbThreshold);
			this.groupBox8.Controls.Add(this.label5);
			this.groupBox8.Controls.Add(this.lbSED);
			this.groupBox8.Controls.Add(this.lbfy);
			this.groupBox8.Controls.Add(this.lbfx);
			this.groupBox8.Controls.Add(this.label3);
			this.groupBox8.Controls.Add(this.label2);
			this.groupBox8.Controls.Add(this.label1);
			this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox8.Location = new System.Drawing.Point(0, 369);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(356, 372);
			this.groupBox8.TabIndex = 1;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Information";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.pbDX);
			this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox6.Location = new System.Drawing.Point(0, 0);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(356, 369);
			this.groupBox6.TabIndex = 0;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "d(f)/d(x)";
			// 
			// pbDX
			// 
			this.pbDX.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbDX.Location = new System.Drawing.Point(3, 16);
			this.pbDX.Name = "pbDX";
			this.pbDX.Size = new System.Drawing.Size(350, 350);
			this.pbDX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbDX.TabIndex = 0;
			this.pbDX.TabStop = false;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.groupBox5);
			this.panel4.Controls.Add(this.groupBox7);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Location = new System.Drawing.Point(712, 111);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(356, 741);
			this.panel4.TabIndex = 3;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.pbTheshold);
			this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox5.Location = new System.Drawing.Point(0, 369);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(356, 369);
			this.groupBox5.TabIndex = 1;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Threshold";
			// 
			// pbTheshold
			// 
			this.pbTheshold.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbTheshold.Location = new System.Drawing.Point(3, 16);
			this.pbTheshold.Name = "pbTheshold";
			this.pbTheshold.Size = new System.Drawing.Size(350, 350);
			this.pbTheshold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbTheshold.TabIndex = 0;
			this.pbTheshold.TabStop = false;
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.pbSED);
			this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox7.Location = new System.Drawing.Point(0, 0);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(356, 369);
			this.groupBox7.TabIndex = 0;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Sobel Edge Detector";
			// 
			// pbSED
			// 
			this.pbSED.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbSED.Location = new System.Drawing.Point(3, 16);
			this.pbSED.Name = "pbSED";
			this.pbSED.Size = new System.Drawing.Size(350, 350);
			this.pbSED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbSED.TabIndex = 0;
			this.pbSED.TabStop = false;
			// 
			// pbInput
			// 
			this.pbInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbInput.Location = new System.Drawing.Point(3, 16);
			this.pbInput.Name = "pbInput";
			this.pbInput.Size = new System.Drawing.Size(350, 350);
			this.pbInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbInput.TabIndex = 0;
			this.pbInput.TabStop = false;
			// 
			// pbDY
			// 
			this.pbDY.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbDY.Location = new System.Drawing.Point(3, 16);
			this.pbDY.Name = "pbDY";
			this.pbDY.Size = new System.Drawing.Size(350, 350);
			this.pbDY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbDY.TabIndex = 0;
			this.pbDY.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(130, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "d(f)/d(x)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(130, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "d(f)/d(y)";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(130, 148);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(186, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Sobel Edge Detector";
			// 
			// lbfx
			// 
			this.lbfx.AutoSize = true;
			this.lbfx.Location = new System.Drawing.Point(106, 78);
			this.lbfx.Name = "lbfx";
			this.lbfx.Size = new System.Drawing.Size(0, 13);
			this.lbfx.TabIndex = 3;
			// 
			// lbfy
			// 
			this.lbfy.AutoSize = true;
			this.lbfy.Location = new System.Drawing.Point(106, 114);
			this.lbfy.Name = "lbfy";
			this.lbfy.Size = new System.Drawing.Size(0, 13);
			this.lbfy.TabIndex = 4;
			// 
			// lbSED
			// 
			this.lbSED.AutoSize = true;
			this.lbSED.Location = new System.Drawing.Point(106, 150);
			this.lbSED.Name = "lbSED";
			this.lbSED.Size = new System.Drawing.Size(0, 13);
			this.lbSED.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(130, 186);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 25);
			this.label5.TabIndex = 6;
			this.label5.Text = "Threshold";
			// 
			// lbThreshold
			// 
			this.lbThreshold.AutoSize = true;
			this.lbThreshold.Location = new System.Drawing.Point(106, 188);
			this.lbThreshold.Name = "lbThreshold";
			this.lbThreshold.Size = new System.Drawing.Size(0, 13);
			this.lbThreshold.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1079, 852);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbDX)).EndInit();
			this.panel4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbTheshold)).EndInit();
			this.groupBox7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbSED)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbDY)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtFile;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnChoose;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.PictureBox pbDX;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.PictureBox pbTheshold;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.PictureBox pbSED;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.OpenFileDialog ofdChooseImage;
		private System.Windows.Forms.Button btnProcess;
		private System.Windows.Forms.TextBox txtThreshold;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pbDY;
		private System.Windows.Forms.PictureBox pbInput;
		private System.Windows.Forms.Label lbThreshold;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbSED;
		private System.Windows.Forms.Label lbfy;
		private System.Windows.Forms.Label lbfx;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

