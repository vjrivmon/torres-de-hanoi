using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        //Inicializar los tres palos. el palo representado como INI tendrá los n discos mientras que los palos FIN y AUX estarán vacíos.
        static void Main(string[] args)
        {
            Console.WriteLine("El Gran Juego de las Torres de Hanoi");
            Console.WriteLine("3 torres");
            Console.WriteLine("Introduce el número de discos:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Has seleccionado {n} discos");

            Pila ini = new Pila(n);
            Pila fin = new Pila(n);
            Pila aux = new Pila(n);

            for (int i = n; i > 0; i--)
            {
                ini.push(new Disco(i));
            }

            Console.WriteLine("Indica I para Iterativo o R para Recursivo:");
            string metodo = Console.ReadLine();
            Console.WriteLine($"Has seleccionado el método {metodo}");

            Hanoi h = new Hanoi();

            if (metodo.ToUpper() == "I" || metodo.ToLower() == "i")
            {
                int movimientos = h.iterativo(n, ini, fin, aux);
                Console.WriteLine($"Resuelto en {movimientos} movimientos");
            }
            else if (metodo.ToUpper() == "R" || metodo.ToLower() == "r")
            {
                int movimientos = h.recursivo(n, ini, fin, aux);
                Console.WriteLine($"Resuelto en {movimientos} movimientos");
            }
            else
            {
                Console.WriteLine("Método no reconocido. Por favor, introduce 'I' para iterativo o 'R' para recursivo.");
            }

            Console.WriteLine("Press any key to exit.");
            //Console.WriteLine("Estado final de las torres:");
            //Console.WriteLine($"Torre INI: {ini}");
            //Console.WriteLine($"Torre AUX: {aux}");
            //Console.WriteLine($"Torre FIN: {fin}");
            //Console.WriteLine(" ");

            Console.ReadKey(); // Espera a que el usuario presione una tecla antes de cerrar la consola.
        }
    }
}