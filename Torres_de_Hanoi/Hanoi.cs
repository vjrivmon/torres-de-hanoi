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

        public void mostrar(Pila a, Pila b, Pila c, int m)
        {
            Console.WriteLine($"Situación tras el movimiento {m}");
            Console.WriteLine("Torre INI: " + a);
            Console.WriteLine("Torre AUX: " + b);
            Console.WriteLine("Torre FIN: " + c);
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0;
            int totalMovimientos = (int)Math.Pow(2, n) - 1;

            mostrar(ini, aux, fin, m);

            while (m < totalMovimientos)
            {
                if (n % 2 != 0)
                {
                    mover_disco(ini, fin);
                    m++;
                    mostrar(ini, aux, fin, m);

                    if (m == totalMovimientos) break;

                    mover_disco(ini, aux);
                    m++;
                    mostrar(ini, aux, fin, m);

                    if (m == totalMovimientos) break;

                    mover_disco(aux, fin);
                    m++;
                    mostrar(ini, aux, fin, m);
                }
                else
                {
                    mover_disco(ini, aux);
                    m++;
                    mostrar(ini, aux, fin, m);

                    if (m == totalMovimientos) break;

                    mover_disco(ini, fin);
                    m++;
                    mostrar(ini, aux, fin, m);

                    if (m == totalMovimientos) break;

                    mover_disco(aux, fin);
                    m++;
                    mostrar(ini, aux, fin, m);
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
                mostrar(ini, aux, fin, m);
                return 1;
            }
            m += recursivo(n - 1, ini, aux, fin);
            mover_disco(ini, fin);
            mostrar(ini, aux, fin, m);
            m += 1;
            m += recursivo(n - 1, aux, fin, ini);
            return m;
        }
    }
}