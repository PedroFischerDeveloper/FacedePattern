namespace FacedePattern.Subsystem
{
    public class Cadin
    {
        public Cadin() { }


        public void ConsultarCliente(Cliente cliente)
        {
            Console.WriteLine($"Verificando o CADIN para o cliente {cliente.Nome}");
        }
    }
}
