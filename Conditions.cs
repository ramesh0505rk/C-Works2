using System.Numerics;

class Conditions
{
    public void ConditionStatements()
    {
        //Normal if-else statements examples
        Console.WriteLine("Enter a number");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x == 5)
            System.Console.WriteLine(true);
        else if (x == 10)
            System.Console.WriteLine(true);
        else
            System.Console.WriteLine(false);

        //Ternary operator
        Console.WriteLine(x == 5 ? true : (x == 10) ? true : false);

        //Switch examples
        switch (x)
        {
            case 5:
                System.Console.WriteLine(true);
                break;
            case 10:
                System.Console.WriteLine(true);
                break;
            default:
                System.Console.WriteLine(false);
                break;
        }
    }
}