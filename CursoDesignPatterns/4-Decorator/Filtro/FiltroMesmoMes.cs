using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns._4_Decorator.Filtro
{
    public class FiltroMesmoMes : Filtro
    {
        public FiltroMesmoMes() : base() { }

        public FiltroMesmoMes(Filtro outroFiltro) : base(outroFiltro) { }

        public override IList<ContaBanco> Filtra(IList contas)
        {
            IList<ContaBanco> listaFiltrada = new List<ContaBanco>();

            foreach (ContaBanco conta in contas)
            {
                if (conta.DataAbertura.Month == DateTime.Now.Month && conta.DataAbertura.Year == DateTime.Now.Year)
                {
                    listaFiltrada.Add(conta);
                }
            }

            foreach (ContaBanco conta in Proximo(contas))
            {
                listaFiltrada.Add(conta);
            }

            return listaFiltrada;
        }
    }
}
