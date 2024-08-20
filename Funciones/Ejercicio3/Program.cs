using System.Security.AccessControl;

internal class Program
{
    static void Main(string[] args)
    {
        int nmr, cont = 0, acu = 0;
        Console.WriteLine("Escribe numeros corta con 0"); 
        nmr = int.Parse(Console.ReadLine()); 
        while (nmr != 0)
        {
            if (primo(nmr))
            {
                acu += nmr;
                cont++;
            }

            nmr = int.Parse(Console.ReadLine());
        }
       
        Console.WriteLine("El promedio teniendo en cuenta los numeros primos es: " + promedio(acu,cont)); 
    }

    static bool primo(int a)
    {
       int cont = 0;
       for (int i = 1; i <= a; i++)
       {
            if (a % i == 0)
            {
                cont++;
            }
       }

        if (cont == 2)
            return true;
        else
            return false;
    }

    static float promedio(int acu, int cont)
    {
        float prom;
        prom = acu / cont;
        return prom;
    }
}