using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInstitucionEducativa
{
    interface IEvaluable
    {
        void Calificar(decimal nota);
    }
    public class Estudiante:Persona, IEvaluable
    {
        public string Grado { get; set; }
        public List<string> Curso { get; set; }

        public decimal Nota { get; set; }

        public Estudiante(string nombre, decimal documento, string grado):base(nombre,documento)
        {
            Grado = grado;
            Curso = new List<string>();
            Nota = 0;
        }

        public override string MostrarInformacion()
        {
            return ($"Nombre: {Nombre}" +
                $"\nDocumento: {Documento}" +
                $"\nGrado: {Grado}");
        }

        public void InscribirCurso(string curso)
        {
            Curso.Add(curso);
        }

        public void Calificar(decimal nota)
        {
            Nota = nota;
        }
    }
}
