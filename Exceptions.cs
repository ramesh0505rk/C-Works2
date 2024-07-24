class Exceptions
{
    public void ExceptionsEg()
    {
        //Predefined errors (Eg. divide by zero (0) error)
        System.Console.WriteLine("Enter a numerator");
        int n = Convert.ToInt16(Console.ReadLine());
        System.Console.WriteLine("Enter a divisor");
        int d = Convert.ToInt16(Console.ReadLine());

        try
        {
            int res = n / d;
            System.Console.WriteLine(res);
        }
        catch (Exception e)
        {
            //printing predefined error message
            System.Console.WriteLine(e);

            //printing custom error message
            System.Console.WriteLine("You got divide by zero error");
        }

        //User defined errors
        System.Console.WriteLine("You are in a voting center, enter your age");
        int age = Convert.ToInt16(Console.ReadLine());

        try
        {
            if (age >= 18)
                System.Console.WriteLine("You can vote");
            else
                throw new Exception("You can't vote!");// custom error message
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e);
        }

    }
}