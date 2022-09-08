using System;

namespace  Store
{
    public class Program
    {
        public static string InputStoreName()
            {
                Console.Write("Please input Name: ");

                return Console.ReadLine();
            }
        public static string InputNumber()
            {
                Console.Write("Please input Number: ");

                return Console.ReadLine();
            }
        public static string InputName()
            {
                Console.Write("Please input Owner Name: ");

                return Console.ReadLine();
            }
        public static string InputValue()
            {
                Console.Write("Please input Registered Value: ");

                return Console.ReadLine();
            }
    
        


     static void PrintInputInformation(string namestore,string number,string name,string value)
        {
            Console.WriteLine();
            Console.WriteLine("--------------------Shop Information---------------------");
            Console.WriteLine("Please input Name: {0}", namestore);
            Console.WriteLine("Please input Number:{0}", number);
            Console.WriteLine("Please input Owner Name:{0}", name);
            Console.WriteLine("Please input Registered Value:{0}", value);
            Console.WriteLine("******************************************************");

        }
    public static void Main (string[] args)
        {
            string namestore = InputStoreName();
            string number = InputNumber();
            string name = InputName();
            string value = InputValue();

            PrintInputInformation(namestore, number, name,value);
        }
    }
}