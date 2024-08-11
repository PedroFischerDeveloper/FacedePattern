namespace FacedePattern.Subsystem;

public class LimiteCredito
{

    public LimiteCredito() { }

    public bool LiberarCredito(Cliente cliente, double valor)
    {
        if (valor > 2000)
            return false;
        else
            return true;
    }
}
