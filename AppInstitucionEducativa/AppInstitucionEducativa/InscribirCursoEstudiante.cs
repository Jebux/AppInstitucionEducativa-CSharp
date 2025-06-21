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
    public partial class InscribirCursoEstudiante : Form
    {
        private List<Estudiante> _listaEstudiantes;

        private List<Curso> _listaCursos;
        public InscribirCursoEstudiante(List<Estudiante> listaEstudiantes, List<Curso> cursos)
        {
            InitializeComponent();
            _listaEstudiantes = listaEstudiantes;
            _listaCursos = cursos;
        }

        private void btnInscribirEstudianteCurso_Click(object sender, EventArgs e)
        {
            string nuevoCursoInput = inputNuevoCursoEstudiante.Text;
            var cursoObj = _listaCursos.Find(l => l.NombreCurso.Equals(nuevoCursoInput, StringComparison.OrdinalIgnoreCase));
            string estudianteInput = inputNombreEstudianteNuevoCurso.Text;
            var estudianteObj = _listaEstudiantes.Find(l => l.Nombre.Equals(estudianteInput, StringComparison.OrdinalIgnoreCase));
            if (estudianteObj == null  || cursoObj == null)
            {
                MessageBox.Show("Curso o Estudiante no encontrado");
            }
            else
            {
                cursoObj.AgregarEstudiante(estudianteObj);
                estudianteObj.InscribirCurso(nuevoCursoInput);
                MessageBox.Show($"Estudiante inscrito a {nuevoCursoInput}");
            }
            inputNuevoCursoEstudiante.Text = "";
            inputNombreEstudianteNuevoCurso.Text = "";
        }
    }
}
