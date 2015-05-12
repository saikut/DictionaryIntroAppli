using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> aDictionary = new Dictionary<int, string>();
            aDictionary.Add(101, "EEE01");
            aDictionary.Add(102,"CSE202");

            //foreach (KeyValuePair<int, string> keyValuePair in aDictionary)
            //{

            //    Console.WriteLine(keyValuePair.Key + "  " + keyValuePair.Value);
            //}
            //aDictionary.Remove(101)
            //Console.WriteLine(aDictionary.ContainsValue("EEE01"));
            //Console.WriteLine(aDictionary.ContainsKey(101));

            Console.Write("Enter Value :");
            int value = Convert.ToInt32(Console.ReadLine());
            foreach (KeyValuePair<int, string> keyValuePair in aDictionary)
            {

                if (keyValuePair.Key == value)
                {
                    Console.WriteLine(keyValuePair.Value);
                }
            }

            Console.ReadLine();



        }
    }
}
