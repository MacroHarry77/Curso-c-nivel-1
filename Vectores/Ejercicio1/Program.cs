//declaracion de una vector
int[] numeros = new int[10];
int n;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Ingreso de datos");
    n = int.Parse(Console.ReadLine());

    numeros[i] = n;
}

int acu = 0;

for (int i = 0; i < 10; i++)
{
    acu += numeros[i];
}

int promedio = acu /10;

