using System;
using System.Windows.Forms;

namespace IUIS.UserControls
{
    public partial class ucSidebar : UserControl
    {
        private Button _btnStudents;

        public event EventHandler<string>? NavigationRequested;

        public ucSidebar()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            _btnStudents = new Button();
            SuspendLayout();

            _btnStudents.Dock = DockStyle.Top;
            _btnStudents.Name = "btnStudents";
            _btnStudents.Size = new System.Drawing.Size(150, 40);
            _btnStudents.TabIndex = 0;
            _btnStudents.Text = "Students";
            _btnStudents.UseVisualStyleBackColor = true;
            _btnStudents.Click += btnStudents_Click;

            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(_btnStudents);
            Name = "ucSidebar";
            Size = new System.Drawing.Size(150, 40);
            ResumeLayout(false);
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            NavigationRequested?.Invoke(this, "Students");
        }
    }
}