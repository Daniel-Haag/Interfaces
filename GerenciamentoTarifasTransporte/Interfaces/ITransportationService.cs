using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoTarifasTransporte.Interfaces
{
    public interface ITransportationService
    {
        string CalculaTarifasDeTransporte(int numeroDeViagens);
    }
}
