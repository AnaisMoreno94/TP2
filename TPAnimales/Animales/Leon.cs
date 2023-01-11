using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAnimales.Animales
{
    public class Leon:Animal
    {
        public string LargoMelena { get; set; }

        public Leon(string Edad, string Altura, string Peso, string LargoMelena) : base(Edad, Altura, Peso)
        {
            this.LargoMelena = LargoMelena;
        }
        public override string ImprimirComida()
        {
            return "El león come carne";
        }
    }
}
