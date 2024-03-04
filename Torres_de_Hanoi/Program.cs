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
            Pila ini = new Pila(3);
            Pila fin = new Pila(3);
            Pila aux = new Pila(3);

            Disco d1 = new Disco(3);
            Disco d2 = new Disco(2);
            Disco d3 = new Disco(1);

            ini.push(d1);
            ini.push(d2);
            ini.push(d3);

            Hanoi h = new Hanoi();
            h.iterativo(3, ini, fin, aux);
            Console.ReadKey();

        }
    }
}
