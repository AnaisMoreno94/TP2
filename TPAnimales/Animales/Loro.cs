using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAnimales.Animales
{
    public class Loro:Animal
    {
        public string ColorPlumas { get; set; }

        public Loro(string Edad, string Altura, string Peso, string ColorPlumas) : base(Edad, Altura, Peso)
        {
            this.ColorPlumas = ColorPlumas;
        }
        public override string ImprimirComida()
        {
            return "El loro come semillas";
        }
    }
}
