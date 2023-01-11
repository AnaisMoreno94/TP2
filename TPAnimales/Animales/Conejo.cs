using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAnimales.Animales
{
    public class Conejo:Animal
    {
        public string Pelaje { get; set; }

        public Conejo(string Edad, string Altura, string Peso, string Pelaje) : base(Edad, Altura, Peso)
        {
            this.Pelaje= Pelaje;
        }
        public override string ImprimirComida()
        {
            return "El conejo come zanahoria";
        }
    }
}
