namespace Hospital.Dominio.Entidades
{
    public class Persona
    {
        public int Id {get; set;} //Id lo reconoce como Primary Key
        public string Nombre {get; set;}
        public string Apellidos {get; set;}
        public string NumeroTelefono {get; set;}
        //Genero de la Persona
        public Genero Genero {get; set;}
    }
}