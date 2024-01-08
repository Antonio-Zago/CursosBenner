using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoGenerics
{
    public partial class Uno : ICarro
    {
        //public double Velocidade;
        //public void Acelerar()
        //{
        //    Velocidade += 5;
        //}
        public double Velocidade { get; set; }

        //Método especifico da classe Uno
        public static string ResgatarInformacoeesUno()
        {
            return "2015 - 5 portas";
        }

    }
}
