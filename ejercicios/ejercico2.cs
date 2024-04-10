Console.Write("ingrese un numero ");
int numero;
if (!Int32.TryParse(Console.ReadLine(), out numero))
{
    Console.WriteLine("Error, debe ingresar un número correcto");
}
else
{
    numero %= 2;
    if (numero == 0)
    {
        Console.WriteLine("el numero es par");
    }
    else
    {
        Console.WriteLine("el numero es impar");
    }
}
