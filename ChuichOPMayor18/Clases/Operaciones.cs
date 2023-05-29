using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuichOPMayor18.Clases
{
    internal class Operaciones : Persona
    {
        int n;
        double total;

        public void operaciones()
        {


            if (Edad > 18)
            {
                Console.WriteLine("Selecciona: (1)Sumar, (2)Restar, (3)Multiplicar o (4)Dividir");
                int s;
                do
                {
                    s = int.Parse(Console.ReadLine());
                    if (s != 1 && s != 2 && s != 3 && s != 4)
                    {
                        Console.WriteLine("Escribe una operacion valida");
                    }
                } while (s > 4 || s < 1);

                Console.WriteLine("Cuantos numeros quieres ingresar");
                n = int.Parse(Console.ReadLine());

                int[] b = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Ingresa tu numero " + (i + 1));
                    b[i] = int.Parse(Console.ReadLine());
                }

                switch (s)
                {

                    case 1:
                        {
                            for (int i = 0; i < n; i++)
                            {
                                total = total + b[i];
                            }
                            Console.WriteLine("La suma total de tus numeros es: " + total);
                        }
                        break;

                    case 2:
                        {
                            for (int i = 0; i < n; i++)
                            {
                                total = total - b[i];
                            }
                            Console.WriteLine("La resta total de tus numeros es: " + total);
                        }
                        break;

                    case 3:
                        {
                            total = b[0];
                            for (int i = 1; i < n; i++)
                            {
                                total = total * b[i];
                            }
                            Console.WriteLine("La multiplicacion total de tus numeros es: " + total);
                        }
                        break;

                    case 4:
                        {
                            total = b[0];
                            for (int i = 1; i < n; i++)
                            {
                                total = total / b[i];
                            }
                            Console.WriteLine("La division total de tus numeros es: " + total);
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Tu edad no es la correcta para hacer las operaciones");
            }
        }

    }
}
