using GerenciamentoTarifasTransporte.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoTarifasTransporte.Services
{
    public class TransportationService
    {
        private readonly ITransportationService _transportationService;

        public TransportationService(ITransportationService service) 
        {
            _transportationService = service;
        }

        public string CalculaTarifasDeTransporte(int numeroDeViagens)
        {
            return _transportationService.CalculaTarifasDeTransporte(numeroDeViagens);
        }
    }
}
