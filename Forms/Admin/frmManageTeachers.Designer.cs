namespace IUIS.Forms.Admin
{
    partial class frmManageTeachers
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.CheckedListBox checkedSubjects;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvTeachers;

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
            lblHeader = new System.Windows.Forms.Label();
            lblHint = new System.Windows.Forms.Label();
            txtFirstName = new System.Windows.Forms.TextBox();
            txtLastName = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtDepartment = new System.Windows.Forms.TextBox();
            txtSpecialization = new System.Windows.Forms.TextBox();
            checkedSubjects = new System.Windows.Forms.CheckedListBox();
            btnSave = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            dgvTeachers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
            SuspendLayout();

            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeader.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            lblHeader.Location = new System.Drawing.Point(18, 16);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(188, 30);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Teacher Records";

            lblHint.AutoSize = true;
            lblHint.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            lblHint.Location = new System.Drawing.Point(20, 52);
            lblHint.Name = "lblHint";
            lblHint.Size = new System.Drawing.Size(320, 15);
            lblHint.TabIndex = 1;
            lblHint.Text = "Add teachers and assign the subjects they can manage.";

            txtFirstName.Location = new System.Drawing.Point(20, 88);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First name";
            txtFirstName.Size = new System.Drawing.Size(150, 23);
            txtFirstName.TabIndex = 2;

            txtLastName.Location = new System.Drawing.Point(180, 88);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last name";
            txtLastName.Size = new System.Drawing.Size(150, 23);
            txtLastName.TabIndex = 3;

            txtEmail.Location = new System.Drawing.Point(340, 88);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new System.Drawing.Size(194, 23);
            txtEmail.TabIndex = 4;

            txtDepartment.Location = new System.Drawing.Point(20, 124);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.PlaceholderText = "Department";
            txtDepartment.Size = new System.Drawing.Size(150, 23);
            txtDepartment.TabIndex = 5;

            txtSpecialization.Location = new System.Drawing.Point(180, 124);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.PlaceholderText = "Specialization";
            txtSpecialization.Size = new System.Drawing.Size(150, 23);
            txtSpecialization.TabIndex = 6;

            checkedSubjects.CheckOnClick = true;
            checkedSubjects.FormattingEnabled = true;
            checkedSubjects.Location = new System.Drawing.Point(340, 124);
            checkedSubjects.Name = "checkedSubjects";
            checkedSubjects.Size = new System.Drawing.Size(194, 58);
            checkedSubjects.TabIndex = 7;

            btnSave.Location = new System.Drawing.Point(550, 88);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(132, 34);
            btnSave.TabIndex = 8;
            btnSave.Text = "Add Teacher";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += new System.EventHandler(btnSave_Click);

            btnDelete.Location = new System.Drawing.Point(550, 134);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(132, 34);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Remove";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += new System.EventHandler(btnDelete_Click);

            dgvTeachers.AllowUserToAddRows = false;
            dgvTeachers.AllowUserToDeleteRows = false;
            dgvTeachers.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeachers.Location = new System.Drawing.Point(20, 208);
            dgvTeachers.Name = "dgvTeachers";
            dgvTeachers.ReadOnly = true;
            dgvTeachers.Size = new System.Drawing.Size(662, 266);
            dgvTeachers.TabIndex = 10;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 247, 251);
            ClientSize = new System.Drawing.Size(704, 500);
            Controls.Add(dgvTeachers);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(checkedSubjects);
            Controls.Add(txtSpecialization);
            Controls.Add(txtDepartment);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblHint);
            Controls.Add(lblHeader);
            Name = "frmManageTeachers";
            Text = "Manage Teachers";
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
