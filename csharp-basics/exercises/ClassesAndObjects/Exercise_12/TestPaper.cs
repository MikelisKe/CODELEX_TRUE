using System.Runtime.ConstrainedExecution;

namespace Exercise_12;

public interface ITestpaper
{
    string Subject { get; set; }
    string[] MarkScheme { get; set; }
    string PassMark { get; set; }
}

public interface IStudent
{
    string[] TestsTaken { get; set; }
    void TakeTest(ITestpaper paper, string[] answers);
}
public class TestPaper: ITestpaper
{
    public string Subject { get; set; }
    public string[] MarkScheme { get; set;}
    public string PassMark { get; set; }

    public TestPaper(string subject, string[] markScheme, string passMark)
    {
        Subject = subject;
        MarkScheme = markScheme;
        PassMark = passMark;
    }
}

public class Student : IStudent 
{
    public string[] TestsTaken { get; set; }

    public Student()
    {
        TestsTaken = new string[] { "No tests taken" };
    }
    public void TakeTest(ITestpaper paper, string[] answers)
    {
        int questNum = paper.MarkScheme.Length;
        int correct = 0;

        for (var i = 0; i < paper.MarkScheme.Length; i++)
        {
            if (answers[i] == paper.MarkScheme[i])
            {
                correct++;
            }
        }

        var passValue = Convert.ToInt32(paper.PassMark.TrimEnd('%'));
        double prePer = correct / Convert.ToDouble(questNum);
        double percent = prePer  * 100;

        Console.WriteLine(percent >= passValue ? "You Passed" : "Try Again");
    }
}
