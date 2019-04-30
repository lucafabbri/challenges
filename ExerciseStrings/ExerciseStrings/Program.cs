using System;

namespace ExerciseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            SumIntFromString s = new SumIntFromString();
            Console.WriteLine(s.Add(""));
            Console.WriteLine(s.Add("1"));
            Console.WriteLine(s.Add("1,2"));
            Console.WriteLine(s.Add("1,2,3,4,5"));
            Console.WriteLine(s.Add("1000,2"));
            Console.WriteLine(s.Add("//[***]//1***2***3"));
            Console.WriteLine(s.Add("//[*][%]//1*2%3"));
            Console.WriteLine(s.Add("//[*.][%.]//1*.2%.3"));
        }
    }
}
