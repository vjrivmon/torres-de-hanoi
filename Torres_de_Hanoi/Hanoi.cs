using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        public void mover_disco(Pila a, Pila b)
        {
            if (a.IsEmpty() || (!b.IsEmpty() && a.pop() > b.pop()))
            {
                a.push(b.pop());
            }
            else
            {
                b.push(a.pop());
            }
        }

        public void mostrar(Pila a, Pila b, Pila c)
        {
            Console.WriteLine("Pila A: ");
            a.mostrar();
            Console.WriteLine("Pila B: ");
            b.mostrar();
            Console.WriteLine("Pila C: ");
            c.mostrar();
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0;
            if (n % 2 != 0)
            {
                while (!fin.esCompleta())
                {
                    mover_disco(ini, fin);
                    m++;
                    mostrar(ini, fin, aux);

                    if (fin.esCompleta()) break;

                    mover_disco(ini, aux);
                    m++;
                    mostrar(ini, fin, aux);

                    if (fin.esCompleta()) break;

                    mover_disco(aux, fin);
                    m++;
                    mostrar(ini, fin, aux);
                }
            }
            else
            {
                while (!fin.esCompleta())
                {
                    mover_disco(ini, aux);
                    m++;
                    mostrar(ini, fin, aux);

                    if (fin.esCompleta()) break;

                    mover_disco(ini, fin);
                    m++;
                    mostrar(ini, fin, aux);

                    if (fin.esCompleta()) break;

                    mover_disco(aux, fin);
                    m++;
                    mostrar(ini, fin, aux);
                }
            }
            return m;
        }
    }
}