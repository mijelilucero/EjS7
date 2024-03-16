using System;
using System.Security.Cryptography;

static void ejemplo1() 
{
    int[] calificaciones;
    calificaciones = new int[] { 85, 77, 68, 94, 75 };
    Console.WriteLine(calificaciones[2]);
}

static void ejemplo2()
{
    string[] nombres = new string[3];
    nombres[0] = "Juan";
    nombres[1] = "Ana";
    nombres[2] = "Pedro";

    foreach (string nombre in nombres)
    {
        Console.WriteLine("Nombre: " + nombre);
    }
}


static void promedio()
{
    int[] notas = { 80, 75, 90, 95, 73, 79 };
    int promedio, suma=0;

    foreach(int nota in notas)
    {
        suma += nota;
    }

    promedio = suma / notas.Length;
    Console.WriteLine("El promedio es: " + promedio);


    //Función Sort
    Console.WriteLine("Original:");
    foreach (int nota in notas)
    {
        Console.WriteLine(nota);
    }

    Console.WriteLine("Ordenado:");
    Array.Sort(notas);
    foreach (int nota in notas)
    {
        Console.WriteLine(nota);
    }


    //Ahora con for
    int promedio2, suma2 = 0;

    for (int i = 0; i < notas.Length; i++)
    {
        suma2 += notas[i];
    }

    promedio2 = suma2 / notas.Length;
    Console.WriteLine("El promedio2 es: " + promedio2);

    //Método Exists
    bool aprobados = Array.Exists(notas, nota => nota >= 60);
    Console.WriteLine("Hay aprobados: "+aprobados);

    bool reprobados = Array.Exists(notas, nota => nota < 60);
    Console.WriteLine("Hay reprobados: " + reprobados);
}


static void reversa()
{
    string[] nombres;
    nombres= new string[5] { "Juan", "Ana", "Pedro", "Monica", "Andrea" };

    string[] nombres2 = new string[nombres.Length];

    for(int i=nombres.Length-1; i>=0; i--)
    {
        for (int h=0; h < nombres.Length; i++)
        {
            nombres[i] = nombres2[h];
        }
    }

    foreach (string nombre in nombres2)
    {
        Console.WriteLine(nombre);
    }

}

reversa();
