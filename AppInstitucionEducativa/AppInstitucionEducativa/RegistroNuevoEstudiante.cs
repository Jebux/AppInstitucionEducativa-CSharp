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
    public partial class RegistroNuevoEstudiante : Form
    {
        private List<Estudiante> _listaEstudiantes;
        public RegistroNuevoEstudiante(List<Estudiante> estudiantes)
        {
            InitializeComponent();
            _listaEstudiantes = estudiantes;
        }

        private void btnRegistrarEstudiante_Click(object sender, EventArgs e)
        {
            string nuevoEstudiante = inputNuevoEstudiante.Text;
            decimal docEstudiante = inputDocumentoEstudiante.Value;
            string gradoEstudiante = inputGradoEstudiante.Text;
            Estudiante nuevoObjEstudiante = new Estudiante(nuevoEstudiante,docEstudiante,gradoEstudiante);
            MessageBox.Show("Se ha agregado correctamente el estudiante: "+ "\n" + nuevoObjEstudiante.MostrarInformacion());
            _listaEstudiantes.Add(nuevoObjEstudiante);
            inputNuevoEstudiante.Text = "";
            inputDocumentoEstudiante.Value = 0;
            inputGradoEstudiante.Text = "";
        }
    }
}
