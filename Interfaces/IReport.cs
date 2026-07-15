namespace IUIS.Interfaces
{
    public interface IReport
    {
        void GenerateReport(string reportType, string outputPath);
        string GetSummaryData();
    }
}