int caracteres = 0;
string nom = " ";
int ed = 0;
string corr = " ";
int us = 0;
int opcion = 0;

while (opcion != 4)
{

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

    }
}
