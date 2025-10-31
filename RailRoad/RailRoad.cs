//Problem im solving:
//https://open.kattis.com/problems/railroad2

using System;

public class RailRoad
{

    public static void Main(string[] args)
    {

        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        int y = int.Parse(inputArray[1]);

        if (y % 2 == 1)
        {
            Console.WriteLine("impossible");
        } 
        else
        {
            Console.WriteLine("possible");
        }
        
    }
    
}