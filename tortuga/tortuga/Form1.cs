using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tortuga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tortuga t1 = new Tortuga();
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = t1.tablero();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = t1.mostrar();
        }

        private void cmdPArriba_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(textBox2.Text);
            t1.avanzar(valor);
        }

        private void cmdGirarDerecha_Click(object sender, EventArgs e)
        {
            t1.girarDerecha();
        }

        private void cmdGirarIzq_Click(object sender, EventArgs e)
        {
            t1.girarIzquierda();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t1.plumaAbajo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1.plumaArriba();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
