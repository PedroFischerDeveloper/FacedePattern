namespace FacedePattern.Subsystem
{
    public class Serasa
    {
        public Serasa() { }


        public void ConsultarCliente(Cliente cliente)
        {
            Console.WriteLine($"Verificando o SERASA para o cliente {cliente.Nome}");
        }
    }

   
}
