using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void filasYColasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void practica1TiposDeDatosAbstractosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Location = new Point(this.Width / 2 - label1.Width / 2, menuStrip1.Height + 20);
            label2.Location = new Point(this.Width / 2 - label2.Width / 2, menuStrip1.Height + label1.Height + 40);
            label3.Location = new Point(this.Width / 2 - label3.Width / 2, menuStrip1.Height + label1.Height + label2.Height + 60);
        }

        private void aDT2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Practica1_TiposDeDatosAbstractos frm = new Practica1_TiposDeDatosAbstractos();
            frm.ShowDialog();
        }

        private void secuenciaDeFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fibonacci frm = new Fibonacci();
            frm.ShowDialog();
        }

        private void memoramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Memorama frm = new Memorama();
            frm.ShowDialog();
        }
    }
}
