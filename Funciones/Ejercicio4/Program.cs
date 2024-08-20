internal class Program
{
    private static void Main(string[] args)
    {
        int a , b = 0;
        Console.WriteLine("Escribe un numero");
        a = int.Parse(Console.ReadLine());

        positivoNegativoCero(a , ref b);

        if (b == 0)
            Console.WriteLine("numero 0");
        else if(b == 1)
            Console.WriteLine("numero es positivo");
        else
            Console.WriteLine("numero es negativo");
    }   

    static void positivoNegativoCero(int a, ref int b)
    {
        if (a > 0)
            b = 1;
        else if(a < 0)
            b = -1;
    }
}