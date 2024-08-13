// Clase que representa a un alumno
public class Alumno
{
    // Propiedades del alumno
    public string DNI { get; set; }
    public string Apellidos { get; set; }
    public string Nombre { get; set; }
    public double Nota { get; set; }

    // Propiedad calculada que devuelve la calificación basada en la nota
    public string Calificacion => CalcularCalificacion();

    // Constructor de la clase Alumno
    public Alumno(string dni, string apellidos, string nombre, double nota)
    {
        DNI = dni;
        Apellidos = apellidos;
        Nombre = nombre;
        Nota = nota;
    }

    // Método privado que calcula la calificación basada en la nota
    private string CalcularCalificacion()
    {
        if (Nota < 5) return "SS"; // Suspenso
        else if (Nota < 7) return "AP"; // Aprobado
        else if (Nota < 9) return "NT"; // Notable
        else return "SB"; // Sobresaliente
    }

    // Método que devuelve una representación en formato de cadena del alumno
    public override string ToString()
    {
        return $"{DNI} {Apellidos}, {Nombre} {Nota} {Calificacion}";
    }
}