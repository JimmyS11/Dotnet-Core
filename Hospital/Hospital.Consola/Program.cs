using System;
using System.Collections.Generic;
using Hospital.Dominio.Entidades;
using Hospital.Persistencia.Repositorios;

namespace Hospital.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPaciente();
        }
       private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre="Pepito",
                Apellido="Perez",
                NumeroTelefono="3004568975",
                Direccion="Clle 2 N° 5 - 07",
                Ciudad="Manizales",
                Departamento="Caldas",
                fechaNacimiento= new DateTime(2000,05,20)
            };
            _repoPaciente.AddPaciente(paciente);
        }
    }
}
