using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ej4_stack_puerto
{
    class Darsena
    {
       public Stack<Contenedor> darsena1 = new Stack<Contenedor>(); //solo para ver estados
       public Stack<Contenedor> darsena2 = new Stack<Contenedor>();

        public void AgregarDarsena(Contenedor elemento, int numero)
        {
            switch (numero)
            {
                case 1:
                    {
                        darsena1.Push(elemento);
                    }
                    break;
                case 2:
                    {
                        darsena2.Push(elemento);
                    }
                    break;
            }
        }
        public Contenedor Consultar (int numero)
            {
            Contenedor ver = null;
                switch (numero)
                {
                    case 1:
                        {
                        ver = darsena1.Peek();
                        }
                        break;
                    case 2:
                        {
                        ver = darsena1.Peek();
                        }
                        break;
                }
            return ver;
            }
        public Contenedor Cargar(int numero)
        {
            Contenedor ver = null;
            switch (numero)
            {
                case 1:
                    {
                        ver = darsena1.Pop();
                    }
                    break;
                case 2:
                    {
                        ver = darsena2.Pop();
                    }
                    break;
            }
            return ver;
        }
    }
}
