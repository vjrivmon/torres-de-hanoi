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
            Console.WriteLine("Introduce el número de discos:");
            int n = Convert.ToInt32(Console.ReadLine());

            Pila ini = new Pila(n);
            Pila fin = new Pila(n);
            Pila aux = new Pila(n);

            for (int i = n; i > 0; i--)
            {
                ini.push(new Disco(i));
            }

            Console.WriteLine("Introduce el método para resolver las Torres de Hanoi (I para iterativo, R para recursivo):");
            string metodo = Console.ReadLine();

            Hanoi h = new Hanoi();

            if (metodo.ToUpper() == "I")
            {
                int movimientos = h.iterativo(n, ini, fin, aux);
                Console.WriteLine($"Se han realizado {movimientos} movimientos para resolver las Torres de Hanoi con {n} discos usando el método iterativo.");
            }
            else if (metodo.ToUpper() == "R")
            {
                // Aquí deberías llamar a tu método recursivo, que aún no está implementado.
                // Por ejemplo:
                // int movimientos = h.recursivo(n, ini, fin, aux);
                // Console.WriteLine($"Se han realizado {movimientos} movimientos para resolver las Torres de Hanoi con {n} discos usando el método recursivo.");
            }
            else
            {
                Console.WriteLine("Método no reconocido. Por favor, introduce 'I' para iterativo o 'R' para recursivo.");
            }

            Console.WriteLine("Estado final de las torres:");
            Console.WriteLine($"Torre INI: {ini}");
            Console.WriteLine($"Torre AUX: {aux}");
            Console.WriteLine($"Torre FIN: {fin}");

            Console.ReadKey(); // Espera a que el usuario presione una tecla antes de cerrar la consola.
        }
    }
}