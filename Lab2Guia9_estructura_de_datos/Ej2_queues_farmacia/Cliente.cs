using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2_queues_farmacia
{
    class Cliente
    {
        int dni,nroOrden;
        double saldo;
        public Cliente(int dni)
        {
            this.dni = dni;
        }
        public double Saldo
        {
            set { saldo = value; }
            get { return saldo; }
        }

        public int Dni
        {
            get { return dni; }
        }
        public int Orden
        {
            set{ nroOrden = value; }
            get { return nroOrden; }
        }
    }
}
