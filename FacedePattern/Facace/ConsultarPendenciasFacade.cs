using FacedePattern.Subsystem;

namespace FacedePattern.Facace
{
    public class ConsultarPendenciasFacade
    {
        private readonly Cadin _cadinFacede;
        private readonly Serasa _serasaFacede;
        private readonly LimiteCredito _limiteCredito;

        public ConsultarPendenciasFacade()
        {
            _cadinFacede = new Cadin();
            _serasaFacede = new Serasa();
            _limiteCredito = new LimiteCredito();
        }

        public bool ConsultarLimiteCredito(Cliente cliente, double valor)
        {
            Console.WriteLine($"Verificando disponibilidade de crédito para {cliente.Nome}");

            _serasaFacede.ConsultarCliente(cliente);
            _cadinFacede.ConsultarCliente(cliente);
            return _limiteCredito.LiberarCredito(cliente, valor);
        }
    }
}
