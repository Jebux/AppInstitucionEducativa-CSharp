using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInstitucionEducativa
{
    public class Profesor : Persona
    {
        public string Especialidad { get; set; }
        public string Curso { get; set; }

        public Profesor(string nombre, decimal documento, string especialidad) : base(nombre, documento)
        {
            Especialidad = especialidad;
            Curso = null;
        }

        public override void MostrarInformacion()
        {
            MessageBox.Show($"Nombre: {Nombre}" +
                $"\nDocumento: {Documento}" +
                $"\nGrado: {Especialidad}");
        }

        public void AsignarCurso(string curso)
        {
            Curso = curso;
        }
    }
}
