using System;

class program{
    public static void Main(string[] args){
        int a , b;
        Console.WriteLine("Enter a = ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter b = ");
        b = Convert.ToInt32(Console.ReadLine());
        int sum = a+b;
        int sub = a-b;
        int mul = a*b;
        int div= a/b;
        Console.WriteLine("Sum is = " + sum);
        Console.WriteLine("subtraction is = " + sub);
        Console.WriteLine("multiplication is = " + mul);
        Console.WriteLine("division is = " + div);

    }
}