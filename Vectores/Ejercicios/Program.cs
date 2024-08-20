internal class Program
{
    private static void Main(string[] args)
    {
        int[] numeros = new int[10];
        //int numero = 0;
        int max = 0;
        int indice = 0;
        float acu = 0;
        float prom = 0;
        Console.WriteLine("Escribe 10 numeros ");
        for (int i = 0; i < 10; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }
        
        for (int i = 0; i < 10; i++)
        {
            if (numeros[i] > max)
            {
                max = numeros[i];
                indice = i;
            }
            acu += numeros[i];
        }

        Console.WriteLine("El numero maximo en el vector es: " + max + " Y esta en la posicion " + indice);
        Console.WriteLine("promedio " + (prom = acu/10));
        Console.WriteLine("Numeros mayores al promedio ");

        for (int i = 0; i < 10; i++)
        {
            if (numeros[i] > prom )
            {
                Console.WriteLine(numeros[i]);
            }
        }

    }
}