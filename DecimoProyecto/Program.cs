
int numeroExamenes = 3;

string[] nombredeAlumnos = { "Saul", "Luas", "Ana" };

int[] notadeSaul = { 15, 20, 18, 20 };
int[] notadeLuas = { 17, 10, 16 };
int[] notadeAna = { 05, 03, 13 };

int[] notasAlumno = new int[10];
string calificacionLetra = "";

foreach (string alumnos in nombredeAlumnos)
{
    string alumnoActual = alumnos;

    if (alumnoActual == "Saul")
    {
        notasAlumno = notadeSaul;
    }
    else if (alumnoActual == "Luas")
    {
        notasAlumno = notadeLuas;
    }
    else if (alumnoActual == "Ana")
    {
        notasAlumno = notadeAna;
    }

    int sumaNotas = 0;
    decimal divisionNotas = 0;
    int contadorExamenes = 0;

    foreach (int nota in notasAlumno)
    {
        contadorExamenes += 1;
        if (contadorExamenes <= numeroExamenes)
        {
            sumaNotas += nota;
        }
        else
        {
            sumaNotas += nota / 10;
        }

    }
    divisionNotas = (decimal)sumaNotas / numeroExamenes;

    if (divisionNotas >= 18)
    {
        calificacionLetra = "A+";
    }
    else if (divisionNotas >= 13)
    {
        calificacionLetra = "B+";
    }
    else
    {
        calificacionLetra = "C+";
    }
    Console.WriteLine($"{alumnoActual}\t\t{divisionNotas}\t\t{calificacionLetra}");
}