// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

String ruta1;
String ruta2;

//Ejercicio1
/*
Console.WriteLine("Introduzca ruta del archivo 1: ");
ruta1 = Console.ReadLine();
Console.WriteLine("Indroduzca ruta del archivo 2: ");
ruta2 = Console.ReadLine();

File.WriteAllText(ruta2, File.ReadAllText(ruta1));

ruta1 = "";
ruta2 = "";

Console.WriteLine("Se ha volcado el texto correctamente");
*/

//Ejercicio2
/*
Console.WriteLine("Introduzca ruta del archivo: ");
ruta1 = Console.ReadLine();

Console.WriteLine("Indroduzca frase a buscar: ");
String frase = Console.ReadLine();

String[] listaLineas = File.ReadAllLines(ruta1);

for (int i = 0; i < listaLineas.Length; i++) {
    if (listaLineas[i].Contains(frase))
    {
        if (Regex.IsMatch(frase, @"^.*" + frase + ".*$"))
        {
            Console.WriteLine($"LINEA: {i + 1}, FRASE: {listaLineas[i]}");
        }
    } 
}

ruta1 = "";
*/

//Ejercicio3
/*
Console.WriteLine("Introduzca ruta del archivo 1: ");
ruta1 = Console.ReadLine();
Console.WriteLine("Indroduzca ruta del archivo 2: ");
ruta2 = Console.ReadLine();

File.Copy(ruta1, ruta2, true);

ruta1 = "";
ruta2 = "";

Console.WriteLine("Se ha copiado el archivo correctamente");
*/

//Ejercicio4
/*
Console.WriteLine("Introduzca ruta del archivo: ");
ruta1 = Console.ReadLine();

String[] listaAlumnos = File.ReadAllLines(ruta1);

String mejorAlumno = "";
int mejorNota = 0;
int nota;
int mediaMates = 0;
foreach (var alumno in listaAlumnos)
{
    String[] listaNotas = alumno.Split(" ");

    for (int i = 1; i < listaNotas.Length; i++)
    {
        nota = Int16.Parse(listaNotas[i]);

        if (i == 1) {
            mediaMates += nota;
        }

        if (nota > mejorNota && i == 2) { 
            mejorNota = nota;
            mejorAlumno = listaNotas[0];
        }

    }

}

mediaMates = mediaMates / listaAlumnos.Length;

Console.WriteLine("Introduzca ruta del archivo resultado: ");
ruta2 = Console.ReadLine();

File.WriteAllText(ruta2, $"MEDIA MATEMÁTICAS: {mediaMates}\nMEJOR ALUMNO DE INFORMÁTICA: " +
    $"\n\t - Nombre: {mejorAlumno} \n\t - Nota: {mejorNota}");

ruta1 = "";
ruta2 = "";
*/

//Ejercicio5
/*
Console.WriteLine("Introduzca ruta del archivo 1: ");
ruta1 = Console.ReadLine();
Console.WriteLine("Indroduzca ruta del archivo 2: ");
ruta2 = Console.ReadLine();

using (StreamWriter sw = new StreamWriter(Path.Combine(Path.GetDirectoryName(ruta1), "union.txt"), false))
{
    String[] lista1 = File.ReadAllLines(ruta1);
    String[] lista2 = File.ReadAllLines(ruta2);

    for (int i = 0, j = 0; i < lista1.Length || j < lista2.Length;) {
        
        if (i < lista1.Length) {
            sw.WriteLine(lista1[i]);
            i++;
        }
        if (j < lista2.Length) {
            sw.WriteLine(lista2[j]);
            j++;
        }
    
    }

}

ruta1 = "";
ruta2 = "";
*/

//Ejercicio6 C:\Users\Dam\Desktop\enteros.txt

