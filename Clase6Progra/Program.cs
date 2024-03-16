using System.Diagnostics.CodeAnalysis;

static void ejemplo2()
{
    string[] nombres = new string[3];
    nombres[0] = "juan";
    nombres[1] = "Ana";
    nombres[2] = "Pedro";
    foreach (string nombre in nombres)
    {
        Console.WriteLine("Nombre="+nombre);
    }
}

static void promedio()
{
    int[] notas = { 80, 75, 90, 95, 73, 79 };
    int promedio=0;
    int suma = 0;
    foreach (int nota in notas)
    {
        suma=suma+nota;
    }
    for (int i=0; i<notas.Length; i++)
    {
        Console.WriteLine($"Calificacion {i + 1}: {notas[i]}");
    }
    Console.WriteLine("promedio= " + (suma / notas.Length));
}

static void ejemplo3()
{
    int[] calificaciones = { 85, 92, 77, 68, 94 };
    bool hayAprobados = Array.Exists(calificaciones, calif => calif >= 60);
    Console.WriteLine(hayAprobados);
}

static void ejemplo4()
{
    string[] nombres = { "Juan", "Ana", "Tulio", "Maria", "Pedro" };
    Array.Reverse(nombres);
    foreach (string nombre in nombres)
    {
        Console.WriteLine(nombre);
    }
}

ejemplo4();