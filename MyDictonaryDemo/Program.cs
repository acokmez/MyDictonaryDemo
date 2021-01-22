using System;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int, string> names = new MyDictonary<int, string>();
            names.Add(123, "Engin");
            names.Add(276, "Kerem");
            names.Add(345, "Ahmet");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("ID: " + names.Keys[i]);
                Console.WriteLine("Name: " + names.Values[i]);
                Console.WriteLine("-----------------------");
            }
        }
    }
}
