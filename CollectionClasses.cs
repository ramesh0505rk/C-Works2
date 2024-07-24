using System.Numerics;

class CollectionClasses
{
    public void CollectionList()
    {
        //1. List
        List<String> fruits = new List<string>();// Declaring list
        List<String> veggies = new List<String>() { "potato", "Onion", "Cabbage", "Carrot" };//Initializing list

        //list defining or adding item to the list
        fruits.Add("apple");
        fruits.Add("Orange");
        fruits.Add("Banana");

        foreach (var i in veggies)
            Console.WriteLine(i);

        foreach (var j in fruits)
            System.Console.WriteLine(j);

        //list inserting
        fruits.Insert(2, "Strawberry");
        foreach (var j in fruits)
            Console.WriteLine(j);

        //Access list element
        Console.WriteLine("\n" + fruits[1] + "\n");

        //Remove list element
        veggies.Remove("Carrot");
        foreach (var i in veggies)
            Console.WriteLine(i);

        //Remove at specific index
        fruits.RemoveAt(1);
        foreach (var j in fruits)
            System.Console.WriteLine(j);//orange is removed, now fruit in the index 1 is strawberry

        //Checking if the item is exist or not
        Console.WriteLine("\n" + fruits.Contains("apple"));
        Console.WriteLine(fruits.Contains("Orange"));

        //find index of the item
        System.Console.WriteLine("\n" + fruits.IndexOf("Banana"));

        //list to array
        String[] fruitsArray = fruits.ToArray();
        System.Console.WriteLine();
        for (int i = 0; i < fruitsArray.Length; i++)
            System.Console.Write(fruitsArray[i] + " ");

        //array to list
        int[] ar = { 6, 2, 4 };
        System.Console.WriteLine();
        List<int> numList = new List<int>(ar);
        foreach (int i in numList)
            System.Console.Write(i + " ");

        //list sorting
        System.Console.WriteLine();
        numList.Sort();
        foreach (int i in numList)
            System.Console.Write(i + " ");

        //list reversing
        System.Console.WriteLine();
        numList.Reverse();
        foreach (int i in numList)
            System.Console.Write(i + " ");
    }
    public void CollectionDictionary()
    {
        Dictionary<string, int> persons = new Dictionary<string, int>();
        persons.Add("Ramz", 22);
        persons.Add("John", 21);
        persons.Add("Rachel", 24);

        System.Console.WriteLine(persons["John"]);
        foreach (KeyValuePair<string, int> i in persons)
        {
            System.Console.WriteLine("Key: " + i.Key + ", Value: " + i.Value);
        }

        //check if the key or value exists
        System.Console.WriteLine(persons.ContainsKey("Ramz"));
        System.Console.WriteLine(persons.ContainsValue(24));

        //Removing a key value pair
        persons.Remove("John");
        System.Console.WriteLine("\nAfter Removing");
        foreach (KeyValuePair<string, int> i in persons)
        {
            System.Console.WriteLine("Key: " + i.Key + ", Value: " + i.Value);
        }

        //Dictionary initialization
        Dictionary<string, int> price = new Dictionary<string, int>{
            {"Banana",30},
            {"Grapes",40},
            {"Apple",50}
        };

        System.Console.WriteLine();
        foreach(KeyValuePair<string,int> i in price)
            System.Console.Write(i.Key+" "+i.Value+" ");

        //Modifying value
        price["Grapes"]=70;
        System.Console.WriteLine("\nModified values");
        foreach(KeyValuePair<string,int> i in price)
            System.Console.Write(i.Key+" "+i.Value+" ");
    }
}