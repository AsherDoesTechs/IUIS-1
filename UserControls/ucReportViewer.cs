using System.IO;
using System.Text;
using System.Windows.Forms;

namespace IUIS.UserControls.Reports
{
    public partial class ucReportViewer : UserControl
    {
        public ucReportViewer()
        {
            InitializeComponent();
        }

        public void ExportToCsv(DataGridView dgv, string filePath)
        {
            StringBuilder sb = new StringBuilder();

            // Write Headers
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                sb.Append(dgv.Columns[i].HeaderText + (i == dgv.Columns.Count - 1 ? "" : ","));
            }
            sb.AppendLine();

            // Write Data
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    string cellValue = row.Cells[i].Value?.ToString().Replace(",", " ") ?? "";
                    sb.Append(cellValue + (i == dgv.Columns.Count - 1 ? "" : ","));
                }
                sb.AppendLine();
            }

            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
            MessageBox.Show("Report exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}