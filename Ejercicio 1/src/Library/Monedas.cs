using System;

namespace Expert_SRP
{
    public class Monedas
    {
        /*
        Ahora existe una clase con la única responsabilidad de convertir entre una moneda y otra
        */
        public static Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 43;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}