interface MyFace{
    public void Get();
    public void Dis();
}
class MainClass : MyFace{
    string name;

    public void Get(){
        System.Console.WriteLine("Enter a name");
        name=Console.ReadLine();
    }

    public void Dis(){
        System.Console.WriteLine(name);
        System.Console.WriteLine("This is overrided");
    }
    public void MainMethod(){
        Get();
        Dis();
    }
}