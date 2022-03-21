using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class Variablen : MonoBehaviour
{
   
}



    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Johann";
            string lastName = "Müller";

            Console.WriteLine("Name: " + firstName + " " + lastName);

            Console.WriteLine("Please enter a new first name:");
            firstName = Console.ReadLine();

            Console.WriteLine("New name: " + firstName + " " + lastName);

            Console.ReadLine();
        }
    }



namespace VariableScope
{
    class Program
    {
        private static string helloClass = "Hello, class!";

        static void Main(string[] args)
        {
            string helloLocal = "Hello, local!";
            Console.WriteLine(helloLocal);
            Console.WriteLine(Program.helloClass);
            DoStuff();
        }

        static void DoStuff()
        {
            Console.WriteLine("A message from DoStuff: " + Program.helloClass);
        }
    }
}
