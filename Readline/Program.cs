using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readline
{
    class Program
    {
        static void Main(string[] args)
        {

            String nombre;

            //Se pregunta el nombre del usuario 
            Console.WriteLine("¿Como se llama?");
            nombre = Console.ReadLine(); //Se guaeda su respuesta  en la variable 

            Console.WriteLine("Hola " + nombre + " ¿Quiere ver el menu?");
            Console.ReadKey();

        }
    }
}
