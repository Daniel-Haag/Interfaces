using GerenciamentoTarifasTransporte.Services;

Console.WriteLine("Informe o tipo de transporte (1 - Ônibus, 2 - Trem, 3 - Metrô):");
int tipoTransporte = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o número de viagens desejado:");
int numeroViagens = int.Parse(Console.ReadLine());

if (tipoTransporte == 1)
{
    TransportationService transportationService = new TransportationService(new OnibusTransportationService());
    string resultado = transportationService.CalculaTarifasDeTransporte(numeroViagens);

    Console.WriteLine(resultado);
}

if (tipoTransporte == 2)
{
    TransportationService transportationService = new TransportationService(new TremTransportationService());
    string resultado = transportationService.CalculaTarifasDeTransporte(numeroViagens);

    Console.WriteLine(resultado);
}

if (tipoTransporte == 3)
{
    TransportationService transportationService = new TransportationService(new MetroTransportationService());
    string resultado = transportationService.CalculaTarifasDeTransporte(numeroViagens);

    Console.WriteLine(resultado);
}

Console.Read();


