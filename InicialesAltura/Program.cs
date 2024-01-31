bool salir = false;

while (!salir)
{
    Console.WriteLine("Por favor introduce tu altura aproximada en metros ( o 'salir' para finalizar): ");
    string alturaIngresada = Console.ReadLine();

    if (alturaIngresada.ToLower() == "salir")
    {
        salir = true;
    }
    else
    {
        Console.WriteLine("Por favor introzca sus iniciales: ");
        string inicialesIngresadas = Console.ReadLine();

        Console.WriteLine("Sus iniciales son: " + inicialesIngresadas + "y su altura es " +  alturaIngresada + "metros");
    }
}