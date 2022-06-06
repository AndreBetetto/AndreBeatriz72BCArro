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
                    marcha = 1;
                if(velocidade >= 20)
                {
                    marcha = 2;
                }
                if(velocidade >= 40)
                {
                    marcha=3;
                }
                else
                    throw new ApplicationException("A velocidade não pode ser negativa!");

            }
        }

    }
}

