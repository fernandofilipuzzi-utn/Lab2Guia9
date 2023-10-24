using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ej1_queues_banco
{
    public partial class FormPrincipal : Form
    {
        Banco miBanco = new Banco();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnTurno_Click(object sender, EventArgs e)
        {
            //selección de tipo de tramite
            int nroTramite=cbTipoTramite.SelectedIndex;

            if (nroTramite != -1)
            {
                DateTime horaLLegada = DateTime.Now;// dtpHoraLLegada.Value;

                Turno turno = miBanco.SolicitarTurno(
                     (Turno.TipoTramite)nroTramite, horaLLegada);          
                if (turno != null)
                {
                    MessageBox.Show(String.Format("{0:00} - {1}",
                                            turno.Numero.ToString(),
                                            turno.Tramite.ToString()
                    ));
                }
                //no se espera nulo por ahora!

                //actualizar la bandejas
                lbBandejaClientes.Items.Clear();
                lbBandejaClientes.Items.AddRange(
                                          miBanco.Clientes.ToArray<Turno>()
                )
                ;
                lbBandejaCajas.Items.Clear();

                lbBandejaCajas.Items.AddRange(miBanco.Cajas.ToArray<Turno>());
                lbBandejaCajasDivisa.Items.Clear();

                lbBandejaCajasDivisa.Items.AddRange(
                                miBanco.CajasDivisa.ToArray<Turno>());
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de tramite.", "Error!");
            }

            //limpiando controles
            cbTipoTramite.SelectedIndex=-1;
        }

        private void btnAtencionPuestoCliente_Click(object sender, EventArgs e)
        {
            if (cbAtencionPuestosCliente.SelectedIndex != -1)
            {
                //la caja libre llama a un turno
                string puesto = (string)cbAtencionPuestosCliente.SelectedItem;
                Turno turno = miBanco.AtenderTurno(Turno.TipoAtención.Cliente,
                                                       puesto);

                if (turno != null)
                {
                    lbTurnosEnAtención.Items.Insert(0, turno);
                    lbBandejaClientes.Items.Remove(turno);
                }
                else
                {
                    MessageBox.Show("No hay en lista de espera.", "Error!");
                }

                //limpiando controles
                cbAtencionPuestosCliente.SelectedIndex = -1;
            }
            else 
            {
                MessageBox.Show("¿A Qué puesto pertenece?", "Error!");
            }
        }

        private void btnAtencionCaja_Click(object sender, EventArgs e)
        {
            if (cbAtencionPuestosCaja.SelectedIndex != -1)
            {
                string puesto = (string)cbAtencionPuestosCaja.SelectedItem;
                Turno turno = miBanco.AtenderTurno(Turno.TipoAtención.Caja, puesto);

                if (turno != null)
                {
                    lbTurnosEnAtención.Items.Insert(0, turno);
                    lbBandejaCajas.Items.Remove(turno);
                }
                else
                    MessageBox.Show("No hay en lista de espera.", "Error!");

                //limpiando controles
                cbAtencionPuestosCaja.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("¿A Qué puesto pertenece?", "Error!");
            }
        }

        private void btnAtencionPuestoCajaDivisas_Click(object sender, EventArgs e)
        {
            if (cbAtencionPuestosCajaDivisas.SelectedIndex != -1)
            {
                string puesto = (string)cbAtencionPuestosCajaDivisas.SelectedItem;
                Turno turno = miBanco.AtenderTurno(Turno.TipoAtención.CajaDivisa, puesto);

                if (turno != null)
                {
                    lbTurnosEnAtención.Items.Insert(0, turno);
                    lbBandejaCajasDivisa.Items.Remove(turno);
                }
                else
                {
                    MessageBox.Show("No hay en lista de espera!", "Error!");
                }

                //limpiando controles
                cbAtencionPuestosCajaDivisas.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("¿A Qué puesto pertenece?", "Error!");
            }
        }

    }
}
