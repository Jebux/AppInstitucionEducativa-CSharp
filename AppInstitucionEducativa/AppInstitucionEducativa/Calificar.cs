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
    public partial class Calificar : Form
    {
        private List<Estudiante> _listaEstudiantes;
        public Calificar(List<Estudiante> listaEstudiantes)
        {
            InitializeComponent();
            _listaEstudiantes = listaEstudiantes;
        }

        private void btnRegistrarCalificacion_Click(object sender, EventArgs e)
        {
            string estudianteInput = inputNombreEstudiante.Text;
            var estudianteObj = _listaEstudiantes.Find(l => l.Nombre.Equals(estudianteInput, StringComparison.OrdinalIgnoreCase));
            decimal notaInput = inputNota.Value;
            if (estudianteObj == null)
            {
                MessageBox.Show("Estudiante no encontrado");
            }
            else
            {
                estudianteObj.Calificar(notaInput);
                MessageBox.Show($"Nota subida");
            }
            inputNombreEstudiante.Text = "";
            inputNota.Value = 0;
        }
    }
}
