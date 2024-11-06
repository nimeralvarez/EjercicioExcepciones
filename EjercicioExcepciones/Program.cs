

using EjercicioExcepciones;

int opcion = 0;
double numeroUno;
double numeroDos;
Operaciones op = new Operaciones();
do
{
    try{
        Console.WriteLine("*** O P E R A C I O N E S   B A S I C A ***");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.WriteLine("5. Salir");
        Console.Write("Ingrese el número de la operación a realizar: ");
        opcion = Convert.ToInt32(Console.ReadLine());
    }catch(FormatException fe)
    {
        Console.WriteLine("Debe de ingresar un valor entero.");
    }
    finally
    {
        if(opcion<1 || opcion > 5)
        {
            Console.WriteLine("Debe de ingresar el numero de la operación a realizar.");
        }
        Console.WriteLine();
    }

    switch (opcion)
    {
        case 1:
            try
            {
                Console.Write("Ingrese el sumandos uno: ");
                numeroUno = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el sumandos dos: ");
                numeroDos = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"El resultado de la suma es: {op.Suma(numeroUno, numeroDos)}");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Debe de ingresar un valores entero.");

            }
            finally
            {
                Console.WriteLine();
                numeroUno = 0;
                numeroDos = 0;
            }
            break;
        case 2:
            try
            {
                Console.Write("Ingrese el minuedo: ");
                numeroUno = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el sustraendo: ");
                numeroDos = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"El resultado de la resta es: {op.Resta(numeroUno, numeroDos)}");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Debe de ingresar un valores entero.");

            }
            finally
            {
                Console.WriteLine();
                numeroUno = 0;
                numeroDos = 0;
            }
            break;
        case 3:
            try
            {
                Console.Write("Ingrese el multiplicando: ");
                numeroUno = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el multiplicador: ");
                numeroDos = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"El resultado de la multiplicación es: {op.Multiplicar(numeroUno, numeroDos)}");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Debe de ingresar un valores entero.");

            }
            finally
            {
                Console.WriteLine();
                numeroUno = 0;
                numeroDos = 0;
            }
            break;
        case 4:
            try
            {
                Console.Write("Ingrese el dividendo: ");
                numeroUno = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el divisor: ");
                numeroDos = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"El resultado de la división es: {op.Division(numeroUno, numeroDos)}");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Debe de ingresar un valores entero.");
            }
            finally
            {
                Console.WriteLine();
                numeroUno = 0;
                numeroDos = 0;
            }
            break;
        default:
            Console.WriteLine("Saliendo del programa.");
            break;
    }

} while (opcion!=5);