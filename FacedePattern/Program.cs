// See https://aka.ms/new-console-template for more information

using FacedePattern.Facace;
using FacedePattern.Subsystem;

ConsultarPendenciasFacade consultarPendenciasFacade = new ConsultarPendenciasFacade();

Cliente cliente = new Cliente("Pedro Fischer");

bool limiteAprovado = consultarPendenciasFacade.ConsultarLimiteCredito(cliente, 1.500);

Console.WriteLine($"O Emprestimo pleitiado pelo Cliente {cliente.Nome} foi:  {limiteAprovado}" );