using System;

public class car{
    string model;
    int makeYear;

    public car(){
        Console.WriteLine("This is a constructor");
    }

    ~car(){
        Console.WriteLine("Object is destroyed");
    }

    public static void Main(string[] args){
        car tesla = new car();
    }
}