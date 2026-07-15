namespace IUIS.Forms.Student
{
    partial class frmStudentDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblYearLevel;
        private System.Windows.Forms.Panel panelMetric;
        private System.Windows.Forms.Label lblCourseCount;
        private System.Windows.Forms.Label lblCourseCaption;
        private System.Windows.Forms.Label lblSubjectsTitle;
        private System.Windows.Forms.DataGridView dgvSubjects;

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
            lblStudentName = new System.Windows.Forms.Label();
            lblProgram = new System.Windows.Forms.Label();
            lblStudentNumber = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            lblYearLevel = new System.Windows.Forms.Label();
            panelMetric = new System.Windows.Forms.Panel();
            lblCourseCount = new System.Windows.Forms.Label();
            lblCourseCaption = new System.Windows.Forms.Label();
            lblSubjectsTitle = new System.Windows.Forms.Label();
            dgvSubjects = new System.Windows.Forms.DataGridView();
            panelHeader.SuspendLayout();
            panelMetric.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            SuspendLayout();

            panelHeader.BackColor = System.Drawing.Color.White;
            panelHeader.Controls.Add(lblYearLevel);
            panelHeader.Controls.Add(lblStatus);
            panelHeader.Controls.Add(lblStudentNumber);
            panelHeader.Controls.Add(lblProgram);
            panelHeader.Controls.Add(lblStudentName);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new System.Drawing.Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(860, 176);
            panelHeader.TabIndex = 0;

            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTitle.Location = new System.Drawing.Point(28, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(196, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Portal";

            lblStudentName.AutoSize = true;
            lblStudentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblStudentName.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            lblStudentName.Location = new System.Drawing.Point(31, 74);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new System.Drawing.Size(115, 21);
            lblStudentName.TabIndex = 1;
            lblStudentName.Text = "Student Name";

            lblProgram.AutoSize = true;
            lblProgram.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblProgram.Location = new System.Drawing.Point(31, 102);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new System.Drawing.Size(53, 15);
            lblProgram.TabIndex = 2;
            lblProgram.Text = "Program";

            lblStudentNumber.AutoSize = true;
            lblStudentNumber.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblStudentNumber.Location = new System.Drawing.Point(31, 132);
            lblStudentNumber.Name = "lblStudentNumber";
            lblStudentNumber.Size = new System.Drawing.Size(126, 15);
            lblStudentNumber.TabIndex = 3;
            lblStudentNumber.Text = "Student No: 00000000";

            lblStatus.AutoSize = true;
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblStatus.Location = new System.Drawing.Point(246, 132);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(77, 15);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status: Active";

            lblYearLevel.AutoSize = true;
            lblYearLevel.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblYearLevel.Location = new System.Drawing.Point(393, 132);
            lblYearLevel.Name = "lblYearLevel";
            lblYearLevel.Size = new System.Drawing.Size(108, 15);
            lblYearLevel.TabIndex = 5;
            lblYearLevel.Text = "Year Level: 1st Year";

            panelMetric.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelMetric.BackColor = System.Drawing.Color.White;
            panelMetric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelMetric.Controls.Add(lblCourseCaption);
            panelMetric.Controls.Add(lblCourseCount);
            panelMetric.Location = new System.Drawing.Point(28, 202);
            panelMetric.Name = "panelMetric";
            panelMetric.Size = new System.Drawing.Size(804, 84);
            panelMetric.TabIndex = 1;

            lblCourseCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCourseCount.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblCourseCount.Location = new System.Drawing.Point(24, 13);
            lblCourseCount.Name = "lblCourseCount";
            lblCourseCount.Size = new System.Drawing.Size(92, 38);
            lblCourseCount.TabIndex = 0;
            lblCourseCount.Text = "0";

            lblCourseCaption.AutoSize = true;
            lblCourseCaption.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblCourseCaption.Location = new System.Drawing.Point(28, 53);
            lblCourseCaption.Name = "lblCourseCaption";
            lblCourseCaption.Size = new System.Drawing.Size(95, 15);
            lblCourseCaption.TabIndex = 1;
            lblCourseCaption.Text = "Enrolled subjects";

            lblSubjectsTitle.AutoSize = true;
            lblSubjectsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSubjectsTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblSubjectsTitle.Location = new System.Drawing.Point(28, 315);
            lblSubjectsTitle.Name = "lblSubjectsTitle";
            lblSubjectsTitle.Size = new System.Drawing.Size(115, 20);
            lblSubjectsTitle.TabIndex = 2;
            lblSubjectsTitle.Text = "My Enrollment";

            dgvSubjects.AllowUserToAddRows = false;
            dgvSubjects.AllowUserToDeleteRows = false;
            dgvSubjects.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Location = new System.Drawing.Point(28, 345);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.ReadOnly = true;
            dgvSubjects.Size = new System.Drawing.Size(804, 178);
            dgvSubjects.TabIndex = 3;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 247, 251);
            ClientSize = new System.Drawing.Size(860, 560);
            Controls.Add(dgvSubjects);
            Controls.Add(lblSubjectsTitle);
            Controls.Add(panelMetric);
            Controls.Add(panelHeader);
            Name = "frmStudentDashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Student Portal";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMetric.ResumeLayout(false);
            panelMetric.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
