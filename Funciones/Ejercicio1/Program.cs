internal class Program
{
    static void Main(string[] args)
    {
        int art = 0, cant = 0;
        Console.WriteLine("Dame el precio del articulo ");
        art = int.Parse(Console.ReadLine());

        
        Console.WriteLine("Cantidad vendida ");
        cant = int.Parse(Console.ReadLine());

        Console.WriteLine("El monto total a pagar es: " + producto(art,cant));
    } 

    static int producto(int a, int b)
    {
        //int r = a * b;
        return a * b;
    }
}