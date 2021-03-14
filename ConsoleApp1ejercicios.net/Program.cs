using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1ejercicios.net
{
	class Program
	{
		static void Main(string[] args)
		{
            int number = 0;

            Console.WriteLine("Introduce un número:");
            number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(number + "x" + i + "=" + (i * number));
            }


            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
	
}

