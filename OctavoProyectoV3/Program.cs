

int cantidadExamenes = 3;

string[] alumnos = { "Saul", "Enrique", "Ana" };

int[] notasSaul = { 15, 16, 11,20};
int[] notasEnrique = { 10, 12, 11 };
int[] notasAna = { 18, 05, 15 };

int[] notasAlumnos = new int[10];

foreach (string alumno in alumnos)
{
    string alumnoActual = alumno;

    if (alumnoActual == "Saul")
    {
        notasAlumnos = notasSaul;
    }
    else if (alumnoActual == "Enrique")
    {
        notasAlumnos = notasEnrique;
    }
    else if (alumnoActual == "Ana")
    {
        notasAlumnos = notasAna;
    }

    int sumaNotas = 0;
    decimal divisionNotas = 0;
    int gradoAsigando = 0;


    foreach (int nota in notasAlumnos)
    {
        gradoAsigando += 1; //gradoAsignado = gradoAsignado + 1;
        if (gradoAsigando <= cantidadExamenes)
        {
            sumaNotas += nota;
        }
        else
        {
            sumaNotas += nota / 10;   // 20 + 20 + 20 = 60     20/10 = 2    60+2 = 62    62/3 = 20.6
        }
    }


 divisionNotas = (decimal)(sumaNotas) / cantidadExamenes;

    Console.WriteLine($"{alumnoActual}\t\t{divisionNotas}");
}

Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();