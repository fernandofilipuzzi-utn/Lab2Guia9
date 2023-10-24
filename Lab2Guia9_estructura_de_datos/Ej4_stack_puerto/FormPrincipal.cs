using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej4_stack_puerto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Darsena puertoParana = new Darsena();
        Barco nuevoBarco = new Barco();
        private void Form1_Load(object sender, EventArgs e)
        {
            Contenedor grano = new Granero(100, "trigo");
            
            puertoParana.AgregarDarsena(grano, 1);
            grano = new General(200, 1000);
            puertoParana.AgregarDarsena(grano, 2);
            grano = new Granero(120, "Maiz");
            puertoParana.AgregarDarsena(grano, 1);
            grano = new Granero(150, "Maiz");
            puertoParana.AgregarDarsena(grano, 1);
            grano = new General(220, 10000);
            puertoParana.AgregarDarsena(grano, 2);
            grano = new General(300, 1000);
            puertoParana.AgregarDarsena(grano, 2);
            Ver();
        }
        private void Ver()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach (Granero c in puertoParana.darsena1)
            {
                listBox1.Items.Add(c.Codigo + " " + c.Tipo);
            }
            foreach (General c in puertoParana.darsena2)
            {
                listBox2.Items.Add(c.Codigo + " " + c.Capacidad);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contenedor uno = puertoParana.Cargar(1);
            nuevoBarco.AgregarContenedor(uno);

            string[] contenedores = nuevoBarco.manifiesto();
            listBox3.Items.Clear();
            for (int i=0;i<contenedores.Length;i++)
            {
                listBox3.Items.Add(contenedores[i]);
            }
            Ver();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Contenedor uno = puertoParana.Cargar(2);
            nuevoBarco.AgregarContenedor(uno);
            string[] contenedores = nuevoBarco.manifiesto();
            listBox3.Items.Clear();
            for (int i = 0; i < contenedores.Length; i++)
            {
                listBox3.Items.Add(contenedores[i]);
            }
            Ver();

        }
    }
}
