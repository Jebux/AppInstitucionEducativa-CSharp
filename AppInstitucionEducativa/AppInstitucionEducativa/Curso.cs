using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInstitucionEducativa
{
    public class Curso
    {
        public string NombreCurso { get; set; }
        public Profesor ProfesorEncargado {  get; set; }
        public List<Estudiante> ListaEstudiantes { get; set;} 

        public Curso(string nombreCurso, Profesor profesorEncargado) 
        { 
            NombreCurso = nombreCurso;
            ProfesorEncargado = profesorEncargado;
            ListaEstudiantes = new List<Estudiante>();
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            ListaEstudiantes.Add(estudiante);
        }
    }
}
