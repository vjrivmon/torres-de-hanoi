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
            if (b.IsEmpty() || (!a.IsEmpty() && a.Elementos[a.Top].Valor < b.Elementos[b.Top].Valor))
            {
                b.push(a.pop());
            }
            else
            {
                a.push(b.pop());
            }
        }

        public void mostrar(Pila a, Pila b, Pila c)
        {
            Console.WriteLine("Pila A: " + a);
            Console.WriteLine("Pila B: " + b);
            Console.WriteLine("Pila C: " + c);
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0;
            if (n % 2 != 0)
            {
                while (fin.Size != n)
                {
                    mover_disco(ini, fin);
                    m++;
                    mostrar(ini, aux, fin);

                    if (fin.Size == n) break;

                    mover_disco(ini, aux);
                    m++;
                    mostrar(ini, aux, fin);

                    if (fin.Size == n) break;

                    mover_disco(aux, fin);
                    m++;
                    mostrar(ini, aux, fin);
                }
            }
            else
            {
                while (fin.Size != n)
                {
                    mover_disco(ini, aux);
                    m++;
                    mostrar(ini, aux, fin);

                    if (fin.Size == n) break;

                    mover_disco(ini, fin);
                    m++;
                    mostrar(ini, aux, fin);

                    if (fin.Size == n) break;

                    mover_disco(aux, fin);
                    m++;
                    mostrar(ini, aux, fin);
                }
            }
            return m;
        }

        public int recursivo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0;
            if (n == 1)
            {
                mover_disco(ini, fin);
                mostrar(ini, aux, fin);
                return 1;
            }
            m += recursivo(n - 1, ini, aux, fin);
            mover_disco(ini, fin);
            mostrar(ini, aux, fin);
            m += 1;
            m += recursivo(n - 1, aux, fin, ini);
            return m;
        }
    }
}