using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }
        public int Top { get; set; }
        public Disco[] Elementos { get; set; }

        //Constructor
        public Pila(int size)
        {
            Size = size;
            Top = -1;
            Elementos = new Disco[size];
        }
        
        //Metodos
        public void push(Disco d)
        {
            if (Top < Size - 1)
            {
                Top++;
                Elementos[Top] = d;
            }
        }

        public Disco pop()
        {
            if (Top >= 0)
            {
                Disco temp = Elementos[Top];
                Elementos[Top] = null;
                Top--;
                return temp;
            }
            return null;
        }

        public bool IsEmpty()
        {
            if (Top == -1)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = Top; i >= 0; i--)
            {
                sb.Append(Elementos[i].Valor + " ");
            }
            return sb.ToString();
        }
    }
}