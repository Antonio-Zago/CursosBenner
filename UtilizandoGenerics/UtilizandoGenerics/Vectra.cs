using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoGenerics
{
    //Entidade especializada de Vectra
    public partial class Vectra : ICarro
    {
        /*
        public double Velocidade;
        public void Acelerar()
        {
            Velocidade += 5;
        }*/

        //Método especifico da classe Vectra
        public static string ResgatarInformacoeesVectra()
        {
            return "2010 - 4 portas";
        }
        public double Velocidade { get; set; }

    }
}
