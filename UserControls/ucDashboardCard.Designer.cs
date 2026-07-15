namespace IUIS.UserControls.DashboardCards
{
    partial class ucDashboardCard
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblValue;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValue.Location = new System.Drawing.Point(10, 35);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(53, 25);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "Value";
            // 
            // ucDashboardCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblTitle);
            this.Name = "ucDashboardCard";
            this.Size = new System.Drawing.Size(200, 80);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}