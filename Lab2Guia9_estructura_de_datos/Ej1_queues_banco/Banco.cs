using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej1_queues_banco
{
    class Banco
    {
        int GenNumero = 0;
        
        public Queue<Turno> Clientes { get; private set; }
        public Queue<Turno> Cajas { get; private set; }
        public Queue<Turno> CajasDivisa { get; private set; }

        public Banco()
        {
            Clientes = new Queue<Turno>();
            Cajas = new Queue<Turno>();
            CajasDivisa = new Queue<Turno>();
        }

        public Turno SolicitarTurno(Turno.TipoTramite tramite, 
                                     DateTime horaLLegada)
        {
            Turno turno = new Turno(GenNumero++,
                                    tramite, 
                                    horaLLegada);

            switch(tramite)
            {
                case Turno.TipoTramite.Prestamos:
                case Turno.TipoTramite.Tarjetas:
                case Turno.TipoTramite.Cuentas:
                case Turno.TipoTramite.PlazoFijos:
                    Clientes.Enqueue(turno);
                    turno.Atención = Turno.TipoAtención.Cliente;
                    break;
                case Turno.TipoTramite.PagosCobros:
                    Cajas.Enqueue(turno);
                    turno.Atención = Turno.TipoAtención.Caja;
                    break;
                case Turno.TipoTramite.CompraVentasDolares:
                    CajasDivisa.Enqueue(turno);
                    turno.Atención = Turno.TipoAtención.CajaDivisa;
                    break;
            }
            return turno;
        }

        public Turno AtenderTurno(Turno.TipoAtención atención, string puesto)
        {
            Turno turno = null;
            Queue<Turno> selected = null;

            switch (atención)
            {
                case Turno.TipoAtención.Cliente:
                    selected = Clientes;
                    break;
                case Turno.TipoAtención.Caja:
                    selected = Cajas;
                    break;
                case Turno.TipoAtención.CajaDivisa:
                    selected= CajasDivisa;
                    break;
            }

            if (selected != null && selected.Count > 0)
            {
                turno = selected.Dequeue();
                turno.Puesto = puesto;
                turno.Espera = DateTime.Now - turno.LLegada;
            }

            return turno;
        }
    }
}
