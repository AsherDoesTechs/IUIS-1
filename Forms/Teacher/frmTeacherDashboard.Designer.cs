namespace IUIS.Forms.Teacher
{
    partial class frmTeacherDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblAssigned;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Panel panelMetrics;
        private System.Windows.Forms.Label lblSubjectCaption;
        private System.Windows.Forms.Label lblSubjectCount;
        private System.Windows.Forms.Label lblStudentCaption;
        private System.Windows.Forms.Label lblStudentCount;
        private System.Windows.Forms.Label lblSubjectsTitle;
        private System.Windows.Forms.Label lblRosterTitle;
        private System.Windows.Forms.DataGridView dgvTeacherSubjects;
        private System.Windows.Forms.DataGridView dgvStudents;

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
            panelHeader = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            lblTeacherName = new System.Windows.Forms.Label();
            lblDepartment = new System.Windows.Forms.Label();
            lblAssigned = new System.Windows.Forms.Label();
            lblRank = new System.Windows.Forms.Label();
            panelMetrics = new System.Windows.Forms.Panel();
            lblSubjectCaption = new System.Windows.Forms.Label();
            lblSubjectCount = new System.Windows.Forms.Label();
            lblStudentCaption = new System.Windows.Forms.Label();
            lblStudentCount = new System.Windows.Forms.Label();
            lblSubjectsTitle = new System.Windows.Forms.Label();
            lblRosterTitle = new System.Windows.Forms.Label();
            dgvTeacherSubjects = new System.Windows.Forms.DataGridView();
            dgvStudents = new System.Windows.Forms.DataGridView();
            panelHeader.SuspendLayout();
            panelMetrics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeacherSubjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();

            panelHeader.BackColor = System.Drawing.Color.White;
            panelHeader.Controls.Add(lblRank);
            panelHeader.Controls.Add(lblAssigned);
            panelHeader.Controls.Add(lblDepartment);
            panelHeader.Controls.Add(lblTeacherName);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new System.Drawing.Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(900, 142);
            panelHeader.TabIndex = 0;

            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTitle.Location = new System.Drawing.Point(28, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(268, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Teacher Workspace";

            lblTeacherName.AutoSize = true;
            lblTeacherName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTeacherName.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            lblTeacherName.Location = new System.Drawing.Point(31, 70);
            lblTeacherName.Name = "lblTeacherName";
            lblTeacherName.Size = new System.Drawing.Size(107, 20);
            lblTeacherName.TabIndex = 1;
            lblTeacherName.Text = "Teacher Name";

            lblDepartment.AutoSize = true;
            lblDepartment.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblDepartment.Location = new System.Drawing.Point(31, 96);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new System.Drawing.Size(70, 15);
            lblDepartment.TabIndex = 2;
            lblDepartment.Text = "Department";

            lblAssigned.AutoSize = true;
            lblAssigned.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblAssigned.Location = new System.Drawing.Point(31, 117);
            lblAssigned.Name = "lblAssigned";
            lblAssigned.Size = new System.Drawing.Size(104, 15);
            lblAssigned.TabIndex = 3;
            lblAssigned.Text = "Assigned subjects";

            lblRank.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblRank.BackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            lblRank.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblRank.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175);
            lblRank.Location = new System.Drawing.Point(697, 31);
            lblRank.Name = "lblRank";
            lblRank.Size = new System.Drawing.Size(172, 30);
            lblRank.TabIndex = 4;
            lblRank.Text = "Teacher";
            lblRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            panelMetrics.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelMetrics.BackColor = System.Drawing.Color.White;
            panelMetrics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelMetrics.Controls.Add(lblStudentCaption);
            panelMetrics.Controls.Add(lblStudentCount);
            panelMetrics.Controls.Add(lblSubjectCaption);
            panelMetrics.Controls.Add(lblSubjectCount);
            panelMetrics.Location = new System.Drawing.Point(28, 164);
            panelMetrics.Name = "panelMetrics";
            panelMetrics.Size = new System.Drawing.Size(841, 88);
            panelMetrics.TabIndex = 1;

            lblSubjectCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSubjectCount.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblSubjectCount.Location = new System.Drawing.Point(24, 15);
            lblSubjectCount.Name = "lblSubjectCount";
            lblSubjectCount.Size = new System.Drawing.Size(90, 38);
            lblSubjectCount.TabIndex = 0;
            lblSubjectCount.Text = "0";

            lblSubjectCaption.AutoSize = true;
            lblSubjectCaption.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblSubjectCaption.Location = new System.Drawing.Point(28, 55);
            lblSubjectCaption.Name = "lblSubjectCaption";
            lblSubjectCaption.Size = new System.Drawing.Size(100, 15);
            lblSubjectCaption.TabIndex = 1;
            lblSubjectCaption.Text = "Assigned subjects";

            lblStudentCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblStudentCount.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblStudentCount.Location = new System.Drawing.Point(248, 15);
            lblStudentCount.Name = "lblStudentCount";
            lblStudentCount.Size = new System.Drawing.Size(90, 38);
            lblStudentCount.TabIndex = 2;
            lblStudentCount.Text = "0";

            lblStudentCaption.AutoSize = true;
            lblStudentCaption.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblStudentCaption.Location = new System.Drawing.Point(252, 55);
            lblStudentCaption.Name = "lblStudentCaption";
            lblStudentCaption.Size = new System.Drawing.Size(92, 15);
            lblStudentCaption.TabIndex = 3;
            lblStudentCaption.Text = "Students in class";

            lblSubjectsTitle.AutoSize = true;
            lblSubjectsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSubjectsTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblSubjectsTitle.Location = new System.Drawing.Point(28, 276);
            lblSubjectsTitle.Name = "lblSubjectsTitle";
            lblSubjectsTitle.Size = new System.Drawing.Size(127, 20);
            lblSubjectsTitle.TabIndex = 2;
            lblSubjectsTitle.Text = "Assigned Subjects";

            dgvTeacherSubjects.AllowUserToAddRows = false;
            dgvTeacherSubjects.AllowUserToDeleteRows = false;
            dgvTeacherSubjects.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvTeacherSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeacherSubjects.Location = new System.Drawing.Point(28, 306);
            dgvTeacherSubjects.Name = "dgvTeacherSubjects";
            dgvTeacherSubjects.ReadOnly = true;
            dgvTeacherSubjects.Size = new System.Drawing.Size(841, 128);
            dgvTeacherSubjects.TabIndex = 3;

            lblRosterTitle.AutoSize = true;
            lblRosterTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblRosterTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblRosterTitle.Location = new System.Drawing.Point(28, 457);
            lblRosterTitle.Name = "lblRosterTitle";
            lblRosterTitle.Size = new System.Drawing.Size(90, 20);
            lblRosterTitle.TabIndex = 4;
            lblRosterTitle.Text = "Class Roster";

            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new System.Drawing.Point(28, 487);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.Size = new System.Drawing.Size(841, 94);
            dgvStudents.TabIndex = 5;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 247, 251);
            ClientSize = new System.Drawing.Size(900, 620);
            Controls.Add(dgvStudents);
            Controls.Add(lblRosterTitle);
            Controls.Add(dgvTeacherSubjects);
            Controls.Add(lblSubjectsTitle);
            Controls.Add(panelMetrics);
            Controls.Add(panelHeader);
            Name = "frmTeacherDashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Teacher Workspace";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMetrics.ResumeLayout(false);
            panelMetrics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeacherSubjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
