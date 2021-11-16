using System;
using System.Collections.Generic;
using Hospital.Dominio;
using Hospital.Persistencia;

namespace Hospital.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente();
        static void Main(string[] args)
        {
            Console.WriteLine("Resultado de la Consulta: ");
            //AddPaciente();
            MostrarPacientes();
        }
        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Pepito",
                Apellidos = "Perez",
                NumeroTelefono = "4568975",
                Genero = Genero.Otro,
                Direccion = "Clle 2 N° 5 - 07",
                Ciudad = "Manizales",
                Departamento = "Caldas",
                fechaNacimiento= new DateTime(2000,05,20)
            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void MostrarPacientes()
        {
            IEnumerable<Paciente> pacientes = _repoPaciente.GetAllPacientes();
            foreach (var paciente in pacientes)
            {
                Console.WriteLine(paciente.Nombre+" "+paciente.Apellidos);
            }
        }
    }
}
