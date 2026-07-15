using System;
using System.Windows.Forms;
using IUIS.Forms.Admin;
using IUIS.Forms.Student;
using IUIS.Forms.Teacher;
using IUIS.Models;
using IUIS.Services;
using IUIS.Utilities;

namespace IUIS.Forms.Shared
{
    public partial class frmDashboard : Form
    {
        public frmDashboard(User user)
        {
            InitializeComponent();
            ModernUi.StyleForm(this, new System.Drawing.Size(520, 420));
            ModernUi.StylePrimaryButton(btnPrimary);
            ModernUi.StyleSecondaryButton(btnLogout);

            SessionManager.CurrentUser = user;
            Text = $"IUIS Portal - {user?.Role ?? "User"}";
            lblWelcome.Text = $"Welcome, {user?.Username ?? "User"}";
            lblRole.Text = $"{user?.Role ?? "Unknown"} workspace";
            lblSummary.Text = user?.Role switch
            {
                "Admin" => "Manage students, teachers, and academic records from one clean workspace.",
                "Teacher" => "Review assigned subjects and class rosters in your teaching workspace.",
                "Student" => "View your profile, status, and enrolled subjects from your student portal.",
                _ => "Access your personalized IUIS workspace."
            };

            if (user?.Role == "Admin")
            {
                btnPrimary.Text = "Open Admin Workspace";
            }
            else if (user?.Role == "Teacher")
            {
                btnPrimary.Text = "Open Teacher Workspace";
            }
            else
            {
                btnPrimary.Text = "Open Student Portal";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SessionManager.ClearSession();
            Close();
        }

        private void btnPrimary_Click(object sender, EventArgs e)
        {
            if (SessionManager.CurrentUser?.Role == "Admin")
            {
                OpenWorkspace(new frmAdminDashboard());
            }
            else if (SessionManager.CurrentUser?.Role == "Teacher")
            {
                OpenWorkspace(new frmTeacherDashboard());
            }
            else
            {
                OpenWorkspace(new frmStudentDashboard());
            }
        }

        private void OpenWorkspace(Form workspace)
        {
            Hide();
            workspace.FormClosed += (_, __) => Show();
            workspace.Show();
        }
    }
}
