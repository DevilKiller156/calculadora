﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULADORA
{
    class Program
    {
        static void Main(string[] args)
        {
            int op,oc;
            double num1, num2, resp;
            do
            {
                Console.Clear();
                Console.WriteLine("         MENU");
                Console.WriteLine("===CALCULADORA SIMPLE===");
                Console.WriteLine("1 SUMAR");
                Console.WriteLine("2 RESTAR");
                Console.WriteLine("3 MULTIPLICAR");
                Console.WriteLine("4 DIVIDIR");
                Console.WriteLine("5 SALIR");
                Console.WriteLine("INGRESE UNA OPCION");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            Console.WriteLine("NUMERO 1: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("NUMERO 2: ");
                            num2 = double.Parse(Console.ReadLine());
                            resp = num1 + num2;
                            Console.WriteLine("EL RESULTADO ES: " + resp);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("NUMERO 1: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("NUMERO 2: ");
                            num2 = double.Parse(Console.ReadLine());
                            resp = num1 - num2;
                            Console.WriteLine("EL RESULTADO ES: " + resp);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("NUMERO 1: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("NUMERO 2: ");
                            num2 = double.Parse(Console.ReadLine());
                            resp = num1 * num2;
                            Console.WriteLine("EL RESULTADO ES: " + resp);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("NUMERO 1: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("NUMERO 2: ");
                            num2 = double.Parse(Console.ReadLine());
                            resp = num1 / num2;
                            Console.WriteLine("EL RESULTADO ES: " + resp);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                    case -1:
                        {
                            do
                            {
                            Console.Clear();
                            Console.WriteLine("         MENU");
                            Console.WriteLine("===VENTA DE DROGAS Y OTROS===");
                            Console.WriteLine("1 LSD");
                            Console.WriteLine("2 CRACK");
                            Console.WriteLine("3 COCODRILE");
                            Console.WriteLine("4 MARIA");
                            Console.WriteLine("5 SALIR");
                            Console.WriteLine("INGRESE UNA OPCION");
                            oc = int.Parse(Console.ReadLine());
                            switch (oc)
                            {
                                case 1:
                                    {
                                        Console.ReadKey();
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.ReadKey();
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.ReadKey();
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.ReadKey();
                                        break;
                                    }
                                case 5:
                                    {
                                        break;
                                    }
                            Console.ReadKey();
                            break;
                            }
                            }
                            }
                Console.WriteLine();
            }while(op!=5);
        }
    }
}
