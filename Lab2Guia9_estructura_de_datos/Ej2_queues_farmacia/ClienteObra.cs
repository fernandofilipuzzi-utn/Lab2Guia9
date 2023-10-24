using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2_queues_farmacia
{
    class ClienteObra:Cliente
    {
        int nro;
        public ClienteObra(int dni, int legajo):base (dni)
        {
            nro = legajo;
        }
        public int Legajo
        { get {return nro;} }
    }
}
