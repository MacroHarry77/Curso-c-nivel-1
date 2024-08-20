internal class Program
{
    private static void Main(string[] args)
    {
       //resultado = Funcion(Argumentos);
    // cuando los argumentos se pasan por valor
    // se crea una copia del mismo 

      //resultado = Funcion(ref Argumentos)
    // cuando los argumentos se pasan por Referencia
    // Se envia el espacio en memoria osea el valor original 

        int num1 = 0, num2 = 0, resultado;

        pedirDatos(ref num1, ref num2);
        //resultado = num1 + num2;
        resultado = suma(num1,num2);

        Console.WriteLine("El resultado de tu suma es: " + resultado);
    }
    //static tipo-de-dato funcion(tipo-de-dato Parametros);
    static int suma(int a , int b)
    {
        int r;
        r = a + b;
        return r;
    }

    static void pedirDatos(ref int a, ref int b)
    {
        Console.WriteLine("Escribe un numero");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Escribe otro numero");
        b = int.Parse(Console.ReadLine());
    }
    
}