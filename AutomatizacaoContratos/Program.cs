using AutomatizacaoContratos.Entidades;
using AutomatizacaoContratos.Interfaces;
using AutomatizacaoContratos.Services;

Console.WriteLine("Informe os dados do contrato");

Console.Write("Número: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Data: ");
DateTime date = DateTime.Parse(Console.ReadLine());

Console.Write("Valor: ");
decimal value = decimal.Parse(Console.ReadLine());

Console.Write("Número de parcelas: ");
int installments = int.Parse(Console.ReadLine());

Contract Contract = new Contract(number, date, value, installments);
PaymentService PaymentService = new PaymentService(new PayPalService());

var result = PaymentService.GenerateInstallments(Contract);

Console.Read();


