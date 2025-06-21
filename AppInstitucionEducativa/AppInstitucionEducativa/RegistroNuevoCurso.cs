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
    public partial class RegistroNuevoCurso : Form
    {
        private List<Curso> _listaCursos;
        private List<Profesor> _listaProfesores;
        public RegistroNuevoCurso(List<Curso> cursos, List<Profesor> profesores)
        {
            InitializeComponent();
            _listaCursos = cursos;
            _listaProfesores = profesores;
        }

        public void AgregarCurso(string nombreCurso, string profesorEncargado)
        {
            Profesor profesorEncontrado = _listaProfesores.FirstOrDefault(p => p.Nombre == profesorEncargado);
            if (profesorEncontrado == null)
            {
                MessageBox.Show("Profesor no encontrado");
            }
            else
            {
                Curso nuevoCurso = new Curso(inputNuevoCurso.Text, profesorEncontrado);
            }
        }

        private void btnRegistrarNuevoCurso_Click(object sender, EventArgs e)
        {
            string nuevoCurso = inputNuevoCurso.Text;
            string profesorCurso = inputProfesorNuevoCurso.Text;
            var profesorObj = _listaProfesores.Find(l => l.Nombre.Equals(profesorCurso, StringComparison.OrdinalIgnoreCase));
            if (profesorObj != null)
            {
                MessageBox.Show("Profesor no encontrado");
            }
            else
            {
                Curso nuevoObjCurso = new Curso(nuevoCurso, profesorObj);
                MessageBox.Show("Se ha agregado correctamente el estudiante: " + "\n" + nuevoObjCurso.MostrarInformacion());
                _listaCursos.Add(nuevoObjCurso);
            }
            inputNuevoCurso.Text = "";
            inputProfesorNuevoCurso.Text = "";            
        }
    }
}
