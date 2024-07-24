using System;
using System.Text;
class StringManipulation
{
    public void StringMan()
    {

        //String accessing and fetching
        String x = "hello";
        Console.WriteLine(x.Length);
        Console.WriteLine(x[2]);
        Console.WriteLine(x.Substring(2));
        Console.WriteLine(x.IndexOf("llo"));
        Console.WriteLine(x.IndexOf('o') + "\n");


        String name = "Ramz";
        DateTime date = DateTime.Now;
        //String Formatting
        Console.WriteLine("Hello {0}, today is {1}, it's {2:hh:mm:tt} now.", name, date.DayOfWeek, date);

        //String Interpolation
        Console.WriteLine($"Hello {name}, today is {date.DayOfWeek}, it's {date:hh:mm:tt} now.\n");

        //String Replace
        String str = "Hey people!";
        Console.WriteLine(str.Replace("people", "guys"));
        System.Console.WriteLine(str + "\n");//This won't change

        //String Replace (In the same string)
        StringBuilder sb = new StringBuilder("Hey people!");
        System.Console.WriteLine(sb.Replace("people", "guys"));
        System.Console.WriteLine(sb);
        sb[0] = 'i';
        System.Console.WriteLine(sb);


    }
}