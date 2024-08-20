internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Dame un numero");
        int nmr = int.Parse(Console.ReadLine());
        int cont = 0;

        for (int i = 1; i <= nmr; i++)
        {
            if (nmr % i == 0)
            {
                cont++;
            }
        }

        if (cont == 2)
        {
            Console.WriteLine("El numero es primo");

        }else{Console.WriteLine("El numero no es primo");}

        int n,max = 0, min = 0;
        bool f = false;

        for (int i = 0; i < 20; i++)
        {

            Console.WriteLine("Escribe un numero:");
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                if (max < n)
                {
                    max = n;
                }
            }else
            {
               if (!f)
               {
                min = n;
                f = true;
               }
               if (min > n)
               {
                min = n;
               }
            }
        }

        Console.WriteLine("El numero par maximo es: " + max);
        Console.WriteLine("El numero impar minimo es: " + min);
    }
}