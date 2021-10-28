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
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int limite = int.Parse(textBox1.Text);
                if (limite > 0)
                {
                    int a = 0;
                    int b = 1;
                    int c = 0;
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add("0");
                    dataGridView1.Rows.Add("1");
                    for (; ; )
                    {
                        c = a + b;
                        a = b;
                        b = c;
                        if (c > limite)
                        {
                            break;
                        }
                        dataGridView1.Rows.Add(c.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Error, sólo se permiten numeros enteros positivos");
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, sólo se permiten numeros enteros positivos");
                textBox1.Clear();
                textBox1.Focus();
            }
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
            dataGridView1.Rows.Clear();
        }
    }
}
