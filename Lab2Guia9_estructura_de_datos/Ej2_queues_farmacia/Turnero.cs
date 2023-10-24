using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ej2_queues_farmacia
{
    class Turnero
    {
        int numero1, numero2;
       public Queue<Cliente> SinObra = new Queue<Cliente>(); //no hacer
       public Queue<ClienteObra> ConObra = new Queue<ClienteObra>();// no hacer
        public Turnero(int a, int b)
        {
            numero1 = a;
            numero2 = b;
        }
        public int Nro1
            {
            get { return numero1; }
            }

        public int Nro2
        {
            get { return numero2; }
        }
        public int AgregarObra(ClienteObra nuevo)
        {
            nuevo.Orden = numero1;
            ConObra.Enqueue(nuevo);
            return numero1++;
        }
        public int AgregarSinObra(Cliente nuevo)
        {
            nuevo.Orden = numero2;
            SinObra.Enqueue(nuevo);
            return numero2++;
        }
        public ClienteObra RetirarObra()
        {
            if (ConObra.Count > 0)
                return ConObra.Dequeue();
            else
                return null;
        }
        public Cliente RetirarSinObra()
        {
            if (SinObra.Count > 0)
                return SinObra.Dequeue();
            else
                return null;
        }

    }
}
