using System;

class rectangle{
    public int area(int length,int breadth){
        int area = length * breadth;
        return area;
    }

    public int perimeter(int length,int breadth){
        int per = 2 * (length + breadth);
        return per;
    }

    public static void Main(string[] args){
        rectangle rect = new rectangle();
        Console.WriteLine("The area is: " + rect.area(10,20));
        Console.WriteLine("The perimeter is: " + rect.perimeter(10,20));    
    }
}