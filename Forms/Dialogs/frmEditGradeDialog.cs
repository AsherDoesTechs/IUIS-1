using IUIS.Models;
using IUIS.Repositories;

public partial class frmEditGradeDialog : Form
{
    private readonly JsonRepository<Grade> _gradeRepo = new JsonRepository<Grade>("Data/grades.json");
    private string _enrollmentId;

    public frmEditGradeDialog(string enrollmentId)
    {
        InitializeComponent();
        _enrollmentId = enrollmentId;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        var grade = new Grade
        {
            EnrollmentId = _enrollmentId,
            Score = decimal.Parse(txtScore.Text)
        };
        _gradeRepo.Add(grade);
        this.DialogResult = DialogResult.OK;
    }
}