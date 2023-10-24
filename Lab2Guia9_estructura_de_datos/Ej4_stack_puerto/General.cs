using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4_stack_puerto
{
    class General: Contenedor
    {
        int capacidad;
        public General(int codigo,int cantidad):base (codigo)
        {
            capacidad= cantidad;
        }
        public int Capacidad
        { get { return capacidad; } }
    }
}
