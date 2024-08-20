
namespace primerprograma
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicializar variables
            int valor1, valor2;
            //pedir valores
            Console.WriteLine("Ingresa un numero");
            valor1 = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Ingresa otro numero");
            valor2 = int.Parse(Console.ReadLine());

        

            //calculo
            int resultado = 0;
            int resultado2 = 0;

            resultado = valor1 + valor2;
            resultado2 = valor2 * valor2;


            //mostrar en pantalla

            Console.WriteLine("El resultado de tu suma es " + resultado);
            Console.WriteLine("el numero " + valor2 + " elevado al cuadrado es " + resultado2);

            //kilometros

            float kilometros, velocidad, time;

            Console.WriteLine("ingresa los kilómetros existentes de tu destino");
            kilometros = int.Parse(Console.ReadLine());

            Console.WriteLine("ingresa la velocidad promedio de tu auto kilometros por hora");
            velocidad = int.Parse(Console.ReadLine());

            time = kilometros / velocidad;
            Console.WriteLine("EL tiempo para llegar a tu destino sera de: " + time.ToString("0.00") + " Horas");
            // ejercicios 3 casa de computacion

            float sueldo = 15000;
            float facturado;
            float comision;

            Console.WriteLine("Ingresa el total facturado plis");
            facturado = int.Parse(Console.ReadLine());

            //comision = 5 * facturado / 100;
            comision = facturado * 0.05F;
            sueldo = sueldo + comision;

            Console.WriteLine(sueldo);

            // Con ctrl + f2 puedo seleccionar todos los elementos 
        }
    }
}