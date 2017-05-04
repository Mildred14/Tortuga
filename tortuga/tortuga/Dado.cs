using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tortuga
{
    
    class Dado
    {
        Random dado = new Random();
        public int Dados()
        {
            return dado.Next(1, 7);
        }
    }
}
