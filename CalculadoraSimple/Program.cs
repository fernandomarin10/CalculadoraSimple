using System;

namespace CalculadoraSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora básica!\n");
            bool caseSwitchControl = false;
            while (!caseSwitchControl)
            {
                Console.WriteLine("¿Qué quieres hacer?\nSUMA (pulsa 1)\nRESTA (pulsa 2)\nMULTIPLICA (pulsa 3)\nDIVISIÓN (pulsa 4)\nEXIT (pulsa 0)");
                int caseSwitch = pedirNumero();
                if (caseSwitch == 0) break;

                Console.WriteLine("Ingresa el primer número: ");
                int numero1 = pedirNumero();
                Console.WriteLine("Ingresa el segundo número: ");
                int numero2 = pedirNumero();
                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("Tu resultado es {0}\n", numero1 + numero2);
                        break;
                    case 2:
                        Console.WriteLine("Tu resultado es {0}\n", numero1 - numero2);
                        break;
                    case 3:
                        Console.WriteLine("Tu resultado es {0}\n", numero1 * numero2);
                        break;
                    case 4:
                        Console.WriteLine("Tu resultado es {0}\n", numero1 / numero2);
                        break;
                    default:
                        Console.WriteLine("Opcion no valida", caseSwitch);
                        break;
                }
            }

        }
        static int pedirNumero()
        {
            string operacion;
            int operacionToInt = 0;
            bool control = false;
            while (!control)
            {
                operacion = Console.ReadLine();
                try
                {
                    operacionToInt = Int32.Parse(operacion);
                    control = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Numero no parseable, intentalo de nuevo:");
                }
            }
            return operacionToInt;
        }
    }
}

