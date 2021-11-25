using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EstructuraDeDatos
{
    public partial class Memorama : Form
    {
        //variables
        int []imagenes = {1,1, 2,2, 3,3, 4,4, 5,5, 6,6, 7,7, 8,8};
        bool esperando = false;
        int indiceTemporal = 0;
        PictureBox imagenTemporal = null;
        int intento = 1;
        int pares = 0;
        int segundos = 0;
        int minutos = 0;
        int deck = 0;
        int fondo = 0;
        private void Voltear(PictureBox imagen, int id)
        {
            imagen.Image = Image.FromFile(@"C:\Users\K\source\repos\estructura-de-datos-Memorama\EstructuraDeDatos\images\"+deck+"\\"+imagenes[id]+".png");
            imagen.Update();
            if (esperando == false)
	        {
                imagenTemporal = imagen;
                indiceTemporal = id;
                esperando = true;
	        }
            else
	        {
                if (imagenes[id]==imagenes[indiceTemporal])
	            {
                    MessageBox.Show("Encontramos un par");
                    imagen.Enabled = false;
                    imagenTemporal.Enabled = false;
                    imagen.Visible = false;
                    imagenTemporal.Visible = false;
                    pares++;
                    label2.Text = "Pares #" + pares.ToString();
                    if (pares == 8)
	            {
                    MessageBox.Show("Encontraste todos los pares en #" + intento.ToString()+" intento/s y "+minutos+" minuto/s y "+segundos+" segundo/s");
	            }
                }
                else
	            {
                    Thread.Sleep(500);
                    imagen.Image = imagen.Image = Image.FromFile(@"C:\Users\K\source\repos\estructura-de-datos-Memorama\EstructuraDeDatos\images\"+deck+@"\faceDown.png");
                           imagenTemporal.Image = Image.FromFile(@"C:\Users\K\source\repos\estructura-de-datos-Memorama\EstructuraDeDatos\images\"+deck+@"\faceDown.png");
                    MessageBox.Show("No es un par");
                    imagen.Update();
                    imagenTemporal.Update();
	            }
                esperando = false;

	        }

        }
        public Memorama()
        {
            InitializeComponent();
        }

        private void Memorama_Load(object sender, EventArgs e)
        {
            imagenes = imagenes.OrderBy(s => Guid.NewGuid()).ToArray();
            deck = new Random().Next(1,4);
            fondo = new Random().Next(1,6);
            pictureBox1.Image = Image.FromFile(@"C:\Users\K\source\repos\estructura-de-datos-Memorama\EstructuraDeDatos\images\" + deck + @"\faceDown.png");
            pictureBox2.Image = Image.FromFile(@"C:\Users\K\source\repos\estructura-de-datos-Memorama\EstructuraDeDatos\images\" + deck + @"\faceDown.png");
            pictureBox3.Image = Image.FromFile(@"C:\Users\K\source\repos\estructura-de-datos-Memorama\EstructuraDeDatos\images\" + deck + @"\faceDown.png");
            pictureBox4.Image = Image.FromFile(@"C:\Users\K\source\repos\estructura-de-datos-Memorama\EstructuraDeDatos\images\" + deck + @"\faceDown.png");
            pictureBox5.Image = Image.FromFile(@"C:\Users\K\source\repos\estructura-de-datos-Memorama\EstructuraDeDatos\images\" + deck + @"\faceDown.png");
            pictureBox6.Image = Image.FromFile(@"C:\Users\K\source\repos\estructura-de-datos-Memorama\EstructuraDeDatos\images\" + deck + @"\faceDown.png");
            pictureBox7.Image = Image.FromFile(@"C:\Users\K\source\repos\estructura-de-datos-Memorama\EstructuraDeDatos\images\" + deck + @"\faceDown.png");
            pictureBox8.Image = Image.FromFile(@"C:\Users\K\source\repos\estructura-de-datos-Memorama\EstructuraDeDatos\images\" + deck + @"\faceDown.png");
            pictureBox9.Image = Image.FromFile(@"C:\Users\K\source\repos\estructura-de-datos-Memorama\EstructuraDeDatos\images\" + deck + @"\faceDown.png");
            pictureBox10.Image = Image.FromFile(@"C:\Users\K\source\repos\estructura-de-datos-Memorama\EstructuraDeDatos\images\" + deck + @"\faceDown.png");
            pictureBox11.Image = Image.FromFile(@"C:\Users\K\source\repos\estructura-de-datos-Memorama\EstructuraDeDatos\images\" + deck + @"\faceDown.png");
            pictureBox12.Image = Image.FromFile(@"C:\Users\K\source\repos\estructura-de-datos-Memorama\EstructuraDeDatos\images\" + deck + @"\faceDown.png");
            pictureBox13.Image = Image.FromFile(@"C:\Users\K\source\repos\estructura-de-datos-Memorama\EstructuraDeDatos\images\" + deck + @"\faceDown.png");
            pictureBox14.Image = Image.FromFile(@"C:\Users\K\source\repos\estructura-de-datos-Memorama\EstructuraDeDatos\images\" + deck + @"\faceDown.png");
            pictureBox15.Image = Image.FromFile(@"C:\Users\K\source\repos\estructura-de-datos-Memorama\EstructuraDeDatos\images\" + deck + @"\faceDown.png");
            pictureBox16.Image = Image.FromFile(@"C:\Users\K\source\repos\estructura-de-datos-Memorama\EstructuraDeDatos\images\" + deck + @"\faceDown.png");
            pictureBox17.Image = Image.FromFile(@"C:\Users\K\source\repos\estructura-de-datos-Memorama\EstructuraDeDatos\images\" + fondo + ".jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox1, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox2, 1);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox4, 2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox3, 3);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox8, 4);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox7, 5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox6, 6);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox5, 7);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox12, 8);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox11, 9);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox10, 10);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox9, 11);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox16, 12);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox15, 13);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox14, 14);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Voltear(pictureBox13, 15);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Memorama_Load(sender,e);
          
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
            pictureBox11.Enabled = true;
            pictureBox12.Enabled = true;
            pictureBox13.Enabled = true;
            pictureBox14.Enabled = true;
            pictureBox15.Enabled = true;
            pictureBox16.Enabled = true;
            intento = intento + 1;
            label1.Text = "Intento número #"+intento.ToString();
            minutos = 0;
            segundos = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            if (segundos == 60)
            {
                segundos = 0;
                minutos++;
            }
            label4.Text = minutos.ToString().PadLeft(2, '0') + ":" + segundos.ToString().PadLeft(2, '0');
        }
    }
}
