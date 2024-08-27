using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public interface IPagante
    {
        void Pagar();
    }

    public interface IPessoa
    {
        void Apresentar();
    }

    public class Cliente : IPessoa, IPagante
    {
        public void Apresentar()
        {
            throw new NotImplementedException();
        }

        public void Pagar()
        {
            throw new NotImplementedException();
        }
    }
}
