namespace test
{
	partial class Form10
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
			System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "STT"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
			System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Mã câu hỏi"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold));
			System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "Môn học"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold));
			System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "Giáo viên"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold));
			System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "Tiêu đề"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold));
			this.label1 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(293, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(258, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "DANH SÁCH CÂU HỎI";
			// 
			// listView1
			// 
			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15});
			this.listView1.Location = new System.Drawing.Point(1, 105);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(749, 239);
			this.listView1.TabIndex = 7;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.SmallIcon;
			// 
			// Form10
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(762, 448);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form10";
			this.Text = "Form10";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView listView1;
	}
}