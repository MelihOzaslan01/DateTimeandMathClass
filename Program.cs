Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);


Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);


Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());
Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());


Console.WriteLine(DateTime.Now.AddDays(5));
Console.WriteLine(DateTime.Now.AddHours(8));
Console.WriteLine(DateTime.Now.AddMinutes(16));
Console.WriteLine(DateTime.Now.AddMonths(8));
Console.WriteLine(DateTime.Now.AddYears(12));
Console.WriteLine(DateTime.Now.AddMilliseconds(1500));

// Date Time Format

Console.WriteLine(DateTime.Now.ToString("dd")); // 23
Console.WriteLine(DateTime.Now.ToString("ddd")); // Sun
Console.WriteLine(DateTime.Now.ToString("dddd")); // Sunday

Console.WriteLine(DateTime.Now.ToString("MM")); //01
Console.WriteLine(DateTime.Now.ToString("MMM")); // Jan
Console.WriteLine(DateTime.Now.ToString("MMMM")); // January

Console.WriteLine(DateTime.Now.ToString("yy")); // 22
Console.WriteLine(DateTime.Now.ToString("yyyy ")); // 2022


Console.WriteLine("***** Math Kütüphanesi ****");


// Math Kütüphanesi 

Console.WriteLine(Math.Abs(-64)); // Mutlak Değer İşlemi yapar
Console.WriteLine(Math.Sin(15)); // Sinus İşlemi Yapar
Console.WriteLine(Math.Cos(15)); // Cosinus İşlemi Yapar
Console.WriteLine(Math.Tan(15)); // Tanjant İşlemi Yapar


Console.WriteLine(Math.Ceiling(48.3)); // 49
Console.WriteLine(Math.Round(48.3));   // 48
Console.WriteLine(Math.Round(48.7));   //49
Console.WriteLine(Math.Floor(48.7));   //48

Console.WriteLine(Math.Max(8,16));
Console.WriteLine(Math.Min(8,16));

Console.WriteLine(Math.Pow(3,5)); // 3 Üzeri 5'i verir
Console.WriteLine(Math.Sqrt(25)); // 25'in karekökünü alır 
Console.WriteLine(Math.Log(9));  // 9'un e tabanındaki  logaritmik karşılığını verir
Console.WriteLine(Math.Exp(5));  // e üzeri 5'i  verir
Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanına göre karşılığını verir

                                










