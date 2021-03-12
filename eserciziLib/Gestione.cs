using System;

namespace eserciziLib
{
    public class Gestione
    {
        public static double Sconto(double numero)
        {
            return numero / 100 * 10;
        }
        public static double Incremento(double numero,double incrementopercentuale)
        {
            double incremento = numero * incrementopercentuale / 100;
            double risultato = numero + incremento;
            return risultato;
        }
        public static double Lato(double area)
        {
            double lato = Math.Sqrt(area);
            return lato;
        }
    }
}
