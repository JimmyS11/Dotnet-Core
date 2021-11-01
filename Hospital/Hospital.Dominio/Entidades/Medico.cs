namespace Hospital.Dominio.Entidades
{
    /// <summary> Class <c>Medico</c>
    /// Moldea un médico del equipo de apoyo
    /// </summary>
    public class Medico : Persona
    {
        public string Especialidad {get; set;}
        public string Codigo {get; set;}
        public string RegistroMedico {get; set;}
    }
}