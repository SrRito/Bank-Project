using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_project
{
    class Clientes
    {
        int movimientos = 0;

        public int getMovimientos()
        {
            Random ran = new Random();
            movimientos = ran.Next(1, 6);
            return movimientos;
        }
    }
}
