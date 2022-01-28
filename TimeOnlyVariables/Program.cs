

//TimeOnly opensAt = TimeOnly.Parse("8:00 AM");

//Console.WriteLine(opensAt);

TimeOnly closeAt = TimeOnly.Parse("9:00 PM");
Console.WriteLine(closeAt);


TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine(rightNow);


TimeOnly opensAt = TimeOnly.Parse("8:30 PM");
Console.WriteLine(opensAt);

Console.ReadLine();