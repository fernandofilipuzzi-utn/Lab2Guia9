using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ej4_stack_puerto
{
    class Barco
    {
        Stack<Contenedor> carga = new Stack<Contenedor>();
        public void AgregarContenedor(Contenedor c)
        {
            carga.Push(c);
        }
        public int Cantidad
        { get { return carga.Count; } }
        public string[] manifiesto()
        {
            string[] lista = new string[Cantidad];
            int i = 0;
            foreach (Contenedor c in carga)
            {
                if (c is Granero)
                {
                    lista[i] ="Granero"+"  "+c.Codigo.ToString("0000")+" "+((Granero)c).Tipo;
                }
                else
                {
                    lista[i] = "General" + "  " + c.Codigo.ToString("0000") + " " + ((General)c).Capacidad;
                }
                i++;
            }
            return lista;
        }
    }
}
