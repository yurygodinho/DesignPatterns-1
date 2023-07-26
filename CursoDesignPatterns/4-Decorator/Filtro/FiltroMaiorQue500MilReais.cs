using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns._4_Decorator.Filtro
{
    public class FiltroMaiorQue500MilReais : Filtro
    {
        public FiltroMaiorQue500MilReais() : base() { }

        public FiltroMaiorQue500MilReais(Filtro outroFiltro) : base(outroFiltro) { }

        public override IList<ContaBanco> Filtra(IList contas)
        {
            IList<ContaBanco> listaFiltrada = new List<ContaBanco>();

            foreach (ContaBanco conta in contas)
            {
                if (conta.Saldo > 500000) listaFiltrada.Add(conta);
            }

            foreach (ContaBanco conta in Proximo(contas))
            {
                listaFiltrada.Add(conta);
            }

            return listaFiltrada;
        }
    }
}
