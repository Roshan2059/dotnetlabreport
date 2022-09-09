using System;

class calculator{
    public int add(int a,int b){
        return a+b;
    }
    public int sub(int a,int b){
        return a-b;   
    }
    public int mul(int a,int b){
        return a*b;
    }
    public int div(int a,int b){
        return a/b;
    }
    public static void Main(string[] args){
        calculator calc = new calculator();
        Console.WriteLine("The sum is: " + calc.add(10,20));
        Console.WriteLine("The subtraction is: " + calc.sub(20,10));
        Console.WriteLine("The multiplication is: " + calc.mul(10,10));
        Console.WriteLine("The division is: " + calc.div(20,10));
        Console.ReadLine();
    }
}
