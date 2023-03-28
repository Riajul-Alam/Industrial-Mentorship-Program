

DateTime now = DateTime.Now;
Console.WriteLine(now);

DateTime birthday = new DateTime(1990, 12, 31, 23, 59, 59);
Console.WriteLine(birthday);


DateTime tomorrow = DateTime.Now.AddDays(1);
DateTime nextWeek = DateTime.Now.AddDays(7);
DateTime nextYear = DateTime.Now.AddYears(1);
Console.WriteLine(nextYear);
Console.WriteLine(nextWeek);
Console.WriteLine(tomorrow);


//Format
string dateString = DateTime.Now.ToString("yyyy-MM-dd");
string timeString = DateTime.Now.ToString("HH:mm:ss");
string dateTimeString = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
Console.WriteLine(dateString);
Console.WriteLine(timeString);
Console.WriteLine(dateTimeString);





