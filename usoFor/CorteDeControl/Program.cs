//Estrategia de control de datos sirve para enterder la logica 

//lote de datos y registros
//ejemplo cada jugadora de futbol o lo que sea se va a ingresar los datos de:
//edad sueldo y codigo de equipo
/*int edad, codEquipo, equipoActual;

float sueldo;

Console.WriteLine("ingresa la edad");
edad = int.Parse(Console.ReadLine());

Console.WriteLine("ingresa el codigo de equipo");
codEquipo = int.Parse(Console.ReadLine());

Console.WriteLine("ingresa el sueldo ");
sueldo = float.Parse(Console.ReadLine());

while (sueldo > 0)
{
    equipoActual = codEquipo;

    while (codEquipo == equipoActual)
    {
        //lote de procesos
        Console.WriteLine("ingresa la edad");
        edad = int.Parse(Console.ReadLine());

        Console.WriteLine("ingresa el codigo de equipo");
        codEquipo = int.Parse(Console.ReadLine());

        Console.WriteLine("ingresa el sueldo ");
        sueldo = float.Parse(Console.ReadLine());

    }
    //mostrar datos
}*/
int n, b, conNumeros, conNumerosTotales, minImpar = 0,nmrGrupo = 0, bolean = 0, contadorM = 0, porcentaje = 0;

for (int x = 0; x < 5; x++)
{
    conNumeros = 0;
    Console.WriteLine("Dame un numero de la lista " + (x + 1));
    n = int.Parse(Console.ReadLine());
    b = n;
    conNumerosTotales = 0;

    while (n != 0)
    {
        conNumerosTotales++;
        if (n % 2 != 0)
        {
            conNumeros++;
        }

        if (b < n )
        {
            bolean = 1;
        }
        b = n;
        Console.Write("0 para terminar o agregar otro elemento a la lista " + (x + 1) + " ");
        n = int.Parse(Console.ReadLine());
    }

    porcentaje = conNumeros * 100 / conNumerosTotales;
    if (minImpar < porcentaje)
    {
        minImpar = porcentaje;
        nmrGrupo = x + 1;
    }


    if (bolean == 0)
    {
        contadorM++;
    }
    bolean = 0;
}

Console.WriteLine("El numero del grupo con mayor porcentaje de numeros impares es: " + nmrGrupo);
Console.WriteLine("Numero de grupos ordenados de mayor a menor : " + contadorM);