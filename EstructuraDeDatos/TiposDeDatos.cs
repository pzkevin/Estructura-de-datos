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
    public partial class TiposDeDatos : Form
    {
        private int c = 0;
        private int r = 0;
        public TiposDeDatos()
        {
            InitializeComponent();
        }
        private bool validador()
        {
            switch (Practica1_TiposDeDatosAbstractos.tipo)
            {
                case "String":
                        return true;
                case "Int":
                    try
                    {
                        int.Parse(textBox1.Text);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                case "Double":
                    try
                    {
                        double.Parse(textBox1.Text);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                case "Char":
                    try
                    {
                        char.Parse(textBox1.Text);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                case "Decimal":
                    try
                    {
                        decimal.Parse(textBox1.Text);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                case "ADT1":
                    try
                    {
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                case "ADT2":
                    try
                    {
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
            }
            return false;
        }

        private void TiposDeDatos_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Practica1_TiposDeDatosAbstractos.tipo);
            label3.Text = "El tipo de dato seleccionado es "+Practica1_TiposDeDatosAbstractos.tipo;
            dataGridView1.Rows.Add(3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (validador())
            {
                MessageBox.Show(Practica1_TiposDeDatosAbstractos.tipo);
                dataGridView1[c, r].Value = textBox1.Text;
                c++;
                if (c == 3)
                {
                    r++;
                    if (r > 2)
                    {
                        button2.Enabled = false;
                    }
                    c = 0;
                }
                if (r > 2)
                {
                    label1.Text = $"Elemento [2,2] =";
                }
                else
                {
                    label1.Text = $"Elemento [{c},{r}] =";
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Elemento [0, 0] =";
            c = 0;
            r = 0;
            button2.Enabled = true;
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(3);
            textBox1.Clear();
        }
    }
}
