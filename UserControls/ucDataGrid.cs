public class ucDataGrid : DataGridView
{
    public ucDataGrid()
    {
        this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.ReadOnly = true;
        this.AllowUserToAddRows = false;
        this.EnableHeadersVisualStyles = false;
        this.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
        this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
    }
}