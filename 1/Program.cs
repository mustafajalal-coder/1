using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   Ändra bakgrundsfärg till mörkröd
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            //Ändra textfärgen till vit
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Ett testmeddelande"); 

        }
    }
}
