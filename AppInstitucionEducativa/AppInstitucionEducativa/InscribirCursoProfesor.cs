using System;
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
    public partial class InscribirCursoProfesor : Form
    {
        private List<Profesor> _listaProfesores;

        private List<Curso> _listaCursos;
        public InscribirCursoProfesor(List<Profesor> profesores, List<Curso> cursos)
        {
            InitializeComponent();
            _listaProfesores = profesores;
            _listaCursos = cursos;
        }

        private void btnInscribirProfesorCurso_Click(object sender, EventArgs e)
        {
            string nuevoCursoInput = inputNombreNuevoCursoProfesor.Text;
            var cursoObj = _listaCursos.Find(l => l.NombreCurso.Equals(nuevoCursoInput, StringComparison.OrdinalIgnoreCase));
            string profesorInput = inputNombreProfesorNuevoCurso.Text;
            var profesorObj = _listaProfesores.Find(l => l.Nombre.Equals(profesorInput, StringComparison.OrdinalIgnoreCase));
            if (profesorObj == null || cursoObj == null)
            {
                MessageBox.Show("Curso o Profesor no encontrado");
            }
            else
            {
                cursoObj.CambiarProfesor(profesorObj);
                profesorObj.AsignarCurso(nuevoCursoInput);
                MessageBox.Show($"Profesor asignado a {nuevoCursoInput}");
            }
            inputNombreNuevoCursoProfesor.Text = "";
            inputNombreProfesorNuevoCurso.Text = "";
        }
    }
}
