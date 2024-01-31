Console.WriteLine("\t*** BIENVENIDO AL PROGRAMA ***");
Console.WriteLine();

Console.WriteLine("Por favor introduzca aqui su nombre: ");
string nombre = Console.ReadLine();

Console.WriteLine("Hola {0} un placer conocerte, ahora por favor introduce tu edad: ", nombre);
string entrada = Console.ReadLine();

if (Int32.TryParse(entrada, out int edad))
{
    Console.WriteLine("{0}, ahora se que tienes {1} años, gracias por compartirlo!", nombre, edad);
}
else
{
    Console.WriteLine("Esa no es una edad valida, intenta de nuevo...");
}
Console.ReadLine();