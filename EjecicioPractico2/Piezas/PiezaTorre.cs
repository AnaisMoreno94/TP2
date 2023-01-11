using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjecicioPractico2.Piezas
{
    public class PiezaTorre:PiezaAjedrez
    {
        public override string Mover()
        {
            return "Movimiento en linea recta de cualquier cantidad de espacios";
        }
    }
}
