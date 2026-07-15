partial class frmEditGradeDialog
{
    private System.Windows.Forms.TextBox txtScore;
    private System.Windows.Forms.Button btnSave;

    private void InitializeComponent()
    {
        this.txtScore = new System.Windows.Forms.TextBox();
        this.btnSave = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // txtScore
        // 
        this.txtScore.Location = new System.Drawing.Point(12, 12);
        this.txtScore.Name = "txtScore";
        this.txtScore.PlaceholderText = "Score";
        this.txtScore.Size = new System.Drawing.Size(260, 23);
        this.txtScore.TabIndex = 0;
        // 
        // btnSave
        // 
        this.btnSave.Location = new System.Drawing.Point(197, 41);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(75, 23);
        this.btnSave.TabIndex = 1;
        this.btnSave.Text = "Save";
        this.btnSave.UseVisualStyleBackColor = true;
        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
        // 
        // frmEditGradeDialog
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(284, 76);
        this.Controls.Add(this.btnSave);
        this.Controls.Add(this.txtScore);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "frmEditGradeDialog";
        this.Text = "Edit Grade";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}