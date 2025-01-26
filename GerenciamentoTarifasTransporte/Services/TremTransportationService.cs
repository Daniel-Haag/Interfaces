using GerenciamentoTarifasTransporte.Interfaces;

namespace GerenciamentoTarifasTransporte.Services
{
    public class TremTransportationService : ITransportationService
    {
        public string CalculaTarifasDeTransporte(int numeroDeViagens)
        {
            double resultado = (6.00 + 2.50) * numeroDeViagens;
            string mensagem = $"Valor total para {numeroDeViagens} viagens: R$ {resultado}";
            return mensagem;
        }
    }
}
