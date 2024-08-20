using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        int num1, num2, resultado;

        Console.WriteLine("Escribe un numero");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Escribe otro numero");
        num2 = int.Parse(Console.ReadLine());

        //resultado = num1 + num2;
        resultado = suma(num1,num2);

        Console.WriteLine("El resultado de tu suma es: " + resultado);
    }

    static int suma(int a , int b)
    {
        int r;
        r = a + b;
        return r;
    }
}