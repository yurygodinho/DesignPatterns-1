using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns._2_Responsibility.RequisicaoWeb
{
    public class RespostaEmPorcento : Resposta
    {
        public Resposta OutraResposta { get; set; }

        public RespostaEmPorcento(Resposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }

        public RespostaEmPorcento()
        {
            this.OutraResposta = null;
        }

        public void Responde(Requisicao req, ContaBanco conta)
        {
            if (req.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Nome + "%" + conta.Saldo);
            }
            else if (OutraResposta != null)
            {
                OutraResposta.Responde(req, conta);
            }
            else
            {
                throw new Exception("Formato de resposta não encontrado");
            }
        }
    }
}
