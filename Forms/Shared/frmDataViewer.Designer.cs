namespace IUIS.Forms.Shared
{
    partial class frmDataViewer
    {
        private System.Windows.Forms.DataGridView dgvShared;

        private void InitializeComponent()
        {
            this.dgvShared = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShared)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShared
            // 
            this.dgvShared.AllowUserToAddRows = false;
            this.dgvShared.AllowUserToDeleteRows = false;
            this.dgvShared.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShared.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShared.Location = new System.Drawing.Point(0, 0);
            this.dgvShared.Name = "dgvShared";
            this.dgvShared.ReadOnly = true;
            this.dgvShared.RowTemplate.Height = 25;
            this.dgvShared.Size = new System.Drawing.Size(800, 450);
            this.dgvShared.TabIndex = 0;
            // 
            // frmDataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvShared);
            this.Name = "frmDataViewer";
            this.Text = "Data Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShared)).EndInit();
            this.ResumeLayout(false);
        }
    }
}