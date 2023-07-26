using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns._4_Decorator
{
    public class ImpostoMuitoAlto : Impostos
    {
        public ImpostoMuitoAlto() : base() { }

        public ImpostoMuitoAlto(Impostos imposto) : base(imposto) { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculoDoOutroImposto(orcamento);
        }
    }
}
