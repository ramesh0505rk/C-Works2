class Poly{
    void Dis(int x){
        System.Console.WriteLine("The value is: "+x);
    }
    void Dis(String x){
        System.Console.WriteLine("The value is: "+x);
    }
    void Dis(int x,int y){
        System.Console.WriteLine($"The values are: {x}, {y}");
    }
    char Dis(char x){
        return x;
    }
    public void MainMethod(){
        Dis(5);
        Dis("Ramz");
        Dis(10,20);
        System.Console.WriteLine("Returned value is: "+Dis('R'));
    }
}