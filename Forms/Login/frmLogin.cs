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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_loginService.Authenticate(username, password, out User? user) && user != null)
            {
                SessionManager.CurrentUser = user;

                var dashboard = new frmDashboard(user);
                dashboard.FormClosed += (_, __) =>
                {
                    SessionManager.ClearSession();
                    Application.Exit();
                };

                dashboard.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
