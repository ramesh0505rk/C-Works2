using System.Collections;
using System.Numerics;

class Loopings
{
    public void Looping()
    {

        //For loop example - array sorting
        int[] ar = new int[5];
        System.Console.WriteLine("Enter 5 numbers (unordered)");
        for (int i = 0; i < 5; i++)
        {
            ar[i] = Convert.ToInt32(Console.ReadLine());
        }
        int tp = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                if (ar[i] > ar[j])
                {
                    tp = ar[i];
                    ar[i] = ar[j];
                    ar[j] = tp;
                }
            }
        }

        System.Console.WriteLine("Sorted Array");
        for (int i = 0; i < 5; i++)
            System.Console.Write(ar[i] + " ");

        //While loop example - reverse number
        System.Console.WriteLine("Enter a numer (Should be more than a digit)");
        int n = Convert.ToInt16(Console.ReadLine());
        int res = 0;

        while (n != 0)
        {
            res = (res * 10) + (n % 10);
            n /= 10;
        }
        System.Console.WriteLine(res);

        //do while loop example
        int k = 0;
        do
        {
            System.Console.WriteLine(++k);
        } while (k < 5);

        int l = 0;
        do
        {
            System.Console.WriteLine(l + 1);
        } while (++l < 5);

        //Foreach loop
        List<String> list = new List<String>();
        list.Add("Tom");
        list.Add("Hardy");
        list.Add("Holland");

        foreach (String i in list)
            System.Console.WriteLine(i);
    }
}