using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreBeatriz72BCArro
{
    internal class carro
    {
        //Atributos internos da classe
        private int velocidade;
        private int marcha;
        private int freio;

        //Propriedades da classe
        public int Velocidade
        {
            get
            {
                return velocidade;
            }
            set
            {
                if (velocidade >= 0)
                    velocidade = value;
            
                else
                    throw new ApplicationException("A velocidade não pode ser negativa!");

                if (velocidade >= 0 && velocidade < 20)
                {
                    marcha = 1;
                }
                else
                if (velocidade >= 20 && velocidade < 40)
                {
                    marcha = 2;
                }
                else
                if (velocidade >= 40 && velocidade < 60)
                {
                    marcha = 3;
                }
                else
                if (velocidade >= 60 && velocidade < 80)
                {
                    marcha = 4;
                }
                else
                if (velocidade >= 80)
                {
                    marcha = 5;
                }
                
            }
        }
        public int Marcha
        { 
            get { return marcha; }
            set
            { 
            }
        }
        

    }
}

