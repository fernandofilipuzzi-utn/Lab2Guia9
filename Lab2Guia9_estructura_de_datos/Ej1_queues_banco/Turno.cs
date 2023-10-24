using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej1_queues_banco
{
    class Turno
    {
        public enum TipoTramite { Prestamos, Tarjetas, 
             Cuentas, PlazoFijos, PagosCobros, CompraVentasDolares };
        public enum TipoAtención { Cliente, Caja, CajaDivisa };

        public int Numero { get; private set; }
        public TipoTramite Tramite {get; private set;}
        public TipoAtención Atención{get;set;}
        public string Puesto { get; set; }
        public DateTime LLegada { get; private set; }
        public TimeSpan Espera { get; set; }

        public Turno(int numero, 
                  TipoTramite tramite,
                  DateTime horaLLegada)
        {
            Numero = numero;
            Tramite = tramite;
            LLegada = horaLLegada;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}:{4}:{5}", 
                                                Numero, Tramite.ToString(),
                                                Puesto,
                                                Espera.Hours,
                                                Espera.Minutes,
                                                Espera.Seconds);
        }
    }
}
