﻿using System.Runtime.ConstrainedExecution;

namespace Exercise_12;

public class TestPaper: ITestPaper
{
    public string Subject { get; set; }
    public string[] MarkScheme { get; set; }
    public string PassMark { get; set; }

    public TestPaper(string subject, string[] markScheme, string passMark)
    {
        Subject = subject;
        MarkScheme = markScheme;
        PassMark = passMark;
    }
}

