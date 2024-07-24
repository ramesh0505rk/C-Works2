class Person{
    private string name,qualification,university;
    private int age;
    public void GetData(string name,int age,string qualification,string university){
        this.name=name;
        this.age=age;
        this.qualification=qualification;
        this.university=university;
    }
    public void PrintData(){
        System.Console.WriteLine($"Name: {name}\nAge: {age}\nQualification: {qualification}\nUniversity: {university}");
    }
}
class ClassEg{
    public void MainMethod(){
        string name,qualification,university;
        int age;
        Console.Write("Enter your name: ");
        name=Console.ReadLine();
        Console.Write("Enter your age: ");
        age=Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter your qualification: ");
        qualification=Console.ReadLine();
        Console.Write("Enter your university: ");
        university=Console.ReadLine();

        Person p1=new Person();
        p1.GetData(name,age,qualification,university);
        p1.PrintData();

    }
}