internal class Program
{
    private static void Main(string[] args)
    {
        float importeCompra;
       

        Console.WriteLine("Dame el valor de importe");
        importeCompra = float.Parse(Console.ReadLine());
        
        if (importeCompra >= 1000)
        {
            if (importeCompra < 5000)
            {
              importeCompra = importeCompra * 0.9F;
            }else{
              importeCompra = importeCompra * 0.82F;
            }
        }

        Console.WriteLine("Importe Final Con Descuento: " + importeCompra);
    }
}