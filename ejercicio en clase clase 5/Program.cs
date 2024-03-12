static void MayorMenor()
{
    int num = 0;
    int max = int.MinValue;
    int min = int.MaxValue;
    do
    {
        Console.WriteLine("\nIngrese un numero");
        num = Convert.ToInt32(Console.ReadLine());
        if (num != 0)
        {
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }

    } while (num != 0);
    Console.WriteLine("\nel numero mayor es: "+max);
    Console.WriteLine("el numero menor es: "+min);

}

static void AdivinaNumero()
{
    Console.WriteLine("Piensa en un numero y escribelo:");
    int numero = int.Parse(Console.ReadLine());

    Console.WriteLine("\nahora sigue los siguentes pasos:" +
        "\n1. Multiplica el numero por 2." +
        "\n2. Sumale 8 al resultado de la multiplicacion." +
        "\n3. Ahora multiplicalo de nuevo el resultado por 5.");

    numero *= 2;

    numero += 8;

    numero *= 5;

    Console.WriteLine("\nPor favor, introduce el resultado final:");
    int resultado = int.Parse(Console.ReadLine());

    resultado /= 10;

    resultado -= 4;

    Console.WriteLine($"El número en el que pensaste es: {resultado}");

}

static void ContadorPalabras()
{
    Console.Write("\nIngresa una frase que deseas analizar: ");
    string frase = Console.ReadLine();

    int contadorPalabras = 0;
    int contadorVocales = 0;

    string[] palabras = frase.Split(' ');
    int indicePalabra = 0;

    while (indicePalabra < palabras.Length)
    {
        contadorPalabras++;

        string palabra = palabras[indicePalabra];
        int indiceLetra = 0;

        while (indiceLetra < palabra.Length)
        {
            char letra = char.ToLower(palabra[indiceLetra]);
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                contadorVocales++;
            }

            indiceLetra++;
        }

        indicePalabra++;
    }

    Console.WriteLine($"El número de palabras es {contadorPalabras}");
    Console.WriteLine($"El número de vocales es {contadorVocales}");
}

static void palindromo()
{
    Console.WriteLine("\nIngresa la palabra");
    string palabra = Console.ReadLine();
    string revez = "";

    for (int i = palabra.Length - 1; i >= 0; i--)
    {
        revez += palabra[i];
    }
    if (palabra.Equals(revez, StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine($"La palabra '{palabra}' es un palindromo.");
    }
    else
    {
        Console.WriteLine($"La palabra '{palabra}' no es un palindromo.");
    }

}

int opc;

do
{
    Console.WriteLine("\n1. Cual es el numero mayor y cual es el menor: ");
    Console.WriteLine("2. Adivina el Numero: ");
    Console.WriteLine("3. Contador de palabras");
    Console.WriteLine("4. Palindromo:");
    Console.WriteLine("precione 0 para salir del programa");

    opc = Convert.ToInt32(Console.ReadLine());

    switch (opc)
    {
        case 1:
            MayorMenor();
            break;

        case 2:
            AdivinaNumero();
            break;

        case 3:
            ContadorPalabras();
            break;

        case 4:
            palindromo();
            break;
        
        case 0:
            Console.WriteLine("saliendo...");
            return;
    }
} while (true);