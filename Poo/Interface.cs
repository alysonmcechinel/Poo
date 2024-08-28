using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    // Interface que declara um método Pagar
    public interface IPagante
    {
        void Pagar();
    }

    // Interface que declara um método Apresentar
    public interface IPessoa
    {
        void Apresentar();
    }

    // Classe Cliente que implementa as interfaces IPessoa e IPagante
    public class Cliente : IPessoa, IPagante
    {
        // Implementação do método Apresentar da interface IPessoa
        public void Apresentar()
        {
            throw new NotImplementedException();
        }

        // Implementação do método Pagar da interface IPagante
        public void Pagar()
        {
            throw new NotImplementedException();
        }
    }
}
