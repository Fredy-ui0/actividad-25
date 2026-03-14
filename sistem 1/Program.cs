Console.WriteLine("1. Registrar usuario ");
Console.WriteLine("2. Mostrar usuarios registrados");
Console.WriteLine("3. Buscar usuario por nombre");
Console.WriteLine("4. Salir");
Console.Write("elija una opcion: ");
opcion = int.Parse(Console.ReadLine());

if (opcion == 1)
{
    Console.Write("coloque su nombre: ");
    nom = Console.ReadLine();
    caracteres = nom.Length;

    Console.Write("coloque su edad: ");
    ed = int.Parse(Console.ReadLine());

    Console.Write("coloque su correo: ");
    corr = Console.ReadLine();

    Console.WriteLine("1 Administrador  ");
    Console.WriteLine("2 Cliente");
    Console.WriteLine("3 Invitado");
    Console.Write("elija un tipo de usuario: ");
    us = int.Parse(Console.ReadLine());

    switch (us)
    {
        case 1:
            Console.WriteLine(" Administrador  ");
            break;
        case 2:
            Console.WriteLine(" Cliente");
            break;
        case 3:
            Console.WriteLine(" Invitado");
            break;
        default:
            Console.WriteLine("opcion invalida (no se pudo registrar )");
            break;

    }



    if (caracteres < 3)

    {

        Console.WriteLine("el usuario tiene que ser mayor a 3 caracteres (no se pudo registrar )");

    }

    if (ed < 18)
    {
        Console.WriteLine("es menor de edad (no se pudo registrar )");

    }

    if (corr.Contains("@"))
    {

    }
    else
    {
        Console.WriteLine("su correo no tiene @ (no se pudo registrar )");
    }

    if (corr.Contains("@") && caracteres >= 3 && ed >= 18 && us >= 1 && us <= 3)
    {
        Console.WriteLine("usuario registrado");
        regis++;
    }
}

if (opcion == 2)
{

    if (regis >= 1)
    {
        Console.WriteLine(nom + " esta registrado");
    }
}
if (opcion == 3)
{
    Console.Write("coloque al usuario que esta buscando: ");
    string busc = Console.ReadLine();

    if (busc.Contains(nom))
    {
        Console.WriteLine("el usuario esta registrado");
    }
    else
    {
        Console.WriteLine("usuario no encontrado");
    }

}
}
Console.WriteLine("programa finalizado");