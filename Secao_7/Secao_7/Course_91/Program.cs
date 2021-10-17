using System;

namespace Course_91 {
    class Program {
        static void Main(string[] args) {
            DateTime d = new DateTime(2001, 08, 25);

            TimeSpan x = DateTime.Now.Subtract(d);
            Console.WriteLine(d);
            Console.WriteLine((x.TotalDays/365));

            /*Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(d.ToLongTimeString());
            Console.WriteLine(d.ToShortDateString());
            Console.WriteLine(d.ToShortTimeString());

            Console.WriteLine(d.ToString());

            Console.WriteLine(d.ToString("MM-yyyy-dd mm:HH:ss"));

            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Milis: " + d.Millisecond);
            Console.WriteLine("8) Second: " + d.Second);
            Console.WriteLine("9) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("10) Year: " + d.Year);*/
        }
    }
}
