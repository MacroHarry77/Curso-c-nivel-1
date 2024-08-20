
internal class Program
{
    private static void Main(string[] args)
    {
        char[] cadChar = new char[21];
        char caracter;

        char suelto1;
        char suelto2;

        int i = 0;
        Console.WriteLine("Escribe un maximo de 20 caracteres termina con punto");
        caracter = char.Parse(Console.ReadLine());

        while (i < 20 && caracter != '.' )
        {
            cadChar[i] = caracter;
            caracter = char.Parse(Console.ReadLine());
            i++;
        }

        cadChar[i] = '\0';
        i = 0;

        Console.WriteLine("Cadena Original");
        //for (int x = 0; x < 20 && cadChar[x] != '\0'; x++)
        //{
        //    Console.Write(cadChar[x]);
        //}
        while (cadChar[i] != '\0')
        {
            Console.Write(cadChar[i]);
            i++;
        }

        Console.WriteLine(" ");       

        Console.WriteLine("Escribe un caracter");
        suelto1 = char.Parse(Console.ReadLine());  

        Console.WriteLine("Escribe  otro caracter");
        suelto2 = char.Parse(Console.ReadLine()); 

        i = 0;

        while (cadChar[i] != '\0')
        {
            if (cadChar[i] == suelto1)
            {
                cadChar[i] = suelto2;
            }
            i++;
        }

        Console.WriteLine("Cadena Resultado: ");

        for (int x = 0; x < 20 && cadChar[x] != '\0'; x++)
        {
            Console.Write(cadChar[x]);
        }
    }
}