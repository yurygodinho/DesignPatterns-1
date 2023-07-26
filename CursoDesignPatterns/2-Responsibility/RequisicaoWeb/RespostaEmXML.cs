using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns._2_Responsibility.RequisicaoWeb
{
    public class RespostaEmXML : Resposta
    {
        public Resposta OutraResposta { get; private set; }

        public RespostaEmXML(Resposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }

        public void Responde(Requisicao req, ContaBanco conta)
        {
            if (req.Formato == Formato.XML)
            {
                Console.WriteLine("<conta><titular>" + conta.Nome + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            else
            {
                OutraResposta.Responde(req, conta);
            }
        }
    }
}
