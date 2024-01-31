Console.WriteLine("\t*** BIENVENIDO AL PROGRAMA DE NUMEROS ENTEROS! ***");
Console.WriteLine();

int num;
bool esNum;

do
{
    Console.WriteLine("Introduce aqui un numero entero: ");
    string entrada = Console.ReadLine();
    esNum = Int32.TryParse(entrada, out num);

    if (esNum)
    {
        Console.WriteLine("Correcto!! has introducido el numero {0}, gracias!",num); 
    }
    else
    {
        Console.WriteLine("Lo lamento ese numero no es valido, asegurate de ingresar un numero entero!");
    }
} while (!esNum);
Console.ReadLine();