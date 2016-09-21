namespace IPHW0
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
			this.pbControl = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.gbInput = new System.Windows.Forms.GroupBox();
			this.gbOutput = new System.Windows.Forms.GroupBox();
			this.ofdChooseFile = new System.Windows.Forms.OpenFileDialog();
			this.pbControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbControl
			// 
			this.pbControl.Controls.Add(this.button2);
			this.pbControl.Controls.Add(this.button1);
			this.pbControl.Controls.Add(this.btnLoad);
			this.pbControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbControl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pbControl.Location = new System.Drawing.Point(0, 0);
			this.pbControl.Name = "pbControl";
			this.pbControl.Size = new System.Drawing.Size(668, 100);
			this.pbControl.TabIndex = 0;
			this.pbControl.TabStop = false;
			this.pbControl.Text = "Control";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(297, 36);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 40);
			this.button2.TabIndex = 2;
			this.button2.Text = "Reset";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(167, 36);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 40);
			this.button1.TabIndex = 1;
			this.button1.Text = "Processing";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// btnLoad
			// 
			this.btnLoad.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLoad.Location = new System.Drawing.Point(36, 36);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(100, 40);
			this.btnLoad.TabIndex = 0;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = false;
			// 
			// gbInput
			// 
			this.gbInput.Dock = System.Windows.Forms.DockStyle.Left;
			this.gbInput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbInput.Location = new System.Drawing.Point(0, 100);
			this.gbInput.Name = "gbInput";
			this.gbInput.Size = new System.Drawing.Size(330, 330);
			this.gbInput.TabIndex = 1;
			this.gbInput.TabStop = false;
			this.gbInput.Text = "Input";
			// 
			// gbOutput
			// 
			this.gbOutput.Dock = System.Windows.Forms.DockStyle.Right;
			this.gbOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbOutput.Location = new System.Drawing.Point(338, 100);
			this.gbOutput.Name = "gbOutput";
			this.gbOutput.Size = new System.Drawing.Size(330, 330);
			this.gbOutput.TabIndex = 2;
			this.gbOutput.TabStop = false;
			this.gbOutput.Text = "Output";
			// 
			// ofdChooseFile
			// 
			this.ofdChooseFile.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 430);
			this.Controls.Add(this.gbOutput);
			this.Controls.Add(this.gbInput);
			this.Controls.Add(this.pbControl);
			this.Name = "Form1";
			this.Text = "HomeWork0";
			this.pbControl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox pbControl;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.GroupBox gbInput;
		private System.Windows.Forms.GroupBox gbOutput;
		private System.Windows.Forms.OpenFileDialog ofdChooseFile;
	}
}

