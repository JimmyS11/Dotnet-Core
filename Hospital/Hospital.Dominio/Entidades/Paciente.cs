using System;
using System.Collections.Generic;

namespace Hospital.Dominio
{
    public class Paciente: Persona
    {
        public string Direccion {get; set;}
        public string Ciudad {get; set;}
        public string Departamento {get; set;}
        public DateTime fechaNacimiento {get; set;}
        public Medico Medico {get; set;}
        public Enfermera Enfermera {get; set;}
        public List<SignoVital> SignosVitales {get; set;}
        }
}