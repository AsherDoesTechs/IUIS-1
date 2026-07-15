namespace IUIS.Forms.Shared
{
    partial class frmDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPrimary;
        private System.Windows.Forms.Panel panelCard;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblWelcome = new System.Windows.Forms.Label();
            lblRole = new System.Windows.Forms.Label();
            lblSummary = new System.Windows.Forms.Label();
            btnLogout = new System.Windows.Forms.Button();
            btnPrimary = new System.Windows.Forms.Button();
            panelCard = new System.Windows.Forms.Panel();
            panelCard.SuspendLayout();
            SuspendLayout();

            lblWelcome.AutoSize = true;
            lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            lblWelcome.Location = new System.Drawing.Point(28, 28);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(147, 37);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";

            lblRole.AutoSize = true;
            lblRole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            lblRole.Location = new System.Drawing.Point(31, 78);
            lblRole.Name = "lblRole";
            lblRole.Size = new System.Drawing.Size(35, 19);
            lblRole.TabIndex = 1;
            lblRole.Text = "Role";

            lblSummary.AutoSize = true;
            lblSummary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            lblSummary.Location = new System.Drawing.Point(31, 112);
            lblSummary.MaximumSize = new System.Drawing.Size(396, 0);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new System.Drawing.Size(207, 19);
            lblSummary.TabIndex = 2;
            lblSummary.Text = "Your personalized experience";

            btnPrimary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            btnPrimary.FlatAppearance.BorderSize = 0;
            btnPrimary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrimary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnPrimary.ForeColor = System.Drawing.Color.White;
            btnPrimary.Location = new System.Drawing.Point(31, 189);
            btnPrimary.Name = "btnPrimary";
            btnPrimary.Size = new System.Drawing.Size(396, 44);
            btnPrimary.TabIndex = 3;
            btnPrimary.Text = "Continue";
            btnPrimary.UseVisualStyleBackColor = false;
            btnPrimary.Click += new System.EventHandler(this.btnPrimary_Click);

            btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.Location = new System.Drawing.Point(31, 247);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(120, 38);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            panelCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            panelCard.BackColor = System.Drawing.Color.White;
            panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelCard.Controls.Add(btnLogout);
            panelCard.Controls.Add(btnPrimary);
            panelCard.Controls.Add(lblSummary);
            panelCard.Controls.Add(lblRole);
            panelCard.Controls.Add(lblWelcome);
            panelCard.Location = new System.Drawing.Point(28, 28);
            panelCard.Name = "panelCard";
            panelCard.Size = new System.Drawing.Size(460, 322);
            panelCard.TabIndex = 5;

            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            ClientSize = new System.Drawing.Size(516, 378);
            Controls.Add(panelCard);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmDashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            ResumeLayout(false);
        }
    }
}
