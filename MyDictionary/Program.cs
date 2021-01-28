using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericDictionary<int, string> dictionary = new MyGenericDictionary<int, string>();
            dictionary.Add(555, "Abdullah");
            dictionary.Add(1500, "Onur");
            dictionary.Add(600, "Ozan");

            dictionary.Items();
            Console.ReadLine();
        }
    }
}
