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
        
    }
}
