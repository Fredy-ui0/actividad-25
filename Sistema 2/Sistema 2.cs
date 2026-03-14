int opcion;
string nombre = "";
string curso = "";
double nota1 = 0;
double nota2 = 0;
double nota3 = 0;
double prom = 0;

do
{
    Console.WriteLine("1. Registrar estudiante");
    Console.WriteLine("2. Calcular promedio");
    Console.WriteLine("3. Mostrar estado academico");
    Console.WriteLine("4. Salir");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:

            Console.Write("Nombre del estudiante: ");
            nombre = Console.ReadLine();

            
            for (int i = 0; i < nombre.Length; i++)
            {
                if (char.IsDigit(nombre[i]))
                {
                    Console.WriteLine("Advertencia: el nombre que ingreso tiene numeros");
                    break;
                }
            }

            Console.Write("Ingrese curso: ");
            curso = Console.ReadLine();

            Console.Write("Ingrese nota 1: ");
            nota1 = double.Parse(Console.ReadLine());
            if (nota1 > 100)
            {
                Console.WriteLine("Error: la nota que ingreso es mayor a 100");
            }

            Console.Write("Ingrese nota 2: ");
            nota2 = double.Parse(Console.ReadLine());
            if (nota2 > 100)
            {
                Console.WriteLine("Error: la nota que ingreso es mayor a 100");
            }

            Console.Write("Ingrese nota 3: ");
            nota3 = double.Parse(Console.ReadLine());
            if (nota3 > 100)
            {
                Console.WriteLine("Error: la nota que ingreso es mayor a 100");
            }

            break;

        case 2:

            prom = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("Promedio es: " + prom);

            break;

        case 3:

            if (prom >= 90 && prom <= 100)
            {
                Console.WriteLine("Estado: Excelente");
            }
            else if (prom >= 70)
            {
                Console.WriteLine("Estado: Aprobado");
            }
            else if (prom >= 60)
            {
                Console.WriteLine("Estado: Recuperacion");
            }
            else
            {
                Console.WriteLine("Estado: Reprobado");
            }

            break;

        case 4:
            Console.WriteLine("Saliendo...");
            break;

        default:
            Console.WriteLine("Su opcion es invalida");
            break;
    }

} while (opcion != 4);
    
