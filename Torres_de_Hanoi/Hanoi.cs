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
            if (!a.IsEmpty() || (!b.IsEmpty() && a.Top >= 0 && b.Top >= 0 && a.Elementos[a.Top].Valor > b.Elementos[b.Top].Valor))
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
            Console.WriteLine("Pila B: ");
            Console.WriteLine("Pila C: ");
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0;
            if (n % 2 != 0)
            {
                while (fin.IsEmpty())
                {
                    mover_disco(ini, fin);
                    m++;
                    mostrar(ini, fin, aux);

                    if (!fin.IsEmpty()) break;

                    mover_disco(ini, aux);
                    m++;
                    mostrar(ini, fin, aux);

                    if (!fin.IsEmpty()) break;

                    mover_disco(aux, fin);
                    m++;
                    mostrar(ini, fin, aux);
                }
            }
            else
            {
                while (fin.IsEmpty())
                {
                    mover_disco(ini, aux);
                    m++;
                    mostrar(ini, fin, aux);

                    if (!fin.IsEmpty()) break;

                    mover_disco(ini, fin);
                    m++;
                    mostrar(ini, fin, aux);

                    if (!fin.IsEmpty()) break;

                    mover_disco(aux, fin);
                    m++;
                    mostrar(ini, fin, aux);
                }
            }
            return m;
        }
    }
}