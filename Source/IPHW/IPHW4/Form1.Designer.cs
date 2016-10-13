namespace IPHW4
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
			this.btnReset = new System.Windows.Forms.Button();
			this.btnChoose = new System.Windows.Forms.Button();
			this.ofdChooseImage = new System.Windows.Forms.OpenFileDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.lbStatus = new System.Windows.Forms.Label();
			this.btnProcess = new System.Windows.Forms.Button();
			this.cbIndex = new System.Windows.Forms.ComboBox();
			this.rbZoom = new System.Windows.Forms.RadioButton();
			this.rbRolation = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pbInput = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pbOutputBL = new System.Windows.Forms.PictureBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.pbOutputNN = new System.Windows.Forms.PictureBox();
			this.Control.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbOutputBL)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbOutputNN)).BeginInit();
			this.SuspendLayout();
			// 
			// Control
			// 
			this.Control.Controls.Add(this.txtFile);
			this.Control.Controls.Add(this.btnReset);
			this.Control.Controls.Add(this.btnChoose);
			this.Control.Dock = System.Windows.Forms.DockStyle.Left;
			this.Control.Location = new System.Drawing.Point(0, 0);
			this.Control.Name = "Control";
			this.Control.Size = new System.Drawing.Size(647, 100);
			this.Control.TabIndex = 1;
			this.Control.TabStop = false;
			this.Control.Text = "Image";
			// 
			// txtFile
			// 
			this.txtFile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.txtFile.Location = new System.Drawing.Point(151, 33);
			this.txtFile.Name = "txtFile";
			this.txtFile.ReadOnly = true;
			this.txtFile.Size = new System.Drawing.Size(333, 29);
			this.txtFile.TabIndex = 8;
			// 
			// btnReset
			// 
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.btnReset.Location = new System.Drawing.Point(501, 30);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(88, 34);
			this.btnReset.TabIndex = 2;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnClick);
			// 
			// btnChoose
			// 
			this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnChoose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.btnChoose.Location = new System.Drawing.Point(45, 31);
			this.btnChoose.Name = "btnChoose";
			this.btnChoose.Size = new System.Drawing.Size(88, 34);
			this.btnChoose.TabIndex = 1;
			this.btnChoose.Text = "Choose";
			this.btnChoose.UseVisualStyleBackColor = true;
			this.btnChoose.Click += new System.EventHandler(this.btnClick);
			// 
			// ofdChooseImage
			// 
			this.ofdChooseImage.Filter = "All files (*.*)|*.*";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox4);
			this.panel1.Controls.Add(this.Control);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1294, 100);
			this.panel1.TabIndex = 2;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.lbStatus);
			this.groupBox4.Controls.Add(this.btnProcess);
			this.groupBox4.Controls.Add(this.cbIndex);
			this.groupBox4.Controls.Add(this.rbZoom);
			this.groupBox4.Controls.Add(this.rbRolation);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox4.Location = new System.Drawing.Point(647, 0);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(641, 100);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Control";
			// 
			// lbStatus
			// 
			this.lbStatus.AutoSize = true;
			this.lbStatus.Location = new System.Drawing.Point(581, 28);
			this.lbStatus.Name = "lbStatus";
			this.lbStatus.Size = new System.Drawing.Size(0, 13);
			this.lbStatus.TabIndex = 9;
			// 
			// btnProcess
			// 
			this.btnProcess.Enabled = false;
			this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnProcess.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.btnProcess.Location = new System.Drawing.Point(487, 13);
			this.btnProcess.Name = "btnProcess";
			this.btnProcess.Size = new System.Drawing.Size(80, 80);
			this.btnProcess.TabIndex = 9;
			this.btnProcess.Text = "Process";
			this.btnProcess.UseVisualStyleBackColor = true;
			this.btnProcess.Click += new System.EventHandler(this.button1_Click);
			// 
			// cbIndex
			// 
			this.cbIndex.BackColor = System.Drawing.SystemColors.Control;
			this.cbIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbIndex.Enabled = false;
			this.cbIndex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbIndex.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.cbIndex.FormattingEnabled = true;
			this.cbIndex.Location = new System.Drawing.Point(189, 39);
			this.cbIndex.Name = "cbIndex";
			this.cbIndex.Size = new System.Drawing.Size(203, 29);
			this.cbIndex.TabIndex = 6;
			// 
			// rbZoom
			// 
			this.rbZoom.AutoSize = true;
			this.rbZoom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.rbZoom.Location = new System.Drawing.Point(19, 57);
			this.rbZoom.Name = "rbZoom";
			this.rbZoom.Size = new System.Drawing.Size(71, 25);
			this.rbZoom.TabIndex = 5;
			this.rbZoom.TabStop = true;
			this.rbZoom.Text = "Zoom";
			this.rbZoom.UseVisualStyleBackColor = true;
			this.rbZoom.CheckedChanged += new System.EventHandler(this.rbChecked);
			// 
			// rbRolation
			// 
			this.rbRolation.AutoSize = true;
			this.rbRolation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.rbRolation.Location = new System.Drawing.Point(19, 22);
			this.rbRolation.Name = "rbRolation";
			this.rbRolation.Size = new System.Drawing.Size(89, 25);
			this.rbRolation.TabIndex = 4;
			this.rbRolation.TabStop = true;
			this.rbRolation.Text = "Rolation";
			this.rbRolation.UseVisualStyleBackColor = true;
			this.rbRolation.CheckedChanged += new System.EventHandler(this.rbChecked);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.pbInput);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox2.Location = new System.Drawing.Point(0, 100);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(431, 429);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Input";
			// 
			// pbInput
			// 
			this.pbInput.Dock = System.Windows.Forms.DockStyle.Left;
			this.pbInput.Location = new System.Drawing.Point(3, 16);
			this.pbInput.Name = "pbInput";
			this.pbInput.Size = new System.Drawing.Size(410, 410);
			this.pbInput.TabIndex = 0;
			this.pbInput.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pbOutputBL);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox1.Location = new System.Drawing.Point(431, 100);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(431, 429);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Bilinear Interpolation";
			// 
			// pbOutputBL
			// 
			this.pbOutputBL.Dock = System.Windows.Forms.DockStyle.Left;
			this.pbOutputBL.Location = new System.Drawing.Point(3, 16);
			this.pbOutputBL.Name = "pbOutputBL";
			this.pbOutputBL.Size = new System.Drawing.Size(410, 410);
			this.pbOutputBL.TabIndex = 0;
			this.pbOutputBL.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.pbOutputNN);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox3.Location = new System.Drawing.Point(862, 100);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(431, 429);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Nearest Neighbor Interpolation ";
			// 
			// pbOutputNN
			// 
			this.pbOutputNN.Dock = System.Windows.Forms.DockStyle.Left;
			this.pbOutputNN.Location = new System.Drawing.Point(3, 16);
			this.pbOutputNN.Name = "pbOutputNN";
			this.pbOutputNN.Size = new System.Drawing.Size(410, 410);
			this.pbOutputNN.TabIndex = 0;
			this.pbOutputNN.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1294, 529);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Control.ResumeLayout(false);
			this.Control.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbOutputBL)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbOutputNN)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox Control;
		private System.Windows.Forms.TextBox txtFile;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnChoose;
		private System.Windows.Forms.OpenFileDialog ofdChooseImage;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.PictureBox pbInput;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ComboBox cbIndex;
		private System.Windows.Forms.RadioButton rbZoom;
		private System.Windows.Forms.RadioButton rbRolation;
		private System.Windows.Forms.Button btnProcess;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pbOutputBL;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.PictureBox pbOutputNN;
		private System.Windows.Forms.Label lbStatus;
	}
}

