namespace Hospital.Dominio
{
    ///<summary>Class <c>Enfermera></c>
    /// Modela una persona del personal de enfermeria del equipo médico de apoyo
    ///</summary>

    public class Enfermera : Persona
    {
        public string TarjetaProfesional {get; set;}
        public int HorasLaborables {get; set;}
    }
}