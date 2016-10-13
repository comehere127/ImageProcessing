namespace IPTools
{
    partial class MainForm
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
            this.PicGoc = new System.Windows.Forms.PictureBox();
            this.PicKetqua = new System.Windows.Forms.PictureBox();
            this.LoadImage = new System.Windows.Forms.Button();
            this.GrayTransform = new System.Windows.Forms.Button();
            this.LogT = new System.Windows.Forms.Button();
            this.NegativeT = new System.Windows.Forms.Button();
            this.PowerT = new System.Windows.Forms.Button();
            this.PiecewiseLinearT = new System.Windows.Forms.Button();
            this.BitPlane1 = new System.Windows.Forms.Button();
            this.HisEqua = new System.Windows.Forms.Button();
            this.HistogramMatching = new System.Windows.Forms.Button();
            this.HistogramStatistic = new System.Windows.Forms.Button();
            this.LogicalProcess = new System.Windows.Forms.Button();
            this.PicDoituong = new System.Windows.Forms.PictureBox();
            this.Subtraction = new System.Windows.Forms.Button();
            this.AverageImage = new System.Windows.Forms.Button();
            this.FourierTransform = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Gradient = new System.Windows.Forms.Button();
            this.Laplace = new System.Windows.Forms.Button();
            this.Segment = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.AverageFilter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicKetqua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDoituong)).BeginInit();
            this.SuspendLayout();
            // 
            // PicGoc
            // 
            this.PicGoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicGoc.Location = new System.Drawing.Point(12, 12);
            this.PicGoc.Name = "PicGoc";
            this.PicGoc.Size = new System.Drawing.Size(325, 266);
            this.PicGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicGoc.TabIndex = 0;
            this.PicGoc.TabStop = false;
            this.PicGoc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicGoc_MouseMove);
            // 
            // PicKetqua
            // 
            this.PicKetqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicKetqua.Location = new System.Drawing.Point(12, 284);
            this.PicKetqua.Name = "PicKetqua";
            this.PicKetqua.Size = new System.Drawing.Size(325, 266);
            this.PicKetqua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicKetqua.TabIndex = 1;
            this.PicKetqua.TabStop = false;
            // 
            // LoadImage
            // 
            this.LoadImage.Location = new System.Drawing.Point(12, 556);
            this.LoadImage.Name = "LoadImage";
            this.LoadImage.Size = new System.Drawing.Size(103, 25);
            this.LoadImage.TabIndex = 2;
            this.LoadImage.Text = "Load Image";
            this.LoadImage.UseVisualStyleBackColor = true;
            this.LoadImage.Click += new System.EventHandler(this.LoadImage_Click);
            // 
            // GrayTransform
            // 
            this.GrayTransform.Location = new System.Drawing.Point(12, 587);
            this.GrayTransform.Name = "GrayTransform";
            this.GrayTransform.Size = new System.Drawing.Size(103, 25);
            this.GrayTransform.TabIndex = 3;
            this.GrayTransform.Text = "Gray transform";
            this.GrayTransform.UseVisualStyleBackColor = true;
            this.GrayTransform.Click += new System.EventHandler(this.GrayTransform_Click);
            // 
            // LogT
            // 
            this.LogT.Location = new System.Drawing.Point(124, 587);
            this.LogT.Name = "LogT";
            this.LogT.Size = new System.Drawing.Size(114, 25);
            this.LogT.TabIndex = 4;
            this.LogT.Text = "Log transform";
            this.LogT.UseVisualStyleBackColor = true;
            this.LogT.Click += new System.EventHandler(this.LogT_Click);
            // 
            // NegativeT
            // 
            this.NegativeT.Location = new System.Drawing.Point(124, 556);
            this.NegativeT.Name = "NegativeT";
            this.NegativeT.Size = new System.Drawing.Size(114, 25);
            this.NegativeT.TabIndex = 5;
            this.NegativeT.Text = "Negative";
            this.NegativeT.UseVisualStyleBackColor = true;
            this.NegativeT.Click += new System.EventHandler(this.NegativeT_Click);
            // 
            // PowerT
            // 
            this.PowerT.Location = new System.Drawing.Point(124, 618);
            this.PowerT.Name = "PowerT";
            this.PowerT.Size = new System.Drawing.Size(114, 25);
            this.PowerT.TabIndex = 6;
            this.PowerT.Text = "Power transform";
            this.PowerT.UseVisualStyleBackColor = true;
            this.PowerT.Click += new System.EventHandler(this.PowerT_Click);
            // 
            // PiecewiseLinearT
            // 
            this.PiecewiseLinearT.Location = new System.Drawing.Point(124, 649);
            this.PiecewiseLinearT.Name = "PiecewiseLinearT";
            this.PiecewiseLinearT.Size = new System.Drawing.Size(114, 25);
            this.PiecewiseLinearT.TabIndex = 7;
            this.PiecewiseLinearT.Text = "Piecewise Linear T";
            this.PiecewiseLinearT.UseVisualStyleBackColor = true;
            this.PiecewiseLinearT.Click += new System.EventHandler(this.PiecewiseLinearT_Click);
            // 
            // BitPlane1
            // 
            this.BitPlane1.Location = new System.Drawing.Point(253, 556);
            this.BitPlane1.Name = "BitPlane1";
            this.BitPlane1.Size = new System.Drawing.Size(114, 25);
            this.BitPlane1.TabIndex = 8;
            this.BitPlane1.Text = "Bit Plane 7";
            this.BitPlane1.UseVisualStyleBackColor = true;
            this.BitPlane1.Click += new System.EventHandler(this.BitPlane1_Click);
            // 
            // HisEqua
            // 
            this.HisEqua.Location = new System.Drawing.Point(253, 587);
            this.HisEqua.Name = "HisEqua";
            this.HisEqua.Size = new System.Drawing.Size(114, 25);
            this.HisEqua.TabIndex = 9;
            this.HisEqua.Text = "Histogram Equa";
            this.HisEqua.UseVisualStyleBackColor = true;
            this.HisEqua.Click += new System.EventHandler(this.HisEqua_Click);
            // 
            // HistogramMatching
            // 
            this.HistogramMatching.Location = new System.Drawing.Point(253, 618);
            this.HistogramMatching.Name = "HistogramMatching";
            this.HistogramMatching.Size = new System.Drawing.Size(114, 25);
            this.HistogramMatching.TabIndex = 10;
            this.HistogramMatching.Text = "Histogram Matching";
            this.HistogramMatching.UseVisualStyleBackColor = true;
            this.HistogramMatching.Click += new System.EventHandler(this.HistogramMatching_Click);
            // 
            // HistogramStatistic
            // 
            this.HistogramStatistic.Location = new System.Drawing.Point(253, 649);
            this.HistogramStatistic.Name = "HistogramStatistic";
            this.HistogramStatistic.Size = new System.Drawing.Size(114, 25);
            this.HistogramStatistic.TabIndex = 11;
            this.HistogramStatistic.Text = "Histogram Statistic";
            this.HistogramStatistic.UseVisualStyleBackColor = true;
            this.HistogramStatistic.Click += new System.EventHandler(this.HistogramStatistic_Click);
            // 
            // LogicalProcess
            // 
            this.LogicalProcess.Location = new System.Drawing.Point(373, 556);
            this.LogicalProcess.Name = "LogicalProcess";
            this.LogicalProcess.Size = new System.Drawing.Size(114, 25);
            this.LogicalProcess.TabIndex = 12;
            this.LogicalProcess.Text = "Logical Process";
            this.LogicalProcess.UseVisualStyleBackColor = true;
            this.LogicalProcess.Click += new System.EventHandler(this.LogicalProcess_Click);
            // 
            // PicDoituong
            // 
            this.PicDoituong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicDoituong.Location = new System.Drawing.Point(351, 12);
            this.PicDoituong.Name = "PicDoituong";
            this.PicDoituong.Size = new System.Drawing.Size(325, 266);
            this.PicDoituong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicDoituong.TabIndex = 13;
            this.PicDoituong.TabStop = false;
            // 
            // Subtraction
            // 
            this.Subtraction.Location = new System.Drawing.Point(373, 587);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(114, 25);
            this.Subtraction.TabIndex = 14;
            this.Subtraction.Text = "Subtraction Image";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.Subtraction_Click);
            // 
            // AverageImage
            // 
            this.AverageImage.Location = new System.Drawing.Point(373, 618);
            this.AverageImage.Name = "AverageImage";
            this.AverageImage.Size = new System.Drawing.Size(114, 25);
            this.AverageImage.TabIndex = 15;
            this.AverageImage.Text = "Average Image";
            this.AverageImage.UseVisualStyleBackColor = true;
            this.AverageImage.Click += new System.EventHandler(this.AverageImage_Click);
            // 
            // FourierTransform
            // 
            this.FourierTransform.Location = new System.Drawing.Point(535, 556);
            this.FourierTransform.Name = "FourierTransform";
            this.FourierTransform.Size = new System.Drawing.Size(114, 25);
            this.FourierTransform.TabIndex = 16;
            this.FourierTransform.Text = "Fourier Transform";
            this.FourierTransform.UseVisualStyleBackColor = true;
            this.FourierTransform.Click += new System.EventHandler(this.FourierTransform_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 25);
            this.button1.TabIndex = 17;
            this.button1.Text = "DeFourier Transform";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gradient
            // 
            this.Gradient.Location = new System.Drawing.Point(670, 556);
            this.Gradient.Name = "Gradient";
            this.Gradient.Size = new System.Drawing.Size(114, 25);
            this.Gradient.TabIndex = 18;
            this.Gradient.Text = "Gradient";
            this.Gradient.UseVisualStyleBackColor = true;
            this.Gradient.Click += new System.EventHandler(this.Gradient_Click);
            // 
            // Laplace
            // 
            this.Laplace.Location = new System.Drawing.Point(670, 587);
            this.Laplace.Name = "Laplace";
            this.Laplace.Size = new System.Drawing.Size(114, 25);
            this.Laplace.TabIndex = 19;
            this.Laplace.Text = "Laplace";
            this.Laplace.UseVisualStyleBackColor = true;
            this.Laplace.Click += new System.EventHandler(this.Laplace_Click);
            // 
            // Segment
            // 
            this.Segment.Location = new System.Drawing.Point(12, 618);
            this.Segment.Name = "Segment";
            this.Segment.Size = new System.Drawing.Size(103, 25);
            this.Segment.TabIndex = 20;
            this.Segment.Text = "Segment Fix";
            this.Segment.UseVisualStyleBackColor = true;
            this.Segment.Click += new System.EventHandler(this.Segment_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(351, 525);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(103, 25);
            this.Save.TabIndex = 21;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AverageFilter
            // 
            this.AverageFilter.Location = new System.Drawing.Point(790, 556);
            this.AverageFilter.Name = "AverageFilter";
            this.AverageFilter.Size = new System.Drawing.Size(114, 25);
            this.AverageFilter.TabIndex = 22;
            this.AverageFilter.Text = "Average Filter";
            this.AverageFilter.UseVisualStyleBackColor = true;
            this.AverageFilter.Click += new System.EventHandler(this.AverageFilter_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 649);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 25);
            this.button2.TabIndex = 23;
            this.button2.Text = "Segment Lap";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 688);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AverageFilter);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Segment);
            this.Controls.Add(this.Laplace);
            this.Controls.Add(this.Gradient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FourierTransform);
            this.Controls.Add(this.AverageImage);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.PicDoituong);
            this.Controls.Add(this.LogicalProcess);
            this.Controls.Add(this.HistogramStatistic);
            this.Controls.Add(this.HistogramMatching);
            this.Controls.Add(this.HisEqua);
            this.Controls.Add(this.BitPlane1);
            this.Controls.Add(this.PiecewiseLinearT);
            this.Controls.Add(this.PowerT);
            this.Controls.Add(this.NegativeT);
            this.Controls.Add(this.LogT);
            this.Controls.Add(this.GrayTransform);
            this.Controls.Add(this.LoadImage);
            this.Controls.Add(this.PicKetqua);
            this.Controls.Add(this.PicGoc);
            this.Name = "MainForm";
            this.Text = "Image Processing Demo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.PicGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicKetqua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDoituong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicGoc;
        private System.Windows.Forms.PictureBox PicKetqua;
        private System.Windows.Forms.Button LoadImage;
        private System.Windows.Forms.Button GrayTransform;
        private System.Windows.Forms.Button LogT;
        private System.Windows.Forms.Button NegativeT;
        private System.Windows.Forms.Button PowerT;
        private System.Windows.Forms.Button PiecewiseLinearT;
        private System.Windows.Forms.Button BitPlane1;
        private System.Windows.Forms.Button HisEqua;
        private System.Windows.Forms.Button HistogramMatching;
        private System.Windows.Forms.Button HistogramStatistic;
        private System.Windows.Forms.Button LogicalProcess;
        private System.Windows.Forms.PictureBox PicDoituong;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button AverageImage;
        private System.Windows.Forms.Button FourierTransform;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Gradient;
        private System.Windows.Forms.Button Laplace;
        private System.Windows.Forms.Button Segment;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button AverageFilter;
        private System.Windows.Forms.Button button2;
    }
}

