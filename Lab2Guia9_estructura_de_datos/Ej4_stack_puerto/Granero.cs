using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4_stack_puerto
{
    class Granero:Contenedor
    {
        string tipo;
        public Granero(int codigo, string grano) : base(codigo)
        {
            tipo = grano;
        }
        public string Tipo
        { get { return tipo; } }
    }
}

