//Multilevel inheritance
class GrandFather{
    public int resource=500000;
}
class Father:GrandFather{
    public int resource2=700000;
}
class InheritanceEg:Father{
    public void MainMethod(){
        System.Console.WriteLine("Total Resource: "+(resource+resource2));
    }
}

//Hierarchical inheritance
class GrandClass{
    public void RootMethod(){
        System.Console.WriteLine("This is the root message");
    }
}

class Child1:GrandClass{
    //overriding RootMethod
    void RootMethod(){
        System.Console.WriteLine("Overwriting root message");
    }
}
class Child2:GrandClass{
    void MyMethod(){
        RootMethod();//calling the inherited method
    }
}
class Child3:GrandClass{
    //didn't use the inherited method "RootMethod", but it's still inside the Child3 class implicitly
    void MyMethod(){
        System.Console.WriteLine("Hello");
    }
}

//Single Inheritance
class Base{
    public int baseValue=100;
}
class Sub:Base{
    void MyMethod(){
        System.Console.WriteLine("The base value: "+baseValue);
    }
}