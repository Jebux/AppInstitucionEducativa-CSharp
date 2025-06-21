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
    public partial class RegistroNuevoProfesor : Form
    {
        private List<Profesor> _listaProfesores;
        public RegistroNuevoProfesor(List<Profesor> profesores)
        {
            InitializeComponent();
            _listaProfesores = profesores;
        }

        private void btnRegistrarNuevoProfesor_Click(object sender, EventArgs e)
        {
            string nuevoProfesor = inputNuevoProfesor.Text;
            decimal docProfesor = inputDocumentoNuevoProfesor.Value;
            string especialidadProfesor = inputEspecialidadNuevoProfesor.Text;
            Profesor nuevoObjProfesor = new Profesor(nuevoProfesor, docProfesor, especialidadProfesor);
            nuevoObjProfesor.MostrarInformacion();
            _listaProfesores.Add(nuevoObjProfesor);
        }
    }
}
