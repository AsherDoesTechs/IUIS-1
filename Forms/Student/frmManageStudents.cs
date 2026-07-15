using System;
using System.Linq;
using System.Windows.Forms;
using IUIS.Models;
using IUIS.Repositories;
using IUIS.Utilities;
using StudentModel = IUIS.Models.Student;

namespace IUIS.Forms.Admin
{
    public partial class frmManageStudents : Form
    {
        private readonly JsonRepository<StudentModel> _repo;

        public frmManageStudents()
        {
            InitializeComponent();
            ModernUi.StyleForm(this, new System.Drawing.Size(360, 300));
            ModernUi.StyleGrid(dgvData);
            ModernUi.StyleTextBox(txtFirstName);
            ModernUi.StyleTextBox(txtLastName);
            ModernUi.StylePrimaryButton(btnSave);
            ModernUi.StyleSecondaryButton(btnDelete);

            _repo = new JsonRepository<StudentModel>("Data/students.json");
            LoadData();
        }

        private void LoadData()
        {
            dgvData.DataSource = null;
            dgvData.DataSource = _repo.GetAll().OrderBy(s => s.LastName).ToList();

            var idColumn = dgvData.Columns["Id"];
            if (idColumn != null)
            {
                idColumn.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter both first and last name.", "Student Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var student = new StudentModel
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                StudentNumber = IDGenerator.GenerateSequential("STU", _repo.GetAll().Select(s => s.StudentNumber)),
                Program = "General Studies",
                YearLevel = "1st Year",
                Status = "Active"
            };

            _repo.Add(student);
            txtFirstName.Clear();
            txtLastName.Clear();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                var selectedId = dgvData.SelectedRows[0].Cells["Id"].Value?.ToString();
                if (!string.IsNullOrWhiteSpace(selectedId))
                {
                    _repo.Delete(selectedId);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Select a student row before deleting.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
