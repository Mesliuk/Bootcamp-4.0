class ProgramMain
{
    class Ejercicio01
    {
        public static void Run()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nEjercicio 1. Número Positivo, Negativo o Cero");
                while (true)
                {
                    Console.Write("\nIngrese un número: ");
                    string? input = Console.ReadLine();
                    if (int.TryParse(input, out int numeroIngresado))
                    {
                        if (numeroIngresado == 0)
                        {
                            Console.WriteLine("\nEl número es cero.");
                            break;
                        }
                        else if (numeroIngresado > 0)
                        {
                            Console.WriteLine("\nEl número es positivo.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nEl número es negativo.");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                    }
                }
                Console.Write("\nDesea volver a iniciar precione (S/N)");
                string? respuesta = Console.ReadLine()?.ToUpper();
                Console.Clear();
                if (respuesta != "S")
                {
                    continuar = false;
                    Console.WriteLine("\n¡Fin Ejercicio 1!");
                    Thread.Sleep(2000);
                    Console.Clear();

                }
            }
        }
    }
    class Ejercicio02
    {
        public static void Run()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nEjercicio 2. Comparacion de tres números.");

                int num2, num3;

                Console.Write("\nIngrese el primer número: ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int num1))
                {

                    while (true)
                    {
                        Console.Write("\nIngrese el segundo número: ");
                        num2 = int.Parse(Console.ReadLine()!);

                        if (num2 != num1)
                            break;
                        else
                        {
                            Console.WriteLine("Debe ingresar un número distinto al primero");
                        }
                    }
                    while (true)
                    {
                        Console.Write("\nIngrese el tercer número: ");
                        num3 = int.Parse(Console.ReadLine()!);
                        if (num3 != num1 && num3 != num2)
                            break;
                        else
                        {
                            Console.WriteLine("Debe ingresar un número distinto a los dos primeros");
                        }
                    }
                    int mayor = num1;
                    if (num2 > mayor)
                        mayor = num2;
                    if (num3 > mayor)
                        mayor = num3;

                    int menor = num1;
                    if (num2 < menor)
                        menor = num2;
                    if (num3 < menor)
                        menor = num3;

                    Console.WriteLine($"\nEl número mayor es: {mayor}");
                    Console.WriteLine($"\nEl número menor es: {menor}");
                }
                else
                {
                    Console.WriteLine("\nEntrada inválida. Por favor, ingrese un número entero.");
                }



                Console.Write("\nDesea volver a iniciar precione (S/N)");
                string? respuesta = Console.ReadLine()?.ToUpper();
                Console.Clear();
                if (respuesta != "S")
                {
                    continuar = false;
                    Console.WriteLine("¡Fin Ejercicio 2!");
                    Thread.Sleep(2000);
                    Console.Clear();

                }
            }

        }
    }
    class Ejercicio03
    {
        public static void Run()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nEjercicio 3. Múltiplos de un número.");
                int num1, num2;
                while (true)
                {
                    Console.Write("\nIngrese el primer número (el cual se evaluará si es múltiplo): ");
                    string? input = Console.ReadLine();

                    if (int.TryParse(input, out num1))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero válido.\n");
                    }
                }
                while (true)
                {

                    Console.Write("\nIngrese el segundo número (el cual se usará para evaluar el múltiplo): ");

                    string? input = Console.ReadLine();
                    if (int.TryParse(input, out num2) && num2 != 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero válido.\n");
                    }
                }

                if (num1 % num2 == 0)
                {
                    Console.WriteLine($"\n{num1} es múltiplo de {num2}.");

                }
                else
                {
                    Console.WriteLine($"\n{num1} no es múltiplo de {num2}.");

                }

                Console.Write("\nDesea volver a iniciar precione (S/N)");
                string? respuesta = Console.ReadLine()?.ToUpper();
                Console.Clear();
                if (respuesta != "S")
                {
                    continuar = false;
                    Console.WriteLine("¡Fin Ejercicio 3!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }

            }
        }
    }
    class Ejercicio04
    {
        public static void Run()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nEjercicio 4. Descuento en tienda");
                while (true)
                {


                    Console.Write("\nIngrese el monto de la compra: ");
                    string? input = Console.ReadLine();

                    if (decimal.TryParse(input, out decimal montoCompra) && montoCompra >= 1)
                    {
                        decimal descuento = 0;
                        if (montoCompra > 1000)
                        {
                            descuento = montoCompra * 0.10m;
                        }

                        decimal montoFinal = montoCompra - descuento;
                        Console.WriteLine($"\nEl descuento aplicado es: {descuento:C}");
                        Console.WriteLine($"\nEl monto final a pagar es: {montoFinal:C}");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un monto válido.");
                    }
                }
                Console.Write("\nDesea volver a iniciar precione (S/N)");
                string? respuesta = Console.ReadLine()?.ToUpper();
                Console.Clear();
                if (respuesta != "S")
                {
                    continuar = false;
                    Console.WriteLine("¡Fin Ejercicio 4!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
    }
    class Ejercicio05
    {
        public static void Run()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nEjercicio 5. Conversión de tipo.");
                while (true)
                {
                    Console.Write("\nIngrese un número decimal: ");
                    string? input = Console.ReadLine();
                    {
                        if (decimal.TryParse(input, out decimal numeroDecimal))
                        {
                            int numeroEntero = Convert.ToInt32(numeroDecimal);

                            Console.WriteLine($"\nEl número decimal ingresado: {numeroDecimal}");
                            Console.WriteLine($"\nEl número convertido a entero es: {numeroEntero}");
                            Console.WriteLine("\nDiferencia");
                            Console.WriteLine($"Un numero decimal: {numeroDecimal} al pasarlo a entero se realiza truncando la parte decimal o redondeando al entero mas cercano {numeroEntero}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Por favor, ingrese un número decimal.");

                        }
                    }
                }

                Console.Write("\nDesea volver a iniciar precione (S/N)");
                string? respuesta = Console.ReadLine()?.ToUpper();
                Console.Clear();
                if (respuesta != "S")
                {
                    continuar = false;
                    Console.WriteLine("¡Fin Ejercicio 5!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
    }
    class Ejercicio06
    {
        public static void Run()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nEjercicio 6. Clasificación por edad.");
                while (true)
                {
                    Console.Write("\nIngresa tu edad:");
                    string? input = Console.ReadLine();

                    if (int.TryParse(input, out int edad) && edad > 0)
                    {
                        if (edad <= 11)
                        {
                            Console.WriteLine("\nEres un niño.");
                            break;
                        }
                        else if (edad <= 17)
                        {
                            Console.WriteLine("\nEres un adolescente.");
                            break;
                        }
                        else if (edad <= 59)
                        {
                            Console.WriteLine("\nEres un adulto.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nEres un adulto mayor.");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada inválida. Ingrese un numero entero (sin decimal o letra).");
                    }
                }


                Console.Write("\nDesea volver a iniciar precione (S/N)");
                string? respuesta = Console.ReadLine()?.ToUpper();
                Console.Clear();
                if (respuesta != "S")
                {
                    continuar = false;
                    Console.WriteLine("¡Fin Ejercicio 6!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
    }
    class Ejercicio07
    {
        public static void Run()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Ejercicio 7: Número dentro de rango.");
                while (true)
                {

                    Console.Write("Ingrese un número entero: ");
                    string? input = Console.ReadLine();

                    if (int.TryParse(input, out int numero))
                    {
                        if (numero >= 1 && numero <= 100)
                        {
                            Console.WriteLine("El número está dentro del rango de 1 a 100.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("El número está fuera del rango de 1 a 100.");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nEntrada inválida. Ingrese un numero entero (sin decimal o letra).");

                    }

                }
                Console.Write("\nDesea volver a iniciar precione (S/N)");
                string? respuesta = Console.ReadLine()?.ToUpper();
                Console.Clear();
                if (respuesta != "S")
                {
                    continuar = false;
                    Console.WriteLine("\n¡Fin Ejercicio 7!");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
            }


        }
    }
    class Ejercicio08
    {
        public static void Run()
        {
            bool continuar = true;
            while (continuar)
            {
                {
                    Console.WriteLine("Ejercicio 8: Operador ternario.");
                    while (true)
                    {
                        Console.Write("\nIngrese un número entero: ");
                        string? input = Console.ReadLine();

                        if (int.TryParse(input, out int numero) && numero >= 0)
                        {
                            string resultado = (numero % 2 == 0) ? "El número es par." : "El número es impar.";
                            Console.WriteLine(resultado);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nEntrada inválida. Ingrese un numero entero (sin decimal o letra).");
                        }
                    }

                    Console.Write("\nDesea volver a iniciar precione (S/N)");
                    string? respuesta = Console.ReadLine()?.ToUpper();
                    Console.Clear();
                    if (respuesta != "S")
                    {
                        continuar = false;
                        Console.WriteLine("\n¡Fin Ejercicio 8!");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                    }
                }


            }
        }
    }
    class Ejercicio09
    {
        public static void Run()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Ejercicio 9: Cálculo de impuestos.\n");
                while (true)
                {
                    Console.Write("\nIngrese su Ingreso Anual: ");
                    string? input = Console.ReadLine();
                    if (decimal.TryParse(input, out decimal montoCompra) && montoCompra > 0)
                    {
                        decimal impuesto = 0;

                        if (montoCompra < 10000)
                        {
                            Console.WriteLine("No se aplica impuesto.");
                        }
                        else if (montoCompra >= 10000 && montoCompra < 50000)

                        {
                            impuesto = montoCompra * 0.10m;
                        }
                        else
                        {
                            impuesto = montoCompra * 0.20m;
                        }
                        decimal totalConImpuesto = montoCompra + impuesto;

                        Console.WriteLine($"\nEl monto del impuesto es: {impuesto:C}");
                        Console.WriteLine($"El total a pagar con impuesto es: {totalConImpuesto:C}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Ingrese un monto válido (número positivo).");
                    }
                }
                Console.Write("\nDesea volver a iniciar precione (S/N)");
                string? respuesta = Console.ReadLine()?.ToUpper();
                Console.Clear();
                if (respuesta != "S")
                {
                    continuar = false;
                    Console.WriteLine("\n¡Fin Ejercicio 9!");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
    }
    class Ejercicio10
    {
        public static void Run()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nEjercicio 10. Día de la semana con switch.");
                while (true)
                {
                    Console.Write("\nIngrese un número del 1 al 7:");
                    string? input = Console.ReadLine();
                    if (int.TryParse(input, out int dia))
                    {
                        switch (dia)
                        {
                            case 1:
                                Console.WriteLine("\nEl día correspondiente es Lunes.");
                                break;
                            case 2:
                                Console.WriteLine("\nEl día correspondiente es Martes.");
                                break;
                            case 3:
                                Console.WriteLine("\nEl día correspondiente es Miércoles.");
                                break;
                            case 4:
                                Console.WriteLine("\nEl día correspondiente es Jueves.");
                                break;
                            case 5:
                                Console.WriteLine("\nEl día correspondiente es Viernes.");
                                break;
                            case 6:
                                Console.WriteLine("\nEl día correspondiente es Sábado.");
                                break;
                            case 7:
                                Console.WriteLine("\nEl día correspondiente es Domingo.");
                                break;
                            default:
                                Console.WriteLine("\nNúmero inválido. Por favor, ingrese un número del 1 al 7.");
                                break;
                        }
                        break;
                    }
                }

                Console.Write("\nDesea volver a iniciar precione (S/N)");
                string? respuesta = Console.ReadLine()?.ToUpper();
                Console.Clear();
                if (respuesta != "S")
                {
                    continuar = false;
                    Console.WriteLine("\n¡Fin Ejercicio 10!");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
    }
    class Ejercicio11
    {
        public static void Run()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nEjercicio 11. Menú con Switch.\n");
                Console.WriteLine("Seleccione una opción del menú:");
                Console.WriteLine("1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir\n5. Salir");
                Console.Write("\nIngrese su opción (1-5): ");

                string? input = Console.ReadLine();
                int opcion;

                while (true)
                {
                    if (!int.TryParse(input, out opcion) || opcion < 1 || opcion > 5)
                    {
                        Console.WriteLine("\nOpción inválida. Por favor, seleccione una opción del 1 al 5.");
                        System.Threading.Thread.Sleep(2000);
                        Console.Write("\nIngrese su opción (1-5): ");
                        input = Console.ReadLine();
                        continue;
                    }
                    if (opcion == 5)
                    {
                        Console.WriteLine("\nHa seleccionado Salir.");
                        continuar = false;
                        break;
                    }
                    break;
                }
                if (!continuar) break;
                switch (opcion)
                {
                    case 1: Console.WriteLine("\nHa seleccionado Sumar."); break;
                    case 2: Console.WriteLine("\nHa seleccionado Restar."); break;
                    case 3: Console.WriteLine("\nHa seleccionado Multiplicar."); break;
                    case 4: Console.WriteLine("\nHa seleccionado Dividir."); break;
                }
                double num1, num2;
                while (true)
                {
                    Console.Write("\nIngrese el primer número: ");
                    string? inputnum1 = Console.ReadLine();
                    if (double.TryParse(inputnum1, out num1)) break;
                    Console.WriteLine("\nEntrada inválida. Por favor, ingrese un número válido.");
                }
                while (true)
                {
                    Console.Write("\nIngrese el segundo número: ");
                    string? inputnum2 = Console.ReadLine();
                    if (double.TryParse(inputnum2, out num2)) break;
                    Console.WriteLine("\nEntrada inválida. Por favor, ingrese un número válido.");
                }
                switch (opcion)
                {
                    case 1: Console.WriteLine($"\nEl resultado de la suma es: {num1 + num2}"); break;
                    case 2: Console.WriteLine($"\nEl resultado de la resta es: {num1 - num2}"); break;
                    case 3: Console.WriteLine($"\nEl resultado de la multiplicación es: {num1 * num2}"); break;
                    case 4:
                        if (num2 != 0)
                            Console.WriteLine($"\nEl resultado de la división es: {num1 / num2}");
                        else
                            Console.WriteLine("\nError: No se puede dividir por cero.");
                        break;
                }
                Console.Write("\nDesea volver a iniciar precione (S/N): ");
                string? respuesta = Console.ReadLine()?.ToUpper();
                Console.Clear();
                if (respuesta != "S")
                {
                    continuar = false;
                    Console.WriteLine("\n¡Fin Ejercicio 11!");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
    }
    class Ejercicio12
    {
        public static void Run()
        {
            bool continuar = true;
            while (continuar)
            {
                {
                    Console.WriteLine("\nEjercicio 12. Contador de Pares.\n");
                    while (true)
                    {
                        Console.Write("Ingrese un número para ver cuantos pares hay hasta el 1: ");
                        string? input = (Console.ReadLine());
                        if (int.TryParse(input, out int numero) && (numero >= 1))
                        {
                            int contadorPares = 0;
                            for (int i = 1; i <= numero; i++)
                            {
                                if (i % 2 == 0)
                                {
                                    contadorPares++;
                                }
                            }
                            Console.WriteLine($"\nLa cantidad de números pares desde 1 hasta {numero} es: {contadorPares}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nEntrada inválida. Por favor, ingrese un número entero válido o mayor a 1.");
                        }
                    }
                }
                Console.Write("\nDesea volver a iniciar precione (S/N)");
                string? respuesta = Console.ReadLine()?.ToUpper();
                Console.Clear();
                if (respuesta != "S")
                {
                    continuar = false;
                    Console.WriteLine("\n¡Fin Ejercicio 12!");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
    }
    class Ejercicio13
    {
        public static void Run()
        {
            bool continuar = true;
            while (continuar)
            {

                {
                    Console.WriteLine("\nEjercicio 13. Suma de números impares del 1 al 100\n");
                    while (true)
                    {
                        Console.Write("Ingrese un número: ");
                        string? input = Console.ReadLine();
                        if (int.TryParse(input, out int numero) && (numero >= 1))
                        {

                            int sumaImpares = 0;
                            for (int i = 1; i <= numero; i++)
                            {
                                if (i % 2 != 0)
                                {
                                    sumaImpares += i;
                                }
                            }
                            Console.WriteLine($"\nLa suma de los números impares desde {numero} es: {sumaImpares}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nEntrada inválida. Por favor, ingrese un número entero válido o mayor a 1.");
                        }
                    }
                    Console.Write("\nDesea volver a iniciar precione (S/N)");
                    string? respuesta = Console.ReadLine()?.ToUpper();
                    Console.Clear();
                    if (respuesta != "S")
                    {
                        continuar = false;
                        Console.WriteLine("\n¡Fin Ejercicio 13!");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                    }
                }
            }
        }
    }
    class Ejercicio14
    {
        public static void Run()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nEjercicio 14. Contador de letras.\n");
                while (true)
                {
                    Console.Write("Ingrese una palabra para contar la cantidad de letras que tiene: ");
                    string? palabra = Console.ReadLine();
                    if (string.IsNullOrEmpty(palabra) || palabra.Any(char.IsDigit))
                    {
                        Console.WriteLine("\nEntrada inválida, no debe estar vacio ni contener números.\n");
                    }
                    else
                    {
                        int cantidadLetras = palabra.Length;
                        Console.WriteLine($"\nLa cantidad de letras en la palabra '{palabra}' es: {cantidadLetras}");
                        break;
                    }
                }

                Console.Write("\nDesea volver a iniciar precione (S/N)");
                string? respuesta = Console.ReadLine()?.ToUpper();
                Console.Clear();
                if (respuesta != "S")
                {
                    continuar = false;
                    Console.WriteLine("\n¡Fin Ejercicio 14!");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
    }
    class Ejercicio15
    {
        public static void Run()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nEjercicio 15. Tabla de multiplicar");
                while (true)
                {

                    Console.Write("\nIngrese un número: ");
                    string? input = Console.ReadLine();
                    if (int.TryParse(input, out int numero))
                    {
                        Console.WriteLine($"\nTabla de multiplicar del {numero}:\n");
                        for (int i = 1; i <= 10; i++)
                        {
                            int resultado = numero * i;
                            Console.WriteLine($"{numero} x {i} = {resultado}");
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                    }
                }

                Console.Write("\nDesea volver a iniciar precione (S/N)");
                string? respuesta = Console.ReadLine()?.ToUpper();
                Console.Clear();
                if (respuesta != "S")
                {
                    continuar = false;
                    Console.WriteLine("¡Fin Ejercicio 15!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
    }
    class Ejercicio16
    {
        public static void Run()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nEjercicio 16. promedio de notas.\n");

                while (true)
                {
                    Console.Write("Ingrese 5 notas");


                    double nota1, nota2, nota3, nota4, nota5;
                    while (true)
                    {
                        Console.Write("\nIngrese Primer Nota: ");
                        string? inputNota1 = Console.ReadLine();

                        if (double.TryParse(inputNota1, out nota1) && nota1 >= 0 && nota1 <= 10)
                            break;
                        else
                        {
                            Console.WriteLine("Nota inválida. Por favor, ingrese una nota entre 0 y 10.");
                        }
                    }
                    while (true)
                    {
                        Console.Write("\nIngrese Segunda Nota: ");
                        string? inputNota2 = Console.ReadLine();

                        if (double.TryParse(inputNota2, out nota2) && nota2 >= 0 && nota2 <= 10)
                            break;
                        else
                        {
                            Console.WriteLine("Nota inválida. Por favor, ingrese una nota entre 0 y 10.");
                        }
                    }
                    while (true)
                    {
                        Console.Write("\nIngrese Tercer Nota: ");
                        string? inputNota3 = Console.ReadLine();
                        if (double.TryParse(inputNota3, out nota3) && nota3 >= 0 && nota3 <= 10)
                            break;
                        else
                        {
                            Console.WriteLine("Nota inválida. Por favor, ingrese una nota entre 0 y 10.");
                        }
                    }
                    while (true)
                    {
                        Console.Write("\nIngrese Cuarta Nota: ");
                        string? inputNota4 = Console.ReadLine();
                        if (double.TryParse(inputNota4, out nota4) && nota4 >= 0 && nota4 <= 10)
                            break;
                        else
                        {
                            Console.WriteLine("Nota inválida. Por favor, ingrese una nota entre 0 y 10.");
                        }
                    }
                    while (true)
                    {
                        Console.Write("\nIngrese Quinta Nota: ");
                        string? inputNota5 = Console.ReadLine();
                        if (double.TryParse(inputNota5, out nota5) && nota5 >= 0 && nota5 <= 10)
                            break;
                        else
                        {
                            Console.WriteLine("Nota inválida. Por favor, ingrese una nota entre 0 y 10.");
                        }
                    }
                    double promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
                    if (promedio >= 6)
                    {
                        Console.WriteLine($"\nEl promedio es: {promedio}. ¡Aprobado!");
                    }
                    else
                    {
                        Console.WriteLine($"\nEl promedio es: {promedio}. ¡Reprobado!");
                    }
                    break;

                }

                Console.Write("\nDesea volver a iniciar precione (S/N)");
                string? respuesta = Console.ReadLine()?.ToUpper();
                Console.Clear();
                if (respuesta != "S")
                {
                    continuar = false;
                    Console.WriteLine("\n¡Fin Ejercicio 16!");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
    }
    class Ejercicio17
    {
        public static void Run()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nEjercicio 17. Contador hasta que sea cero");
                int contador = 0;
                while (true)
                {
                    Console.Write("\nIngrese un número entero (0 para terminar): ");
                    string? input = Console.ReadLine();
                    if (int.TryParse(input, out int numero))
                    {

                        if (numero == 0)
                        {
                            break;

                        }
                        else
                        {
                            contador++;
                        }


                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                    }
                }
                Console.WriteLine($"\nCantidad de números ingresados (excluyendo el cero): {contador}");
                Console.Write("\nDesea volver a iniciar precione (S/N)");
                string? respuesta = Console.ReadLine()?.ToUpper();
                Console.Clear();
                if (respuesta != "S")
                {
                    continuar = false;
                    Console.WriteLine("¡Fin Ejercicio 17!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }

            }
        }
    }
    class Ejercicio18
    {
        public static void Run()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nEjercicio 18. Suma acumulada con condición");
                while (true)
                {
                    int sumaAcumulada = 0;
                    int numIngr = 0;
                    while (sumaAcumulada <= 100)
                    {
                        Console.Write("\nIngrese número entero hasta que la suma supere 100: ");

                        string? input = Console.ReadLine();
                        if (int.TryParse(input, out int numero))
                        {
                            sumaAcumulada += numero;
                            numIngr++;
                            Console.WriteLine($"\nSuma acumulada actual: {sumaAcumulada}");
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nSe ingresaron -{numIngr}- numeros en total y la suma acumulada final es:{sumaAcumulada}.");
                    break;
                }

                {
                    Console.Write("\nDesea volver a iniciar precione (S/N)");
                    string? respuesta = Console.ReadLine()?.ToUpper();
                    Console.Clear();
                    if (respuesta != "S")
                    {
                        continuar = false;
                        Console.WriteLine("¡Fin Ejercicio 18!");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                }
            }
        }
    }
    class Ejercicio19
    {
        public static void Run()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nEjercicio 19. Contador de dígitos");
                while (true)
                {
                    Console.Write("\nIngrese un número: ");
                    string? input = Console.ReadLine();
                    if (int.TryParse(input, out int numero) && numero >= 0)
                    {
                        int contadorDigitos = 0;
                        if (numero == 0)
                        {
                            contadorDigitos = 1;
                        }
                        else
                        {
                            while (numero > 0)
                            {
                                numero /= 10;
                                contadorDigitos++;
                            }
                        }
                        Console.WriteLine($"\nLa cantidad de dígitos es: {contadorDigitos}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero positivo válido.\n");
                    }
                }
                {
                    Console.Write("\nDesea volver a iniciar precione (S/N)");
                    string? respuesta = Console.ReadLine()?.ToUpper();
                    Console.Clear();
                    if (respuesta != "S")
                    {
                        continuar = false;
                        Console.WriteLine("¡Fin Ejercicio 5!");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                }
            }
        }
    }
    class Ejercicio20
    {
        public static void Run()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\nEjercicio 20. Contar vocales.\n");
                while (true)
                {
                    Console.Write("Ingrese una palabra: ");
                    string? palabra = Console.ReadLine();
                    if (!string.IsNullOrEmpty(palabra) && palabra.All(char.IsLetter))
                    {
                        int contadorVocales = 0;
                        foreach (char letra in palabra.ToLower())
                        {
                            if ("aeiou".Contains(letra))
                            {
                                contadorVocales++;
                            }
                        }
                        Console.WriteLine($"\nLa cantidad de vocales en la palabra '{palabra}' es: {contadorVocales}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese una palabra.\n");
                    }
                }
                Console.Write("\nDesea volver a iniciar precione (S/N)");
                string? respuesta = Console.ReadLine()?.ToUpper();
                Console.Clear();
                if (respuesta != "S")
                {
                    continuar = false;
                    Console.WriteLine("\n¡Fin Ejercicio 20!");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
    }
    class Ejercicio21
    {
        public static void Run()
        {
            bool continuar = true;
            decimal saldoInicial = 250000;

            while (continuar)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nEjercicio 21. Mini cajero automático\n");
                Console.WriteLine("╔════════════════════════════════╗");
                Console.WriteLine("║      MINI CAJERO AUTOMÁTICO    ║");
                Console.WriteLine("╠════════════════════════════════╣");
                Console.WriteLine("║ 1. CONSULTAR SALDO             ║");
                Console.WriteLine("║ 2. DEPOSITAR                   ║");
                Console.WriteLine("║ 3. RETIRAR                     ║");
                Console.WriteLine("║ 4. SALIR                       ║");
                Console.WriteLine("╚════════════════════════════════╝");
                Console.Write("\nIngrese una opción (1-4): ");

                string? input = Console.ReadLine();

                if (int.TryParse(input, out int opcion) && opcion >= 1 && opcion <= 4)
                {

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine($"\nSu saldo es: {saldoInicial}");
                            break;
                        case 2:
                            Console.Write("\nIngrese la cantidad a depositar: $");
                            string? depositoInput = Console.ReadLine();
                            if (decimal.TryParse(depositoInput, out decimal deposito) && deposito > 0)
                            {
                                if (deposito < 1)
                                {
                                    Console.WriteLine("La cantidad a depositar debe ser al menos $1.");
                                    break;
                                }
                                saldoInicial += deposito;
                                Console.WriteLine($"\nHa depositado: ${deposito}");
                                Console.WriteLine($"\nSu nuevo saldo es: ${saldoInicial}");
                            }
                            else
                            {
                                Console.WriteLine("Cantidad inválida.");
                            }
                            break;
                        case 3:
                            Console.Write("\nIngrese la cantidad a retirar: $");
                            string? retiroInput = Console.ReadLine();
                            if (decimal.TryParse(retiroInput, out decimal retiro) && retiro > 0)
                            {
                                if (retiro > saldoInicial)
                                {
                                    Console.WriteLine("Fondos insuficientes.");
                                    break;
                                }
                                saldoInicial -= retiro;
                                Console.WriteLine($"\nHa retirado: ${retiro}");
                                Console.WriteLine($"\nSu nuevo saldo es: ${saldoInicial}");
                            }
                            else
                            {
                                Console.WriteLine("Cantidad inválida.");
                            }
                            break;
                        case 4:
                            continuar = false;
                            Console.WriteLine("¡Gracias por usar el cajero automático!");
                            Console.WriteLine("¡Fin Ejercicio 21!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Opción invalida elija entre las 4 opciones.");
                }
                if (!continuar) break;
                {
                    Console.WriteLine("\nPresione cualquier tecla para volver al menu ");
                    Console.ReadKey();
                }
            }
        }
    }
    public static void Main()
    {
        //ghhfgdhjg
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("\n**---TIPOS, CONVERSIONES, OPERADORES Y CONTROL DE FLUJO---**");
            Console.WriteLine("\n1.  Ejercicio 01: Número Positivo, Negativo o Cero.");
            Console.WriteLine("2.  Ejercicio 02: Mayor y Menor de Tres Números Distintos.");
            Console.WriteLine("3.  Ejercicio 03: Múltiplos de un Número.");
            Console.WriteLine("4.  Ejercicio 04: Descuento en Tienda.");
            Console.WriteLine("5.  Ejercicio 05: Conversión de tipo.");
            Console.WriteLine("6.  Ejercicio 06: Clasificación por edad.");
            Console.WriteLine("7.  Ejercicio 07: Número dentro de rango.");
            Console.WriteLine("8.  Ejercicio 08: Operador ternario.");
            Console.WriteLine("9.  Ejercicio 09: Cálculo de impuestos.");
            Console.WriteLine("10. Ejercicio 10: Día de la semana con switch.");
            Console.WriteLine("11. Ejercicio 11: Menú con switch.");
            Console.WriteLine("12. Ejercicio 12: Contador de pares.");
            Console.WriteLine("13. Ejercicio 13: Suma de números impares.");
            Console.WriteLine("14. Ejercicio 14: Contador de letras.");
            Console.WriteLine("15. Ejercicio 15: Tabla de multiplicar.");
            Console.WriteLine("16. Ejercicio 16: Promedio de notas.");
            Console.WriteLine("17. Ejercicio 17: Contador hasta que sea cero.");
            Console.WriteLine("18. Ejercicio 18: Suma acumulada con condición.");
            Console.WriteLine("19. Ejercicio 19: Contador de dígitos.");
            Console.WriteLine("20. Ejercicio 20: Contar vocales.");
            Console.WriteLine("21. Ejercicio 21: Mini cajero automático <<BONUS TRACK>> .");
            Console.WriteLine("\n22. Salir");
            Console.Write("\nSeleccione el ejercicio que desea ejecutar: ");
            string? eleccion = Console.ReadLine();
            switch (eleccion)
            {
                case "1":
                    Console.Clear();
                    Ejercicio01.Run();
                    break;
                case "2":
                    Console.Clear();
                    Ejercicio02.Run();
                    break;
                case "3":
                    Console.Clear();
                    Ejercicio03.Run();
                    break;
                case "4":
                    Console.Clear();
                    Ejercicio04.Run();
                    break;
                case "5":
                    Console.Clear();
                    Ejercicio05.Run();
                    break;
                case "6":
                    Console.Clear();
                    Ejercicio06.Run();
                    break;
                case "7":
                    Console.Clear();
                    Ejercicio07.Run();
                    break;
                case "8":
                    Console.Clear();
                    Ejercicio08.Run();
                    break;
                case "9":
                    Console.Clear();
                    Ejercicio09.Run();
                    break;
                case "10":
                    Console.Clear();
                    Ejercicio10.Run();
                    break;
                case "11":
                    Console.Clear();
                    Ejercicio11.Run();
                    break;
                case "12":
                    Console.Clear();
                    Ejercicio12.Run();
                    break;
                case "13":
                    Console.Clear();
                    Ejercicio13.Run();
                    break;
                case "14":
                    Console.Clear();
                    Ejercicio14.Run();
                    break;
                case "15":
                    Console.Clear();
                    Ejercicio15.Run();
                    break;
                case "16":
                    Console.Clear();
                    Ejercicio16.Run();
                    break;
                case "17":
                    Console.Clear();
                    Ejercicio17.Run();
                    break;
                case "18":
                    Console.Clear();
                    Ejercicio18.Run();
                    break;
                case "19":
                    Console.Clear();
                    Ejercicio19.Run();
                    break;
                case "20":
                    Console.Clear();
                    Ejercicio20.Run();
                    break;
                case "21":
                    Console.Clear();
                    Ejercicio21.Run();
                    break;
                case "22":
                    continuar = false;
                    Console.WriteLine("¡Fin del programa!");
                    Thread.Sleep(1500);
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    Thread.Sleep(1500);
                    Console.Clear();
                    break;
            }
        }
    }
}