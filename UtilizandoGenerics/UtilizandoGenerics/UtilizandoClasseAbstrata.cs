using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoGenerics
{
    public abstract class UtilizandoClasseAbstrata
    {
        public abstract string ObterInformacoesCarro();

        public void Executar()
        {
            var info = ObterInformacoesCarro();
            Console.WriteLine(info);
        }

        //public void ExecutarVectra()
        //{
        //    var info = Vectra.ResgatarInformacoeesVectra();
        //    Console.WriteLine(info);
        //}


        //public void ExecutarUno()
        //{
        //    var info = Uno.ResgatarInformacoeesUno();
        //    Console.WriteLine(info);
        //}



    }

    class InfoVectra : UtilizandoClasseAbstrata
    {

        public override string ObterInformacoesCarro()
        {
            return Vectra.ResgatarInformacoeesVectra();
        }
    }

    class InfoUno : UtilizandoClasseAbstrata
    {
        public override string ObterInformacoesCarro()
        {
            //Como estou utilizando um método especifico da classe, não é possivel utilizar as interfaces para evitar duplicação de código
            return Uno.ResgatarInformacoeesUno();
        }
    }




}
