using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============MENU'==============");
            Console.WriteLine("1: Coca Cola 150 ml (€ 2.50)");
            Console.WriteLine("2: Insalata di pollo (€ 5.20)");
            Console.WriteLine("3: Pizza Margherita (€ 10.00)");
            Console.WriteLine("4: Pizza 4 Formaggi (€ 12.50)");
            Console.WriteLine("5: Pz patatine fritte (€ 3.50)");
            Console.WriteLine("6: Insalata di riso (€ 8.00)");
            Console.WriteLine("7: Frutta di stagione (€ 5.00)");
            Console.WriteLine("8: Pizza fritta (€ 5.00)");
            Console.WriteLine("9: Piadina vegetariana (€ 6.00)");
            Console.WriteLine("10: Panino Hamburger (€ 7.90)");
            Console.WriteLine("\n11: Stampa conto finale e conferma\n");
            Console.WriteLine("==============MENU'==============");
            Console.ReadLine();

            int scelta;

            int.TryParse(Console.ReadLine(), out scelta);

            switch (scelta)
            {

                case 1:
                    Console.WriteLine("Coca Cola 150 ml (€ 2.50");
                    break;
                case 2:
                    Console.WriteLine("Coca Cola 150 ml (€ 2.50");
                    break;
                case 3:
                    Console.WriteLine("Coca Cola 150 ml (€ 2.50");
                    break;
                case 4:
                    Console.WriteLine("Coca Cola 150 ml (€ 2.50");
                    break;
                case 5:
                    Console.WriteLine("Coca Cola 150 ml (€ 2.50");
                    break;
                case 6:
                    Console.WriteLine("Coca Cola 150 ml (€ 2.50");
                    break;
                case 7:
                    Console.WriteLine();
                    break;
                case 8:
                    Console.WriteLine();
                    break;
                case 9:
                    Console.WriteLine();
                    break;
                case 10:
                    Console.WriteLine();
                    break;
                case 11:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("COMANDO SCONOSCIUTO");


                    break;

            }
        }
    }
    }
