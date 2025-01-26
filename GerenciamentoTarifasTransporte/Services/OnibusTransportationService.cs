using GerenciamentoTarifasTransporte.Interfaces;

namespace GerenciamentoTarifasTransporte.Services
{
    public class OnibusTransportationService : ITransportationService
    {
        public string CalculaTarifasDeTransporte(int numeroDeViagens)
        {
            double resultado = (4.50 + 1.00) * numeroDeViagens;
            string mensagem = $"Valor total para {numeroDeViagens} viagens: R$ {resultado}";
            return mensagem;
        }
    }
}
