using System;

class program{
    public static void Main(string[] args){
        int[] MyArray = {10,20,30,40,50};
        int sum = 0;
        for(int i = 0; i < MyArray.Length; i++){
            sum = sum + MyArray[i];
        } 
        Console.WriteLine("The sum is = " + sum);
    }
}