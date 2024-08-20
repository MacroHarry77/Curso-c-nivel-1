int edad = 20;
char letra = 'h';

if (letra == 'j' && letra == 'h' || edad >  20)
{
    Console.WriteLine("DESCUENTO");
}
Console.WriteLine("fin");

//switch
char letra2 = 'M';

switch(letra2){

    case 'A':
    //CODIGO EN CASE DE QUE LETRA2 SEA A
    break;
    case 'B':
    //CODIGO EN CASE DE QUE LETRA2 SEA B
    break;
    case 'D':
    //CODIGO EN CASE DE QUE LETRA2 SEA D
    break;
    default:
    Console.WriteLine("No coincide con ninguno ");
    break;
}
