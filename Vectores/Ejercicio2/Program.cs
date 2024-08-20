// se puede crear un vector con cualquier tipo de dato int float bool char ...
bool[] aistenciaAlumnos = new bool[15];

for (int i = 0; i < aistenciaAlumnos.Length; i++)
{
    // si asistio guarda 1 si no 0
}
// ejemplos con tipo de dato char
char[] palabra = new char[18];

char letra;
int indice = 0;

Console.WriteLine("Escribe tu nombre por letra (termina con punto)");
letra = char.Parse(Console.ReadLine());
while (letra != '.' && indice < 17)
{
    palabra[indice] = letra;
    indice++;
    letra = char.Parse(Console.ReadLine());
}

palabra[indice] = '\0';
indice = 0;

while (palabra[indice] != '\0')
{
    Console.Write(palabra[indice]);
    indice++;
}



