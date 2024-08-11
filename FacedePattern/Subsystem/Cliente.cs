using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacedePattern.Subsystem
{
    public class Cliente
    {
        public string Nome;

        public Cliente(string nome) { Nome = nome; }

        public string GetCliente()
        {
            return this.Nome;    
        }
    }
}
