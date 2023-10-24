using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ej2_queues_farmacia
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        Turnero unTurnero = new Turnero(100, 27);
        List<Cliente> atendidos = new List<Cliente>();

        private void bAgregar_Click(object sender, EventArgs e)
        {
            int orden;
            int dni = Convert.ToInt32(tBdni.Text);
            if (rBsi.Checked)
            {
                int num = Convert.ToInt32(tBnro.Text);
                ClienteObra uno = new ClienteObra(dni, num);
                orden = unTurnero.AgregarObra(uno);
            }
            else
            {
                Cliente uno = new Cliente(dni);
                orden = unTurnero.AgregarSinObra(uno);
            }
            MessageBox.Show("Orden:" + orden);
            MostrarLista();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fcobrar ventana = new Fcobrar();
            if (listBox1.Items.Count > 0)
            {
                if (ventana.ShowDialog() == DialogResult.OK)
                {
                    ClienteObra sale = unTurnero.RetirarObra();
                    if (sale != null)
                        sale.Saldo = Convert.ToDouble(ventana.tBmonto.Text);
                    atendidos.Add(sale);
                }
                ventana.Dispose();
                MostrarLista();
            }
            else MessageBox.Show("no hay");
            
           

        }
        private void MostrarLista()
        {
            listBox1.Items.Clear();
            foreach (ClienteObra c in unTurnero.ConObra)
            {
                listBox1.Items.Add(c.Orden + "- " + c.Dni);
            }
            listBox2.Items.Clear();
            foreach (Cliente c in unTurnero.SinObra)
            {
                listBox2.Items.Add(c.Orden + "- " + c.Dni);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fcobrar ventana = new Fcobrar();
            if (listBox1.Items.Count > 0)
            {
                if (ventana.ShowDialog() == DialogResult.OK)
                {
                    Cliente sale = unTurnero.RetirarSinObra();
                    if (sale != null)
                        sale.Saldo = Convert.ToDouble(ventana.tBmonto.Text);
                    atendidos.Add(sale);
                }
                ventana.Dispose();
                MostrarLista();
            }
            else MessageBox.Show("no hay");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileStream archivo = new FileStream("datos.txt", FileMode.Create, FileAccess.Write);
            StreamWriter escribir = new StreamWriter(archivo);
            string linea;
            foreach (Cliente c in atendidos)
            {
                linea = c.Dni + ";" + c.Saldo;
                escribir.WriteLine(linea);
            }   
                escribir.Close();
                archivo.Dispose();
            }
        }
    
}
