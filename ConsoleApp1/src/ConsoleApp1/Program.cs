using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Solution("I"));
            Console.WriteLine(Solution("XXI"));
            Console.ReadKey();
        }

        public static int Solution(string roman)
        {
            var contador = 0;

            foreach (var item in roman)
            {
                switch(item)
                {
                    case 'I':
                        contador += 1;
                        break;
                    case 'V':
                        contador += 5;
                        break;
                    case 'X':
                        contador += 10;
                        break;
                    case 'C':
                        contador += 100;
                        break;
                    case 'M':
                        contador += 1000;
                        break;
                }
            }

            return contador;
        }
    }
}
