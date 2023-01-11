using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAnimales.Animales
{
    public abstract class Animal
    {
        public Animal(string Edad, string Altura, string Peso) 
        {
            this.Edad = Edad;
            this.Altura = Altura;
            this.Peso = Peso;
        }

        public string Edad { get; }
        public string Altura { get; }
        public string Peso { get; }

        public virtual string Imprimir() 
        {
            return $"Edad: {Edad}, Altura: {Altura}, Peso: {Peso}";
        }
        public abstract string ImprimirComida();
    }
}
