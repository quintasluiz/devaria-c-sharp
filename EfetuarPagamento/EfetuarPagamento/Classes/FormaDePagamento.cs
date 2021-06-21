using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfetuarPagamento.Classes
{
    class FormaDePagamento
    {
        public virtual void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento Efetuado");
        }
    }

    class FormaDePagamentoBoleto : FormaDePagamento
    {
        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado com boleto");
        }
    }
    class FormaDePagamentoPix : FormaDePagamento
    {
        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado com Pix");
        }
    }
    class FormaDePagamentoCartaoDeCredito : FormaDePagamento
    {
        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado com Caratao de credito");
        }
    }
    class FormaDePagamentoTransferencia : FormaDePagamento
    {
        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado com transferencia");
        }
    }
}
