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
    public partial class Notacion : Form
    {
        int operando1;
        int operando2;
        Stack<int> pila = new Stack<int>();
        public Notacion()
        {
            InitializeComponent();
        }

        private void imprimirPila()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in pila)
            {
                dataGridView1.Rows.Add(item.ToString());
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode +" "+e.KeyData+" "+e.KeyValue);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar=='+')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Notacion_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "9 7 8 5 6 8 9 * / + * * +";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "+ * 8 5 6 8 * * +";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1 2 8 5 6  * * + /";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] arreglo = textBox1.Text.Split(' ');
            pila.Clear();
            try
            {
                foreach (var item in arreglo)
                {
                    if (item.All(char.IsDigit))
                    {
                        MessageBox.Show(item + " Es un número, va a la pila");
                        pila.Push(int.Parse(item));
                        imprimirPila();
                    }
                    else if (item == "-")
                    {
                        MessageBox.Show(item + " Menos");
                        operando1 = pila.Pop();
                        operando2 = pila.Pop();
                        pila.Push(operando1 - operando2);
                        imprimirPila();
                    }
                    else if (item == "+")
                    {
                        MessageBox.Show(item + " Mas");
                        operando1 = pila.Pop();
                        operando2 = pila.Pop();
                        pila.Push(operando1 + operando2);
                        imprimirPila();
                    }
                    else if (item == "*")
                    {
                        MessageBox.Show(item + " Multiplicación");
                        operando1 = pila.Pop();
                        operando2 = pila.Pop();
                        pila.Push(operando1 * operando2);
                        imprimirPila();
                    }
                    else if (item == "/")
                    {
                        MessageBox.Show(item + " División");
                        operando1 = pila.Pop();
                        operando2 = pila.Pop();
                        pila.Push(operando1 / operando2);
                        imprimirPila();
                    }
                    else if (item == " ")
                    {
                        MessageBox.Show(item + " Espacio");
                    }
                    else
                    {
                        MessageBox.Show("Error: No es un sólo símbolo ni numero");
                    }

                }
                if (pila.Count == 1)
                {
                    MessageBox.Show("El resultado" + pila.Peek() + " es correcto");
                }
                else
                {
                    MessageBox.Show("Error en la expresión");
                }
            }
            catch (Exception error)
            {

                MessageBox.Show("Expresión incorrecta, revisa de nuevo");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {//RESULTADO SIN VENTANAS
            String[] arreglo = textBox1.Text.Split(' ');
            pila.Clear();
            try
            {
                foreach (var item in arreglo)
                {
                    if (item.All(char.IsDigit))
                    {
                        pila.Push(int.Parse(item));
                        imprimirPila();
                    }
                    else if (item == "-")
                    {
                        operando1 = pila.Pop();
                        operando2 = pila.Pop();
                        pila.Push(operando1 - operando2);
                        imprimirPila();
                    }
                    else if (item == "+")
                    {
                        operando1 = pila.Pop();
                        operando2 = pila.Pop();
                        pila.Push(operando1 + operando2);
                        imprimirPila();
                    }
                    else if (item == "*")
                    {
                        operando1 = pila.Pop();
                        operando2 = pila.Pop();
                        pila.Push(operando1 * operando2);
                        imprimirPila();
                    }
                    else if (item == "/")
                    {
                        operando1 = pila.Pop();
                        operando2 = pila.Pop();
                        pila.Push(operando1 / operando2);
                        imprimirPila();
                    }
                    else
                    {
                        MessageBox.Show("Error en la expresión");
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Expresión incorrecta, revisa de nuevo");
            }
        }
    }
}
