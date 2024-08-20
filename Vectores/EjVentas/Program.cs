internal class Program
{
    private static void Main(string[] args)
    {
        int[] articulos = new int[5];

        for (int i = 0; i < articulos.Length; i++)
        {
            articulos[i] = 0;
        }

        int  numArticulos = 0;
        int venta = 0;

        Console.WriteLine("Numero de articulo 1-5");
        numArticulos = int.Parse(Console.ReadLine());

        Console.WriteLine("Cantidad vendida");
        venta = int.Parse(Console.ReadLine());

        while (numArticulos != 0)
        {
            articulos[numArticulos - 1] += venta;

            Console.WriteLine("Numero de articulo 1-5");
            numArticulos = int.Parse(Console.ReadLine());

            Console.WriteLine("Cantidad vendida");
            venta = int.Parse(Console.ReadLine());
        }   

        int max = 0;
        int indiceMax = 0;

        Console.WriteLine("numero de articulos que no registraron ventas: ");
        for (int i = 0; i < articulos.Length; i++)
        {
            if (articulos[i] > max)
            {
                max = articulos[i];
                indiceMax = i;
            }

            if (articulos[i] == 0)
            {
                Console.WriteLine("Articulo # " + (i + 1));
            }
        }
        Console.WriteLine("El número de artículo que más se vendió en total: " + (indiceMax + 1 ) + " " + max);
        Console.WriteLine("Cantidad de ventas del articulo 4 " + articulos[3]);
    }
}