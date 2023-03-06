using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quanityRepeat;
            string userMessage;

            Console.Write($"Введите текст - ");
            userMessage = (Console.ReadLine());

            Console.Write($"Введите количество повторов - ");
            quanityRepeat = Convert.ToInt32(Console.ReadLine());

            while (quanityRepeat-- > 0 ) 
            {
                Console.WriteLine( userMessage );     
            } 
        }
    }
}
