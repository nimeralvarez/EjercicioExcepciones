
namespace EjercicioExcepciones
{
    public class Operaciones
    {
        public double Suma (double sumandosUno, double sumandosDos)
        {
            return sumandosUno + sumandosDos;
        }

        public double Resta (double minuedo, double sustraendo)
        {
            return minuedo - sustraendo;
        }

        public double Multiplicar (double multiplicando, double multiplicador)
        {
            return multiplicando * multiplicador;
        }

        public double Division(double dividendo, double divisor)
        {
            try
            {
                return dividendo/divisor;

            }catch(DivideByZeroException e)
            {
                Console.WriteLine("El divisor debe ser un numero diferente a cero.");
                return 0;
            }
        }

    }
}
