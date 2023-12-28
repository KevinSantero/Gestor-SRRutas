// See https://aka.ms/new-console-template for more information

int[] listaDeNumeros = [10, 20, 30, 1, 6, 25, 22, 23, 15, 18, 19, 15, 14];

Console.WriteLine("Numeros");
Console.WriteLine(string.Join(", ", listaDeNumeros));
Console.WriteLine();

Console.WriteLine("la media aritmética seria: " + GetMedia(listaDeNumeros));
Console.WriteLine();
Console.WriteLine("la media armonica seria: " + GetMediaArmonica(listaDeNumeros));
Console.WriteLine();

Console.WriteLine("Agente A ");
ImprimirEscalera(4);
Console.WriteLine();


Console.WriteLine("Agente B ");
ImprimirEscaleraInvertida(4);

Console.WriteLine("Agente C ");
ImprimirEscaleraConCentro(4);


Console.Write("Ingrese el tamaño de la escalera (n): ");
int n = Convert.ToInt32(Console.ReadLine());

// Verificar las restricciones
if (n <= 0 || n >= 100)
{
    Console.WriteLine("El tamaño de la escalera debe estar en el rango 0 < n < 100.");
    return;
}

// Imprimir la escalera con el centro alineado
ImprimirEscaleraConCentro(n);


//Metodos 
double GetMedia(int[] listaNumeros) {
    int suma = 0;

    for (int i = 0; i < listaNumeros.Length; i++)
        suma += listaNumeros[i];

  return  suma / listaNumeros.Length;
}

double GetMediaArmonica(int[] listaNumeros)
{
    double sumaReciproca = 0;

    for (int i = 0; i < listaNumeros.Length; i++)
        sumaReciproca += 1.0 / listaNumeros[i];

    return listaNumeros.Length / sumaReciproca;
}


 void ImprimirEscalera(int n)
{
    for (int i = 1; i <= n; i++)
    {
        // Imprimir espacios en blanco
        for (int j = 0; j < n - i; j++)
        {
            Console.Write(" ");
        }

        // Imprimir símbolos #
        for (int k = 0; k < i; k++)
        {
            Console.Write("#");
        }

        // Ir a la siguiente línea después de imprimir la fila
        Console.WriteLine();
    }
}


static void ImprimirEscaleraInvertida(int n)
{
    for (int i = n; i >= 1; i--)
    {
        // Imprimir espacios en blanco
        for (int j = 0; j < n - i; j++)
        {
            Console.Write(" ");
        }

        // Imprimir símbolos #
        for (int k = 0; k < i; k++)
        {
            Console.Write("#");
        }

        // Ir a la siguiente línea después de imprimir la fila
        Console.WriteLine();
    }
}


static void ImprimirEscaleraConCentro(int base1)
{
   
    int x, y;

    Console.WriteLine();

    for (x = 0; x < base1 - 1; x++)
    {
        Console.Write(" ");
    }
    for (x = 0; x < base1; x++)
    {
        Console.Write( "#");
    }

    for (y = 1; y < base1 - 1; y++)
    {
        Console.WriteLine(" ");
        for (x = 0; x < base1 - y - 1; x++)
        {
            Console.Write("+");
        }
        Console.Write("#");
        for (x = 0; x < base1 + 2 * y - 2; x++)
        {
            Console.Write("#");
        }
        Console.Write("#");
    }
   

    for (y = base1; y > 1; y--)
    {
        Console.WriteLine(" ");
        for (x = 0; x < base1 - y; x++)
        {
            Console.Write(" ");
        }
        Console.Write("#");

        for (x = 0; x < base1 + 2 * y - 4; x++)
        {
            Console.Write("#");
        }
        Console.Write("#");
    }

    Console.WriteLine(" ");
    for (x = 0; x < base1 - 1; x++)
    {
        Console.Write(" ");
    }
    for (x = 0; x < base1; x++)
    {
        Console.Write("*");
    }
    Console.WriteLine(" ");

}
