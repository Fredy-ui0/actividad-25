//sistema cajero automatico

using System.Reflection.Metadata.Ecma335;

Console.WriteLine("--------------------");
Console.WriteLine("1. Consultar saldo");
Console.WriteLine("2. Depositar dinero");
Console.WriteLine("3. Retirar dinero");
Console.WriteLine("4. Salir");
Console.WriteLine("--------------------");

int menu = int.Parse(Console.ReadLine());

int saldo = 1000;
switch (menu)

{
    case 1: //nos decia que el saldo es de 1000 quetzales, entonces puse ese valor.
        Console.WriteLine("Has seleccionado la opción 1: Consultar saldo");
        Console.WriteLine("Tu saldo actual es: Q1,000.00 " );
        
        if (saldo <= 0 || saldo == 0  )
            Console.WriteLine("Usted no tiene saldo disponible");
    break;
    
    
    
    case 2: // aqui se supone que el usuario ingresa la cantidad a depositar, entonces puse una variable deposito para almacenar ese valor, y luego se muestra el mensaje con la cantidad depositada.
        Console.WriteLine("Has seleccionado la opción 2: Depositar dinero");
        Console.WriteLine("Ingrese la cantidad a depositar: ");
        int deposito = int.Parse(Console.ReadLine());
        deposito= deposito;

        Console.WriteLine($"Usted ha depositado: {deposito} Quetzales");
        Console.WriteLine($"Su saldo actual es: {saldo + deposito} Quetzales");
        break;
    
    case 3: // aqui se supone que el usuario ingresa la cantidad a retirar, entonces puse una variable retiro para almacenar ese valor, y luego se muestra el mensaje con la cantidad retirada, y tambien se muestra el saldo restante despues de retirar el dinero.
        Console.WriteLine("Has seleccionado la opción 3: Retirar dinero");
        Console.WriteLine("Ingrese la cantidad a retirar: ");
        int retiro = int.Parse(Console.ReadLine());
        int saldorestante = saldo - retiro;

        Console.WriteLine($"Usted ha retirado: {retiro} Quetzales");
        Console.WriteLine($"Su saldo restante es: {saldorestante} Quetzales");
     break;
    case 4:
        Console.WriteLine("Has seleccionado la opción 4: Salir");


        break;
    default:
        Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 4.");
        break;
}