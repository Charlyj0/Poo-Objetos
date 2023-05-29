using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuichOPMayor18.Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public void verificacion()
        {
            Console.WriteLine("Registra tus datos para hacer las operaciones");

            Console.WriteLine("Nombre");
            Nombre = Console.ReadLine();

            Console.WriteLine("Apellido");
            Apellido = Console.ReadLine();

            Console.WriteLine("Carrera");
            Carrera = Console.ReadLine();

            Console.WriteLine("Edad");
            Edad = int.Parse(Console.ReadLine());

            Console.Clear();

        }

        public void datos()
        {
            Console.WriteLine("Nombre de usuario: " + Nombre);
            Console.WriteLine("Apellido de usuario: " + Apellido);
            Console.WriteLine("Carrera de usuario: " + Carrera);
            Console.WriteLine("Edad de usuario: " + Edad);
        }

    }
}
