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
    public partial class InformacionCursos : Form
    {
        private List<Persona> _listaEstudiantes;
        public InformacionCursos(List<Persona> estudiantes)
        {
            InitializeComponent();
            _listaEstudiantes = estudiantes;

            MostrarEnGrid();

        }


        private void MostrarEnGrid()
        {
            // Convertimos a una lista anónima para que el Grid entienda las propiedades
            var listaVisual = _listaEstudiantes
                .Select(e => new
                {
                    Nombre = e.Nombre,
                    Documento = e.Documento,
                    Grado = (e is Estudiante est) ? est.Grado : "N/A"
                })
                .ToList();

            testingGrid.DataSource = listaVisual;
        }
    }
}
