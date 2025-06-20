using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInstitucionEducativa
{
    public class Estudiante:Persona
    {
        public string Grado { get; set; }
        public string Curso { get; set; }

        public Estudiante(string nombre, decimal documento, string grado):base(nombre,documento)
        {
            Grado = grado;
            Curso = null;
        }

        public override void MostrarInformacion()
        {
            MessageBox.Show($"Nombre: {Nombre}" +
                $"\nDocumento: {Documento}" +
                $"\nGrado: {Grado}");
        }

        public void InscribirCurso(string curso)
        {
            Curso = curso;
        }
    }
}
