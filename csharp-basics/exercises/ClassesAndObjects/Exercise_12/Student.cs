namespace Exercise_12;

public class Student:IStundent
{
    public string[] TestsTaken { get; set; }

    public Student()
    {
        TestsTaken = new string[] { "No tests taken" };
    }
    public void TakeTest(ITestPaper paper, string[] answers)
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
        double percent = prePer * 100;

        Console.WriteLine(percent >= passValue ? $" {paper.Subject}: Passed! {Math.Round(percent,0)}%"  : $"{paper.Subject}: Failed! {Math.Round(percent,0)}%");
    }
}