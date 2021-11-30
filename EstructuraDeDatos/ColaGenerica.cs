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
    public partial class ColaGenerica : Form
    {
        Queue<string> colaString = new Queue<string>();
        Queue<int> colaInt = new Queue<int>();
        Queue<float> colaFloat = new Queue<float>();
        Queue<bool> colaBool = new Queue<bool>();
        Queue<char> colaChar = new Queue<char>();
        public ColaGenerica()
        {
            InitializeComponent();
        }
        private void imprimirCola()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            foreach (var item in colaString)
            {
                //dataGridView1.Rows.Add(item.ToString());
                dataGridView1.Columns.Add("","");
            }
            if (colaString.Count > 0)
            {
                dataGridView1.Rows.Add(1);
            }
            int i = 0;
            foreach (var item in colaString)
            {
                dataGridView1[i++, 0].Value = item.ToString();
            }
            label3.Text = "La cola contiene " + colaString.Count + " elementos";
            if (colaString.Count > 0)
            {
                label5.Text = "En el tope de la cola se encuentra: " + colaString.Peek();
            }
            else
            {
                label5.Text = "En el tope de la cola se encuentra: Cola vacia";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                colaString.Enqueue(textBox1.Text);
                imprimirCola();
                label4.Text = textBox1.Text + " Se agrego al tope de la cola";
            }
            else
            {
                MessageBox.Show("No hay datos");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Text = "Cola.Enqueue(\"" + textBox1.Text + "\")";
            button5.Text = "Cola.conteins(\"" + textBox1.Text + "\")";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colaString.Count > 0)
            {
                colaString.Dequeue();
                imprimirCola();
            }
            else
            {
                label4.Text = "No se puede hacer Dequeue, la cola está vacia";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colaString.Clear();
            imprimirCola();
            label4.Text = " Se eliminaron todos lo elementos de la cola";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colaString.Clear();
            colaString.Enqueue("Uno");
            colaString.Enqueue("Dos");
            colaString.Enqueue("Tres");
            colaString.Enqueue("Cuatro");
            colaString.Enqueue("Cinco");
            colaString.Enqueue("Seis");
            colaString.Enqueue("Siete");
            colaString.Enqueue("Ocho");
            colaString.Enqueue("Nueve");
            colaString.Enqueue("Diez");
            imprimirCola();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colaString.Contains(textBox1.Text))
            {
                MessageBox.Show(" Se encontro elemento en la cola ");
            }
            else
            {
                MessageBox.Show(" No se encontro elemento en la cola ");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            colaString = new Queue<string>(colaString.Reverse());
            imprimirCola();
        }
    }
}
