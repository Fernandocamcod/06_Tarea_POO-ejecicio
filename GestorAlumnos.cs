using System;
using System.Collections.Generic;

// Clase que gestiona la lista de alumnos
public class GestorAlumnos
{
    // Lista para almacenar los alumnos
    private List<Alumno> alumnos = new List<Alumno>();

    // Método para agregar un nuevo alumno
    public void AgregarAlumno()
    {
        Console.WriteLine("Ingrese DNI:");
        string dni = Console.ReadLine();

        // Verificar si ya existe un alumno con el mismo DNI
        if (alumnos.Exists(a => a.DNI == dni))
        {
            Console.WriteLine("Ya existe un alumno con ese DNI.");
            return; // Salir del método si el DNI ya existe
        }

        // Solicitar los datos del nuevo alumno
        Console.WriteLine("Ingrese Apellidos:");
        string apellidos = Console.ReadLine();
        Console.WriteLine("Ingrese Nombre:");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingrese Nota:");
        double nota = Convert.ToDouble(Console.ReadLine());

        // Agregar el nuevo alumno a la lista
        alumnos.Add(new Alumno(dni, apellidos, nombre, nota));
        Console.WriteLine("Alumno agregado con éxito.");
    }

    // Método para eliminar un alumno por DNI
    public void EliminarAlumno()
    {
        Console.WriteLine("Ingrese DNI del alumno a eliminar:");
        string dni = Console.ReadLine();
        Alumno alumno = alumnos.Find(a => a.DNI == dni); // Buscar el alumno por DNI

        // Verificar si se encontró el alumno
        if (alumno != null)
        {
            alumnos.Remove(alumno); // Eliminar el alumno de la lista
            Console.WriteLine("Alumno eliminado con éxito.");
        }
        else
        {
            Console.WriteLine("Alumno no encontrado.");
        }
    }

    // Método para consultar un alumno por DNI
    public void ConsultarAlumno()
    {
        Console.WriteLine("Ingrese DNI del alumno:");
        string dni = Console.ReadLine();
        Alumno alumno = alumnos.Find(a => a.DNI == dni); // Buscar el alumno por DNI

        // Mostrar la información del alumno si fue encontrado
        if (alumno != null)
        {
            Console.WriteLine(alumno);
        }
        else
        {
            Console.WriteLine("Alumno no encontrado.");
        }
    }

    // Método para modificar la nota de un alumno
    public void ModificarNota()
    {
        Console.WriteLine("Ingrese DNI del alumno:");
        string dni = Console.ReadLine();
        Alumno alumno = alumnos.Find(a => a.DNI == dni); // Buscar el alumno por DNI

        // Verificar si se encontró el alumno
        if (alumno != null)
        {
            Console.WriteLine("Ingrese nueva Nota:");
            alumno.Nota = Convert.ToDouble(Console.ReadLine()); // Modificar la nota
            Console.WriteLine("Nota modificada con éxito.");
        }
        else
        {
            Console.WriteLine("Alumno no encontrado.");
        }
    }

    // Método para mostrar alumnos suspensos
    public void MostrarAlumnosSuspensos()
    {
        Console.WriteLine("Alumnos suspensos:");
        foreach (var alumno in alumnos) // Iterar sobre la lista de alumnos
        {
            if (alumno.Nota < 5) // Verificar si la nota es menor que 5
            {
                Console.WriteLine(alumno); // Mostrar el alumno
            }
        }
    }

    // Método para mostrar alumnos aprobados
    public void MostrarAlumnosAprobados()
    {
        Console.WriteLine("Alumnos aprobados:");
        foreach (var alumno in alumnos) // Iterar sobre la lista de alumnos
        {
            if (alumno.Nota >= 5) // Verificar si la nota es mayor o igual a 5
            {
                Console.WriteLine(alumno); // Mostrar el alumno
            }
        }
    }

    // Método para mostrar candidatos a Matrícula de Honor
    public void MostrarCandidatosMH()
    {
        Console.WriteLine("Candidatos a Matrícula de Honor:");
        foreach (var alumno in alumnos) // Iterar sobre la lista de alumnos
        {
            if (alumno.Nota == 10) // Verificar si la nota es 10
            {
                Console.WriteLine(alumno); // Mostrar el alumno
            }
        }
    }
}