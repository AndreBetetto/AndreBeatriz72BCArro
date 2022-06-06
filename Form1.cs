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

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            if(rdbdesligar.Checked == true)
            {
                MessageBox.Show("Carro desligado");
            }
            else if(rdbdesligar.Checked == false)
            {
                classeCarro.Velocidade += 5;
                lblVelocidade.Text = Convert.ToString(classeCarro.Velocidade);
                
            }
            
        }
    }
}
