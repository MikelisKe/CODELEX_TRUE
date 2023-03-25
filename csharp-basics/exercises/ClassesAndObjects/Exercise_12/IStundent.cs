namespace Exercise_12;

public interface IStundent
{
    string[] TestsTaken { get; set; }
    void TakeTest(ITestPaper paper, string[] answers);
}