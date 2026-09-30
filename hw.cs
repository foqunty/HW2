Console.WriteLine("Hello C#");
Console.WriteLine(" Sedat Çoban");
Console.WriteLine("Computer Engineering");
Console.WriteLine("2nd Year");
Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy"));
Console.WriteLine($"Today is {DateTime.Now.DayOfWeek}\n");




Console.Write("Enter the C value: ");
float c = float.Parse(Console.ReadLine()!);
float f = c*9/5+32;
Console.WriteLine($"Your fahrenheit value is: {f}F ");
