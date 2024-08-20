internal class Program
{
    static void Main(string[] args)
    {
        int nmr = 0;
        Console.WriteLine("Escribe 20 numeros");
        int cont = 0;

        for (int i = 0; i < 20; i++)
        {
            nmr = int.Parse(Console.ReadLine());
            if (par(nmr))
            {
                cont++;
            }
        }
        Console.WriteLine(cont + " Numeros son pares"); 
    }

    static bool par(int a)
    {
        if (a % 2 == 0)
            return true;
        else
            return false;
    }
}