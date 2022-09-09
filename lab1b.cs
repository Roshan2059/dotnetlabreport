using System;

public class program{
    public static void Main(string[] args){
        Console.WriteLine("Enter a number:\n");
        int a = Convert.ToInt32(Console.ReadLine());
        if(a%2 == 0){
            Console.WriteLine("The number is evem");
        }else{
            Console.WriteLine("The number is odd");
        }
    }
}