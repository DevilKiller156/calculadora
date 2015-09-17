using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple
{
    class Program
    {
        static void Main(string[] args)
        {
            int op, NUM1, NUM2,RES;
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1 SUMA");
                Console.WriteLine("2 RESTA");
                Console.WriteLine("3 MULTIPLICACION");
                Console.WriteLine("4 DIVICION");
                Console.WriteLine("5 POTENCIA");
                Console.WriteLine("6 FACTORIAL");
                Console.WriteLine("7 SALIR");
                Console.WriteLine("Elija La Opcion");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            break;
                        }
                    case 2:
                        {
                            
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("INGRESE UN NUMERO: ");
                            NUM1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("INGRESE EL SEGUNDO NUMERO: ");
                            NUM2 = int.Parse(Console.ReadLine());
                            RES = NUM1 * NUM2;
                            Console.WriteLine("EL RESULTADO ES: " + RES);
                            break;
                        }
                    case 4:
                        {
                            
                            break;
                        }
                    case 5:
                        {
                            
                            break;
                        }
                    case 6:
                        {
                            
                            break;
                        }
                    case 7:
                        {
                            break;
                        }
                }
            } while (op != 7);
            Console.ReadKey();
        }
    }
}
