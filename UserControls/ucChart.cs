using System.Collections.Generic;
using System.Windows.Forms;

namespace IUIS.UserControls.Statistics
{
    public partial class ucChart : UserControl
    {
        public ucChart()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleMode = AutoScaleMode.None;
            this.Name = "ucChart";
            this.Size = new System.Drawing.Size(300, 200);
            this.ResumeLayout(false);
        }

        public void UpdateChart<T>(IEnumerable<T> data, string xMember, string yMember, object type)
        {
            // Placeholder implementation: charting is not available on this platform target.
        }
    }
}