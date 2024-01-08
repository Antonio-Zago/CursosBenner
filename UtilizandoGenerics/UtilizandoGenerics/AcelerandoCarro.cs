using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoGenerics
{
    public class AcelerandoCarro
    {
        public void Acelerar(ICarro carro)
        {
            carro.Velocidade += 5;
        }
    }
}
