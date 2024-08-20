int n1, n2, n3, n4;
int menor;

Console.WriteLine("Dame un numero 1 ");
n1 = int.Parse(Console.ReadLine());
menor = n1;

Console.WriteLine("Dame un numero 2 ");
n2 = int.Parse(Console.ReadLine());

if (menor > n2)

    menor = n2;

Console.WriteLine("Dame un numero 3 ");
n3 = int.Parse(Console.ReadLine());

if (menor > n3)

    menor = n3;


Console.WriteLine("Dame un numero 4 ");
n4 = int.Parse(Console.ReadLine());

if (menor > n4)

    menor = n4;


Console.WriteLine("Numero menor es: " + menor);





