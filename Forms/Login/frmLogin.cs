using System;
using System.Windows.Forms;
using IUIS.Forms.Shared;
using IUIS.Models;
using IUIS.Services;
using IUIS.Utilities;

namespace IUIS.Forms.Login
{
    public partial class frmLogin : Form
    {
        private readonly LoginService _loginService;

        private string? _pendingUsername;
        private string? _pendingPassword;

        public frmLogin()
        {
            InitializeComponent();
            ModernUi.StyleForm(this, new System.Drawing.Size(430, 360));
            ModernUi.StylePrimaryButton(btnLogin);
            ModernUi.StyleTextBox(txtUsername);
            ModernUi.StyleTextBox(txtPassword);

            _loginService = new LoginService();
            AcceptButton = btnLogin;
            StartPosition = FormStartPosition.CenterScreen;
            txtUsername.Text = "admin";
            txtPassword.Text = "password";

            lblRoleDescription.Text = "Select a role to auto-fill demo credentials.";
            lblError.Text = string.Empty;
            lblLoginState.Text = string.Empty;

            btnRoleAdmin.FlatAppearance.BorderSize = 0;
            btnRoleTeacher.FlatAppearance.BorderSize = 0;
            btnRoleStudent.FlatAppearance.BorderSize = 0;
        }

        private void SetRoleUi(string role)
        {
            // Reset button colors
            btnRoleAdmin.BackColor = System.Drawing.Color.White;
            btnRoleTeacher.BackColor = System.Drawing.Color.White;
            btnRoleStudent.BackColor = System.Drawing.Color.White;

            // Accent/selected state
            var accent = System.Drawing.Color.FromArgb(37, 99, 235);

            if (string.Equals(role, "Admin", StringComparison.OrdinalIgnoreCase))
                btnRoleAdmin.BackColor = System.Drawing.Color.FromArgb(232, 240, 255);
            else if (string.Equals(role, "Teacher", StringComparison.OrdinalIgnoreCase))
                btnRoleTeacher.BackColor = System.Drawing.Color.FromArgb(232, 240, 255);
            else
                btnRoleStudent.BackColor = System.Drawing.Color.FromArgb(232, 240, 255);

            lblRoleDescription.Text = role switch
            {
                "Admin" => "Admin workspace: manage students, teachers, and academic records from one clean dashboard.",
                "Teacher" => "Teacher workspace: review assigned subjects and class rosters with a modern, fast view.",
                "Student" => "Student portal: view enrollment, academic status, and your enrolled subjects.",
                _ => "Select a role to auto-fill demo credentials."
            };
        }

        private void btnRoleAdmin_Click(object? sender, EventArgs e)
        {
            txtUsername.Text = "admin";
            txtPassword.Text = "password";
            txtPassword.Focus();
            SetRoleUi("Admin");
            lblError.Text = string.Empty;
        }

        private void btnRoleTeacher_Click(object? sender, EventArgs e)
        {
            txtUsername.Text = "teacher";
            txtPassword.Text = "password";
            txtPassword.Focus();
            SetRoleUi("Teacher");
            lblError.Text = string.Empty;
        }

        private void btnRoleStudent_Click(object? sender, EventArgs e)
        {
            txtUsername.Text = "student";
            txtPassword.Text = "password";
            txtPassword.Focus();
            SetRoleUi("Student");
            lblError.Text = string.Empty;
        }

        private void SetLoading(bool isLoading)
        {
            btnLogin.Enabled = !isLoading;
            txtUsername.Enabled = !isLoading;
            txtPassword.Enabled = !isLoading;

            btnRoleAdmin.Enabled = !isLoading;
            btnRoleTeacher.Enabled = !isLoading;
            btnRoleStudent.Enabled = !isLoading;

            lblLoginState.Text = isLoading ? "Signing in…" : string.Empty;
            lblError.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblError.Text = "Please enter both username and password.";
                MessageBox.Show("Please enter both username and password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Store pending values, then show loading for a short moment to mimic a real sign-in.
            _pendingUsername = username;
            _pendingPassword = password;

            SetLoading(true);
            loginTimer.Start();
        }

        private void loginTimer_Tick(object? sender, EventArgs e)
        {
            loginTimer.Stop();

            var username = _pendingUsername ?? string.Empty;
            var password = _pendingPassword ?? string.Empty;

            _pendingUsername = null;
            _pendingPassword = null;

            if (_loginService.Authenticate(username, password, out User? user) && user != null)
            {
                SessionManager.CurrentUser = user;

                var dashboard = new frmDashboard(user);
                dashboard.FormClosed += (_, __) =>
                {
                    SessionManager.ClearSession();
                    Application.Exit();
                };

                SetLoading(false);
                dashboard.Show();
                Hide();
            }
            else
            {
                SetLoading(false);
                lblError.Text = "Invalid username or password.";
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

