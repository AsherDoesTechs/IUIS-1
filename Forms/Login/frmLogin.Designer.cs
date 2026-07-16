namespace IUIS.Forms.Login
{
    partial class frmLogin
    {
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRoleAdmin;
        private System.Windows.Forms.Button btnRoleTeacher;
        private System.Windows.Forms.Button btnRoleStudent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblRoleDescription;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblLoginState;
        private System.Windows.Forms.Timer loginTimer;

        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelCard = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTitle.Location = new System.Drawing.Point(82, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "IUIS Portal";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblSubtitle.Location = new System.Drawing.Point(82, 64);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(193, 15);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Sign in to continue to your workspace";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.pictureBox.Location = new System.Drawing.Point(28, 28);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(40, 40);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(28, 112);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(316, 25);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(28, 154);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(316, 25);
            this.txtPassword.TabIndex = 4;
// 
            // btnRoleAdmin
            // 
            this.btnRoleAdmin = new System.Windows.Forms.Button();
            this.btnRoleAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRoleAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnRoleAdmin.BackColor = System.Drawing.Color.White;
            this.btnRoleAdmin.Location = new System.Drawing.Point(28, 236);
            this.btnRoleAdmin.Name = "btnRoleAdmin";
            this.btnRoleAdmin.Size = new System.Drawing.Size(98, 32);
            this.btnRoleAdmin.TabIndex = 6;
            this.btnRoleAdmin.Text = "Admin";
            this.btnRoleAdmin.UseVisualStyleBackColor = false;
            this.btnRoleAdmin.Click += new System.EventHandler(this.btnRoleAdmin_Click);

            // 
            // btnRoleTeacher
            // 
            this.btnRoleTeacher = new System.Windows.Forms.Button();
            this.btnRoleTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleTeacher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRoleTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnRoleTeacher.BackColor = System.Drawing.Color.White;
            this.btnRoleTeacher.Location = new System.Drawing.Point(126, 236);
            this.btnRoleTeacher.Name = "btnRoleTeacher";
            this.btnRoleTeacher.Size = new System.Drawing.Size(98, 32);
            this.btnRoleTeacher.TabIndex = 7;
            this.btnRoleTeacher.Text = "Teacher";
            this.btnRoleTeacher.UseVisualStyleBackColor = false;
            this.btnRoleTeacher.Click += new System.EventHandler(this.btnRoleTeacher_Click);

            // 
            // btnRoleStudent
            // 
            this.btnRoleStudent = new System.Windows.Forms.Button();
            this.btnRoleStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRoleStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnRoleStudent.BackColor = System.Drawing.Color.White;
            this.btnRoleStudent.Location = new System.Drawing.Point(224, 236);
            this.btnRoleStudent.Name = "btnRoleStudent";
            this.btnRoleStudent.Size = new System.Drawing.Size(120, 32);
            this.btnRoleStudent.TabIndex = 8;
            this.btnRoleStudent.Text = "Student";
            this.btnRoleStudent.UseVisualStyleBackColor = false;
            this.btnRoleStudent.Click += new System.EventHandler(this.btnRoleStudent_Click);

            // 
            // lblRoleDescription
            // 
            this.lblRoleDescription = new System.Windows.Forms.Label();
            this.lblRoleDescription.AutoSize = false;
            this.lblRoleDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRoleDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblRoleDescription.Location = new System.Drawing.Point(28, 270);
            this.lblRoleDescription.Name = "lblRoleDescription";
            this.lblRoleDescription.Size = new System.Drawing.Size(316, 32);
            this.lblRoleDescription.TabIndex = 9;
            this.lblRoleDescription.Text = "Select a role to auto-fill demo credentials.";
            this.lblRoleDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblError
            // 
            this.lblError = new System.Windows.Forms.Label();
            this.lblError.AutoSize = false;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblError.Location = new System.Drawing.Point(28, 302);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(316, 16);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "";

            // 
            // lblLoginState
            // 
            this.lblLoginState = new System.Windows.Forms.Label();
            this.lblLoginState.AutoSize = false;
            this.lblLoginState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblLoginState.Location = new System.Drawing.Point(28, 222);
            this.lblLoginState.Name = "lblLoginState";
            this.lblLoginState.Size = new System.Drawing.Size(316, 14);
            this.lblLoginState.TabIndex = 11;
            this.lblLoginState.Text = "";
            
            // 
            // loginTimer
            // 
            this.loginTimer = new System.Windows.Forms.Timer();
            this.loginTimer.Interval = 900;
            this.loginTimer.Tick += new System.EventHandler(this.loginTimer_Tick);

            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(28, 202);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(316, 42);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Sign In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelCard
            // 
            this.panelCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.lblLoginState);
            this.panelCard.Controls.Add(this.lblError);
            this.panelCard.Controls.Add(this.lblRoleDescription);
            this.panelCard.Controls.Add(this.btnRoleStudent);
            this.panelCard.Controls.Add(this.btnRoleTeacher);
            this.panelCard.Controls.Add(this.btnRoleAdmin);
            this.panelCard.Controls.Add(this.btnLogin);
            this.panelCard.Controls.Add(this.txtPassword);
            this.panelCard.Controls.Add(this.txtUsername);
            this.panelCard.Controls.Add(this.lblSubtitle);
            this.panelCard.Controls.Add(this.lblTitle);
            this.panelCard.Controls.Add(this.pictureBox);
            this.panelCard.Location = new System.Drawing.Point(24, 24);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(372, 322);
            this.panelCard.TabIndex = 6;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(420, 372);
            this.Controls.Add(this.panelCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
