using System.Windows.Forms;

namespace IUIS.Forms.Shared
{
    public partial class frmDataViewer : Form
    {
        public frmDataViewer(object dataSource, string title)
        {
            InitializeComponent();
            this.Text = title;
            dgvShared.DataSource = dataSource;
        }
    }
}