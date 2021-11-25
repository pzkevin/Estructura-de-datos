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
    public partial class PilaGenerica : Form
    {
        Stack<String> pila = new Stack<string>();
        public PilaGenerica()
        {
            InitializeComponent();
        }

        private void PilaGenerica_Load(object sender, EventArgs e)
        {

        }
        private void imprimirPila()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in pila)
            {
                dataGridView1.Rows.Add(item.ToString());
            }
            label3.Text = "La pila contiene " + pila.Count + " elementos";
            if (pila.Count>0)
            {
                label4.Text = "En el tope de la pila se encuentra: "+pila.Peek();
            }
            else
            {
                label4.Text = "En el tope de la pila se encuentra: Pila vacia";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pila.Push(textBox1.Text);
            imprimirPila();
            label2.Text = textBox1.Text + " Se agrego al tope de la pila";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Text = "Pila.Push(\"" + textBox1.Text + "\")";
            button5.Text = "Pila.conteins(\"" + textBox1.Text + "\")";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pila.Count>0)
            {
                pila.Pop();
                imprimirPila();
            }
            else
            {
                label2.Text = "No se puede hacer POP, la pila está vacia";
            }
        }

        private void Pila_1_Load(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pila.Clear();
            imprimirPila();
            label2.Text = " Se eliminaron todos lo elementos de la pila";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pila.Clear();
            pila.Push("uno");
            pila.Push("dos");
            pila.Push("tres");
            pila.Push("cuatro");
            pila.Push("cinco");
            pila.Push("seis");
            pila.Push("siete");
            pila.Push("ocho");
            pila.Push("nueve");
            pila.Push("diez");
            imprimirPila();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pila.Contains(textBox1.Text))
            {
                MessageBox.Show(" Se encontro elemento en la pila ");
            }
            else
            {
                MessageBox.Show(" No se encontro elemento en la pila ");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pila = new Stack<string>(new Stack<string>(pila.Reverse()));
            imprimirPila();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
