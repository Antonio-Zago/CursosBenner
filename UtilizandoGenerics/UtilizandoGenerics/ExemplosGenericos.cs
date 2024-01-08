using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoGenerics
{
    //Classe genérica
    class ExemplosGenericos<T>
    {
    }

    //Interface genérica
    interface IExemploGenericos<T> { }

    class ClasseComum
    {
        //Classe comum com método genérico
        public void Executar<T>(T variavel) { }
    }

    class ClasseDelegate
    {
        public delegate void Generico<T>(T valor);

        public void Executar()
        {
            Generico<int> generico = (a) => { Console.WriteLine(a +2); };

            generico(2);
        }

    }

    //quando são tipos de valor
    class ClasseRestricao<T> where T : struct
    {
        public ClasseRestricao()
        {
            new ClasseRestricao<int>();
            new ClasseRestricao<long>();
            new ClasseRestricao<bool>();
            new ClasseRestricao<double>();
            new ClasseRestricao<DateTime>();
            new ClasseRestricao<decimal>();
        }
    }

    class ClasseRestricao2<T> where T : class
    {
        public ClasseRestricao2()
        {
            new ClasseRestricao2<string>();
            new ClasseRestricao2<ClasseDelegate>();
            new ClasseRestricao2<IExemploGenericos<int>>();
            new ClasseRestricao2<int[]>();
            new ClasseRestricao2<int[][]>();
        }
    }

    //Classes que possurm construtor sem parametro
    class ClasseRestricao3<T> where T: new()
    {
        public ClasseRestricao3()
        {
            new ClasseRestricao3<ClasseComContrutorSemParametro>();
            
            //new ClasseRestricao3<ClasseSemconstrutorSemParametro>();
        }
    }

    class ClasseComContrutorSemParametro
    {

    }

    class ClasseSemconstrutorSemParametro
    {
        public ClasseSemconstrutorSemParametro(int a)
        {

        }
    }

    class ClasseDerivada<T> where T : ClasseComContrutorSemParametro
    {
        public ClasseDerivada()
        {
            //Classe que é igual ao passado na restrição ou que deriva da mesma
            new ClasseDerivada<ClasseComContrutorSemParametro>();

            //Não funciona
            //new ClasseDerivada<ClasseSemconstrutorSemParametro>();
        }
    }

    class ResqtricaoInterface<T> where T : IExemploGenericos<T>
    {
        
    }

    //Passagem de dois tipos para a classe e um parametro depende do outro
    //ou seja, T extend ou implementa U
    class DependenciaParametros<T, U> where T: U
    {
        public DependenciaParametros()
        {
            new DependenciaParametros<Base, IBase>();
            new DependenciaParametros<Base2, Base>();
        }
    }

    class Base : IBase
    {

    }

    class Base2 : Base
    {

    }

    interface IBase
    {

    }
}
