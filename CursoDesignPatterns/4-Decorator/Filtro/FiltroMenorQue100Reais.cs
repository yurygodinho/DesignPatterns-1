using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns._4_Decorator.Filtro
{
    public class FiltroMenorQue100Reais : Filtro
    {
        public FiltroMenorQue100Reais() : base() { }

        public FiltroMenorQue100Reais(Filtro outroFiltro) : base(outroFiltro) { }

        public override IList<ContaBanco> Filtra(IList contas)
        {
            IList<ContaBanco> listaFiltrada = new List<ContaBanco>();

            foreach (ContaBanco conta in contas)
            {
                if (conta.Saldo < 100) listaFiltrada.Add(conta);
            }

            foreach (ContaBanco conta in Proximo(contas))
            {
                listaFiltrada.Add(conta);
            }

            return listaFiltrada;
        }
    }
}
