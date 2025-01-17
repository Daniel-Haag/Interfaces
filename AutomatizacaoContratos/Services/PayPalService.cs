using AutomatizacaoContratos.Entidades;
using AutomatizacaoContratos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacaoContratos.Services
{
    public class PayPalService : IPayPalService
    {
        public List<Installment> GenerateInstallments(Contract contract)
        {

            List<Installment> installments = new List<Installment>();

            for (int i = 0; i < contract.NumberOfInstallments; i++)
            {
                var calculatedValue = contract.Value / contract.NumberOfInstallments;
                calculatedValue = calculatedValue * 0.01m;
                calculatedValue = calculatedValue * i;

                Installment installment = new Installment()
                {
                    DueDate = contract.Date.AddMonths(i),
                    Value = calculatedValue * 0.02m                   
                };

                installments.Add(installment);
            }


            return installments;
        }
    }
}
