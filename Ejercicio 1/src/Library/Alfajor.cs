using System;

namespace Expert_SRP
{
    public class Alfajor 
    {
        /*
        La clase Alfajor si cumple con los principios SRP y los patrones Expert, ya que esta correctamente encapsulada
        y su única responsabilidad es la de crear objetos de tipo Alfajor.
        */

        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
    }
}