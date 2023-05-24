using System;


//practica encapsulamiento y modificacion

namespace ConversorMoneda
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversor obj = new Conversor();

            obj.CambiarCotizacionPeso(433);

            Console.WriteLine("escriba cantidad de dolares a convertir: ");
            double dolares = double.Parse(Console.ReadLine());
            double conversion = obj.Convertir(dolares);
            Console.WriteLine($"${dolares} dolares son ${conversion} pesos");

        }
    }

    class Conversor
    {
        private double pesoTarjeta = 430;

        public double Convertir(double dolares)
        {
            return dolares * pesoTarjeta;
        }

        public void CambiarCotizacionPeso(double nuevoPeso)
        {
            if (nuevoPeso < 0){
                pesoTarjeta = 420;
            }
            else
            {
                pesoTarjeta = nuevoPeso;
            }
            
        }
    }
}
