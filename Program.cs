using System;

// Clase principal que contiene el método Main
class Program
{
    static void Main()
    {
        GestorAlumnos gestor = new GestorAlumnos(); // Crear una instancia del gestor de alumnos
        string opcion; // Variable para almacenar la opción seleccionada por el usuario

        // Bucle para mostrar el menú y ejecutar las opciones
        do
        {
            Console.WriteLine("\n--- Gestión de Alumnos ---");
            Console.WriteLine("1. Agregar Alumno");
            Console.WriteLine("2. Eliminar Alumno");
            Console.WriteLine("3. Consultar Alumno");
            Console.WriteLine("4. Modificar Nota");
            Console.WriteLine("5. Mostrar Alumnos Suspensos");
            Console.WriteLine("6. Mostrar Alumnos Aprobados");
            Console.WriteLine("7. Mostrar Candidatos a Matrícula de Honor");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Console.ReadLine(); // Leer la opción del usuario

            // Ejecutar la opción seleccionada
            switch (opcion)
            {
                case "1":
                    gestor.AgregarAlumno(); // Agregar un nuevo alumno
                    break;
                case "2":
                    gestor.EliminarAlumno(); // Eliminar un alumno
                    break;
                case "3":
                    gestor.ConsultarAlumno(); // Consultar un alumno
                    break;
                case "4":
                    gestor.ModificarNota(); // Modificar la nota de un alumno
                    break;
                case "5":
                    gestor.MostrarAlumnosSuspensos(); // Mostrar alumnos suspensos
                    break;
                case "6":
                    gestor.MostrarAlumnosAprobados(); // Mostrar alumnos aprobados
                    break;
                case "7":
                    gestor.MostrarCandidatosMH(); // Mostrar candidatos a Matrícula de Honor
                    break;
                case "0":
                    Console.WriteLine("Saliendo del programa..."); // Mensaje de salida
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo."); // Mensaje de opción no válida
                    break;
            }

        } while (opcion != "0"); // Repetir hasta que el usuario elija salir
    }
}