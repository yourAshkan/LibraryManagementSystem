using System.Globalization;

namespace LibraryManagementSystem;

public static class Tools
{
    public static DateTime PersianCalendar(DateTime dateTime)
    {
        PersianCalendar pc = new PersianCalendar();
        var year = pc.GetYear(dateTime);
        var month = pc.GetMonth(dateTime);
        var day = pc.GetDayOfMonth(dateTime);
        DateTime date = new DateTime(year, month, day);

        return date;
    }
}
