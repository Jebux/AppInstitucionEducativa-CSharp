using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppInstitucionEducativa
{
    public partial class InformacionCursos : Form
    {
        private List<Estudiante> _listaEstudiantes;
        private List<Curso> _listaCursos;
        private List<Profesor> _listaProfesores;
        public InformacionCursos(List<Estudiante> estudiantes, List<Profesor> profesores, List<Curso> cursos)
        {
            InitializeComponent();
            _listaProfesores = profesores;
            _listaCursos = cursos;
            _listaEstudiantes = estudiantes;
            Informacion();
        }


        public void Informacion()
        {
            var gridProfesores = _listaProfesores.Select(p => new { p.Nombre, p.Documento, p.Especialidad, p.Curso }).ToList();
            var gridCursos = _listaCursos.Select(p => new { p.NombreCurso, Profesor = p.ProfesorEncargado?.Nombre ?? "Sin asignación", CantidadEstudiantes = p.ListaEstudiantes.Count }).ToList();
            profesoresGrid.DataSource = gridProfesores;
            estudiantesGrid.DataSource = _listaEstudiantes;
            cursosGrid.DataSource = gridCursos;

        }

    
    }
}
