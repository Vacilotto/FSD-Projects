using System;
DoApp();

void DoApp(){
    DateTime now = DateTime.Now;
    Console.WriteLine("Current date and time are : " + now.ToString());
    Console.WriteLine("Default short date string : "+ now.ToShortDateString());
    Console.WriteLine("Default short time string : "+ now.ToShortTimeString());
    Console.WriteLine("Default long date string : "+ now.ToLongDateString());
    Console.WriteLine("Default long time string : "+ now.ToLongTimeString());
    Console.WriteLine("Custom date strings : "+now.ToString("yyMMdd HHmmss"));
    Console.WriteLine("Adding 5 days to today:" + now.AddDays(5));
    Console.WriteLine("Subtracting 5 days to today:" + now.AddDays(-5));

    DateTime date1 = new DateTime(2022, 1, 3, 14,0, 15);
    DateTime date2 = new DateTime(2022, 1, 2, 4,0, 15);
    TimeSpan time1 = date1-date2;
    Console.WriteLine($"Timespan between date1 and date2 is {time1.Days} days and {time1.Hours} hours = {time1.TotalHours} total hours");
    }