using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4_stack_puerto
{
    abstract class Contenedor
    {
        protected int numero;
        public Contenedor(int codigo)
        {
            numero = codigo;
        }
        public int Codigo
        { get { return numero; } }
    }
}
