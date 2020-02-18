using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipodmusica
{
    public partial class Form1 : Form
    {
        private int num1 = 0;
        private int num2 = 0;
        private int resultado;
        bool on = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(label1.Text);
            resultado = num1 + 1;
            label1.Text = Convert.ToString(resultado);

            int lbl_num = Convert.ToInt32(resultado);
            SoundPlayer Som1 = new SoundPlayer("C:\\Users\\prive\\source\\repos\\ipodmusica\\ipodmusica\\Resources\\Trippie_Redd.wav");
            SoundPlayer Som2 = new SoundPlayer("C:\\Users\\prive\\source\\repos\\ipodmusica\\ipodmusica\\Resources\\xxxtentacion.wav");
            SoundPlayer Som3 = new SoundPlayer("C:\\Users\\prive\\source\\repos\\ipodmusica\\ipodmusica\\Resources\\drake.wav");
            switch (lbl_num)
            {
                case 1:
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    Som1.Play();
                    break;
                case 2:
                    pictureBox4.Visible = false;
                    pictureBox5.BringToFront();
                    pictureBox5.Visible = true;
                    Som2.Play();
                    break;
                case 3:
                    pictureBox5.Visible = false;
                    pictureBox6.BringToFront();
                    pictureBox6.Visible = true;
                    Som3.Play();
                    break;
                case 4:
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    Som1.Play();
                    break;
                case 5:
                    pictureBox4.Visible = false;
                    pictureBox5.BringToFront();
                    pictureBox5.Visible = true;
                    Som2.Play();
                    break;
                case 6:
                    pictureBox5.Visible = false;
                    pictureBox6.BringToFront();
                    pictureBox6.Visible = true;
                    Som3.Play();
                    break;
                case 7:
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    Som1.Play();
                    break;
                case 8:
                    pictureBox4.Visible = false;
                    pictureBox5.BringToFront();
                    pictureBox5.Visible = true;
                    Som2.Play();
                    break;
                case 9:
                    pictureBox5.Visible = false;
                    pictureBox6.BringToFront();
                    pictureBox6.Visible = true;
                    Som3.Play();
                    break;
                case 10:
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    Som1.Play();
                    break;
                case 11:
                    pictureBox4.Visible = false;
                    pictureBox5.BringToFront();
                    pictureBox5.Visible = true;
                    Som2.Play();
                    break;
                case 12:
                    pictureBox5.Visible = false;
                    pictureBox6.BringToFront();
                    pictureBox6.Visible = true;
                    Som3.Play();
                    break;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(label1.Text);
            resultado = num1 + 1;
            label1.Text = Convert.ToString(resultado);

            int lbl_num = Convert.ToInt32(resultado);
            SoundPlayer Som1 = new SoundPlayer("C:\\Users\\prive\\source\\repos\\ipodmusica\\ipodmusica\\Resources\\Trippie_Redd.wav");
            SoundPlayer Som2 = new SoundPlayer("C:\\Users\\prive\\source\\repos\\ipodmusica\\ipodmusica\\Resources\\xxxtentacion.wav");
            SoundPlayer Som3 = new SoundPlayer("C:\\Users\\prive\\source\\repos\\ipodmusica\\ipodmusica\\Resources\\drake.wav");
            switch (lbl_num)
            {
                case 1:
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    Som1.Play();
                    break;
                case 2:
                    pictureBox4.Visible = false;
                    pictureBox5.BringToFront();
                    pictureBox5.Visible = true;
                    Som2.Play();
                    break;
                case 3:
                    pictureBox5.Visible = false;
                    pictureBox6.BringToFront();
                    pictureBox6.Visible = true;
                    Som3.Play();
                    break;
                case 4:
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    Som1.Play();
                    break;
                case 5:
                    pictureBox4.Visible = false;
                    pictureBox5.BringToFront();
                    pictureBox5.Visible = true;
                    Som2.Play();
                    break;
                case 6:
                    pictureBox5.Visible = false;
                    pictureBox6.BringToFront();
                    pictureBox6.Visible = true;
                    Som3.Play();
                    break;
                case 7:
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    Som1.Play();
                    break;
                case 8:
                    pictureBox4.Visible = false;
                    pictureBox5.BringToFront();
                    pictureBox5.Visible = true;
                    Som2.Play();
                    break;
                case 9:
                    pictureBox5.Visible = false;
                    pictureBox6.BringToFront();
                    pictureBox6.Visible = true;
                    Som3.Play();
                    break;
                case 10:
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    Som1.Play();
                    break;
                case 11:
                    pictureBox4.Visible = false;
                    pictureBox5.BringToFront();
                    pictureBox5.Visible = true;
                    Som2.Play();
                    break;
                case 12:
                    pictureBox5.Visible = false;
                    pictureBox6.BringToFront();
                    pictureBox6.Visible = true;
                    Som3.Play();
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(label1.Text);
            resultado = num1 + 1;
            label1.Text = Convert.ToString(resultado);

            int lbl_num = Convert.ToInt32(resultado);
            SoundPlayer Som1 = new SoundPlayer("C:\\Users\\prive\\source\\repos\\ipodmusica\\ipodmusica\\Resources\\Trippie Redd.wav");
            SoundPlayer Som2 = new SoundPlayer("C:\\Users\\prive\\source\\repos\\ipodmusica\\ipodmusica\\Resources\\xxxtentacion.wav");
            SoundPlayer Som3 = new SoundPlayer("C:\\Users\\prive\\source\\repos\\ipodmusica\\ipodmusica\\Resources\\drake.wav");
            switch (lbl_num)
            {
                case 1:
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    Som1.Play();
                    break;
                case 2:
                    pictureBox4.Visible = false;
                    pictureBox5.BringToFront();
                    pictureBox5.Visible = true;
                    Som2.Play();
                    break;
                case 3:
                 pictureBox5.Visible = false;
                    pictureBox6.BringToFront();
                    pictureBox6.Visible = true;
                    Som3.Play();
                    break;
                case 4:
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    Som1.Play();
                    break;
                case 5:
                    pictureBox4.Visible = false;
                    pictureBox5.BringToFront();
                    pictureBox5.Visible = true;
                    Som2.Play();
                    break;
                case 6:
                    pictureBox5.Visible = false;
                    pictureBox6.BringToFront();
                    pictureBox6.Visible = true;
                    Som3.Play();
                    break;
                case 7:
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    Som1.Play();
                    break;
                case 8:
                    pictureBox4.Visible = false;
                    pictureBox5.BringToFront();
                    pictureBox5.Visible = true;
                    Som2.Play();
                    break;
                case 9:
                    pictureBox5.Visible = false;
                    pictureBox6.BringToFront();
                    pictureBox6.Visible = true;
                    Som3.Play();
                    break;
                case 10:
                    pictureBox4.Visible = true;
                    pictureBox4.BringToFront();
                    Som1.Play();
                    break;
                case 11:
                    pictureBox4.Visible = false;
                    pictureBox5.BringToFront();
                    pictureBox5.Visible = true;
                    Som2.Play();
                    break;
                case 12:
                    pictureBox5.Visible = false;
                    pictureBox6.BringToFront();
                    pictureBox6.Visible = true;
                    Som3.Play();
                    break;
                }
            }
        }
    }


