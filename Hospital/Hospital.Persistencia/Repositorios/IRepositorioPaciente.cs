
using System.Collections.Generic;
using Hospital.Dominio.Entidades;

namespace Hospital.Persistencia.Repositorios
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();
        Paciente AddPaciente(Paciente paciente);
    }
}
