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
        private List<Profesor> _listaProfesores;
        private List<Curso> _listaCursos;
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

            profesoresGrid.DataSource = gridProfesores;
            estudiantesGrid.DataSource = _listaEstudiantes;
            cursosGrid.DataSource = _listaCursos;
        }
        
    }
}
