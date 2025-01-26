using GerenciamentoTarifasTransporte.Interfaces;

namespace GerenciamentoTarifasTransporte.Services
{
    public class MetroTransportationService : ITransportationService
    {
        public string CalculaTarifasDeTransporte(int numeroDeViagens)
        {
            double resultado = (5.50 + 1.75) * numeroDeViagens;
            string mensagem = $"Valor total para {numeroDeViagens} viagens: R$ {resultado}";
            return mensagem;
        }
    }
}
