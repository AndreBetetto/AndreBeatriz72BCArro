using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndreBeatriz72BCArro
{
    public partial class Form1 : Form
    {
        private carro classeCarro = new carro();
        int cont=0;
        double consumo = 0;
        double litros = 300;
        double kmMin = 0.53;
        double kmRodados = 0;
        public Form1()
        {
            
            InitializeComponent();
            btnAcelerar.KeyDown += new KeyEventHandler(delegate (object o, KeyEventArgs a)
            {
                if (rdbdesligar.Checked == true)
                {
                    MessageBox.Show("Carro desligado");
                }
                else if (rdbdesligar.Checked == false)
                {
                    if(classeCarro.Velocidade >= 120)
                    {
                        lblVelMax.Visible = true;
                        lblVelocidade.Text = Convert.ToString(classeCarro.Velocidade);
                    }
                    else
                    {
                        lblVelMax.Visible = false;
                        classeCarro.Velocidade += 1;
                        lblVelocidade.Text = Convert.ToString(classeCarro.Velocidade);
                    }
                        
                    
                }

                lblMarcha.Text = Convert.ToString(classeCarro.Marcha);
            });
            btnFrear.KeyDown += new KeyEventHandler(delegate (object o, KeyEventArgs a)
            {
                lblVelMax.Visible = false;
                if (rdbdesligar.Checked == true)
                {
                    MessageBox.Show("Carro desligado");
                }
                else if (rdbdesligar.Checked == false)
                {
                    if (classeCarro.Velocidade <= 0)
                    {
                        rdbdesligar.Enabled = true;
                        MessageBox.Show("Carro parado!");
                    }
                    else
                        classeCarro.Velocidade += -1;
                    lblVelocidade.Text = Convert.ToString(classeCarro.Velocidade);
                    lblMarcha.Text = Convert.ToString(classeCarro.Marcha);
                }
            });

        }

        private void IniciarTimer()
        {
            timer1.Interval = 1500;
            timer1.Tick += new EventHandler(tick);
            timer1.Enabled = true;
        }
        private void tick(object sender, EventArgs e)
        {
            cont++;
            if(litros <= 0)
            {
                timer1.Stop();
                timer1.Enabled = false;
                MessageBox.Show("Sua gasolina acabou. Fechando o programa.");
                this.Close();
            }
            string time = "";
            time += cont;
            lblTempo.Text = time;
            kmRodados = kmRodados + classeCarro.Velocidade * kmMin;
            lblKmRodados.Text = kmRodados.ToString();
            if(classeCarro.Velocidade == 0)
            {
                consumo = 0;
            }
            if(classeCarro.Velocidade < 10 && classeCarro.Velocidade > 1)
            {
                consumo = -0.5;
            }
            if(classeCarro.Velocidade >= 10 && classeCarro.Velocidade < 15)
            {
                consumo = -1;
            }
            else
                if(classeCarro.Velocidade >= 15 && classeCarro.Velocidade < 20)
            {
                consumo = -1.5;
            }
            else
                if (classeCarro.Velocidade >= 20 && classeCarro.Velocidade < 25)
            {
                consumo = -2;
            }
            else
                if (classeCarro.Velocidade >= 25 && classeCarro.Velocidade < 30)
            {
                consumo = -2.5;
            }
            else
                if (classeCarro.Velocidade >= 30 && classeCarro.Velocidade < 40)
            {
                consumo = -3;
            }
            else
                if (classeCarro.Velocidade >= 40 && classeCarro.Velocidade < 50)
            {
                consumo = -3.5;
            }
            else
                if (classeCarro.Velocidade >= 50 && classeCarro.Velocidade < 70)
            {
                consumo = -4.5;
            }
            else
                if (classeCarro.Velocidade >= 70 && classeCarro.Velocidade < 90)
            {
                consumo = -6;
            }
            else
                if (classeCarro.Velocidade >= 90)
            {
                consumo = -6.5;
            }

            litros = litros + consumo;
            lblGas.Text = litros.ToString() + " L";
            lblConsumo.Text = consumo.ToString() + " L/min";

            if (classeCarro.Velocidade < 0)
            {
                cont = 0;
                timer1.Stop();
                timer1.Enabled=false;
            }
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {

            if (rdbdesligar.Checked == true)
            {
                MessageBox.Show("Carro desligado");
            }
            else if (rdbdesligar.Checked == false)
            {
                if (classeCarro.Velocidade >= 120)
                {
                    lblVelMax.Visible= true;
                    lblVelocidade.Text = Convert.ToString(classeCarro.Velocidade);
                }
                else
                {
                    lblVelMax.Visible = false;
                    classeCarro.Velocidade += 1;
                    lblVelocidade.Text = Convert.ToString(classeCarro.Velocidade);
                }
                    
                
                
                lblMarcha.Text = Convert.ToString(classeCarro.Marcha);
                
            }

        }

        private void btnFrear_Click(object sender, EventArgs e)
        {
            lblVelMax.Visible = false;
            if (rdbdesligar.Checked == true)
            {
                MessageBox.Show("Carro desligado");
            }
            else if (rdbdesligar.Checked == false)
            {
                if(classeCarro.Velocidade <= 0)
                {
                    rdbdesligar.Enabled = true;
                    MessageBox.Show("Carro parado!");
                    
                }
                else
                classeCarro.Velocidade += -1;
                lblVelocidade.Text = Convert.ToString(classeCarro.Velocidade);
                lblMarcha.Text = Convert.ToString(classeCarro.Marcha);
            }
            

        }

        private void rdbligar_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbdesligar.Checked == true)
            {
                MessageBox.Show("Desligando carro. Fechando o programa.");
                this.Close();
            }
            else
            {
                rdbdesligar.Enabled = false;
                IniciarTimer();
                    timer1.Start();
            }
            
        }
            
        
    }
}
