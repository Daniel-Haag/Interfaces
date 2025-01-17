using AutomatizacaoContratos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacaoContratos.Interfaces
{
    public interface IPayPalService
    {
        List<Installment> GenerateInstallments(Contract contract);
    }
}
