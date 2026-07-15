using System;
using System.Windows.Forms;
using IUIS.Services;

namespace IUIS.Forms.Shared
{
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            var user = SessionManager.CurrentUser;
            if (user != null)
            {
                lblUsername.Text = $"Username: {user.Username}";
                lblRole.Text = $"Role: {user.Role}";
                lblLastLogin.Text = $"Last Login: {user.LastLogin}";
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // Logic to open a password reset dialog
        }
    }
}