internal class Program
{
    private static void Main(string[] args)
    {//ejercici 1 
        /*
        int nr1, nr2, result = 0 ;

        Console.WriteLine("Ingrese un numero: ");
        nr1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un numero: ");
        nr2 = int.Parse(Console.ReadLine());

        if (nr1 > nr2)
        {
            result = nr1 - nr2;
        }

        if (nr1 == nr2)
        {
            result = nr1 + nr2;
        }

        if (nr1 < nr2)
        {
            result = nr1 * nr2;
        }

        Console.WriteLine("El resultado es: " + result);
        */

        //ejercicio 2
        /*
        float litros, importeTotal;
        Console.WriteLine("Cantidad de litros vendida ");
        litros = float.Parse(Console.ReadLine());

        Console.WriteLine("Importe total de la venta ");
        importeTotal = float.Parse(Console.ReadLine());

        if (litros > 100 && litros <= 300)
        {
            importeTotal *=  0.9F;
        }else if (litros > 300 && litros <= 500)
        {
            importeTotal *=  0.85F;

        }else if (litros > 500)
        {
            importeTotal *=  0.75F;
        }
        
        Console.WriteLine(importeTotal);
        */
        /*
        int opcion1, opcion2, opcion3, montoTotal = 0;
        Console.WriteLine("Selecciona la configuracin de tu pc gamer master raze");
        Console.WriteLine("1.(i5) 2.(i7) 3.(i9) Proce");
        opcion1 = int.Parse(Console.ReadLine());
        Console.WriteLine("1.(8) 2.(16) 3.(32) Ram");
        opcion2 = int.Parse(Console.ReadLine());

        if (opcion1 == 1)
        {
            switch (opcion2)
            {
                case(1):
                montoTotal = 800;
                break;
               
                case(2):
                montoTotal = 900;
                break;
               
                case(3):
                montoTotal = 1000;
                break;

                default:
                break;
            }
        }

        if (opcion1 == 2)
        {
            switch (opcion2)
            {
                case(1):
                montoTotal = 900;
                break;
               
                case(2):
                montoTotal = 1000;
                break;
               
                case(3):
                montoTotal = 1400;
                break;

                default:
                break;
            }
        }

        if (opcion1 == 3)
        {
            switch (opcion2)
            {
                case(1):
                montoTotal = 1200;
                break;
               
                case(2):
                montoTotal = 1400;
                break;
               
                case(3):
                montoTotal = 2000;
                break;

                default:
                break;
            }
        }   

        Console.WriteLine("Ampliar almacenamiento a 1tb 1:si 2:no");
        opcion3 = int.Parse(Console.ReadLine());

        if (opcion3 == 1)
        {
            montoTotal += 300;
        }
        
        Console.WriteLine(montoTotal);
        */


    }
}
