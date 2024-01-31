bool salir = false;

while (!salir)
{
    Console.WriteLine("Por favor introduce la hora en formato HH:mm:ss (o 'salir' para finalizar): ");
    string horaIngresada = Console.ReadLine();

    if(horaIngresada.ToLower() == "salir")
    {
        salir = true;
    }
    else
    {
        if (DateTime.TryParseExact(horaIngresada, "HH:mm:ss", null, 
            System.Globalization.DateTimeStyles.None, out DateTime hora))
        {
            Console.WriteLine("Hpra introducida ok. Son las " + hora.ToString("HH:mm:ss"));
        }
        else
        {
            Console.WriteLine("Hora introducida no valida.");
        }
    }
}