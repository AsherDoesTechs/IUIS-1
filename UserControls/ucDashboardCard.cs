using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace IUIS.UserControls.DashboardCards
{
    public partial class ucDashboardCard : UserControl
    {
        public ucDashboardCard()
        {
            InitializeComponent();
        }

        // Properties to customize the card from code only
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Title { get => lblTitle.Text; set => lblTitle.Text = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Value { get => lblValue.Text; set => lblValue.Text = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color CardColor { get => this.BackColor; set => this.BackColor = value; }
    }
}