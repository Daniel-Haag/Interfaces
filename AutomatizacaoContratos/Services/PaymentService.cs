using AutomatizacaoContratos.Entidades;
using AutomatizacaoContratos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacaoContratos.Services
{
    public class PaymentService
    {
        private IPayPalService _payPalService;

        public PaymentService(IPayPalService payPalService) 
        {
            _payPalService = payPalService;
        }

        public List<Installment> GenerateInstallments(Contract contract)
        {
           return _payPalService.GenerateInstallments(contract);
        }
    }
}
