using System.Globalization;
using Microsoft.VisualBasic;

namespace Exercise_14;

public class Date
{
    private int _year;
    private int _month;
    private int _day;

    public Date(int year, int month, int day)
    {
        _year = year;
        _month = month; 
        _day = day;
    }

    public string Day(){

        DateTime dateValue = new DateTime(_year, _month, _day);
        CultureInfo culture = new CultureInfo("nl-NL");
        return culture.DateTimeFormat.GetDayName(dateValue.DayOfWeek);
    }
}