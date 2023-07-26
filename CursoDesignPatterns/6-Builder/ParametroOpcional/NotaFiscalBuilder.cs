using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns._6_Builder
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string Observacoes { get; private set; }
        public DateTime Data { get; private set; }

        private double valorTotal;
        private double impostosNf;
        private IList<ItemDaNota> todosItensNf = new List<ItemDaNota>();

        public NotaFiscalBuilder()
        {
            Data = DateTime.Now;
        }

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostosNf, todosItensNf, Observacoes);
        }

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual(DateTime novaData)
        {
            this.Data = novaData;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder Com(ItemDaNota itemNf)
        {
            todosItensNf.Add(itemNf);
            valorTotal += itemNf.Valor;
            impostosNf += itemNf.Valor * 0.05;
            return this;
        }
    }
}
