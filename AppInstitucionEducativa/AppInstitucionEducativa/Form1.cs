namespace AppInstitucionEducativa
{
    public partial class Form1 : Form
    {
        public List<Profesor> profesores = new List<Profesor>();

        public List<Estudiante> estudiantes = new List<Estudiante>();

        public List<Curso> cursos = new List<Curso>();

        public Form1()
        {
            InitializeComponent();

            profesores.Add(new Profesor("profesor1", 1095936475, "Matematicas"));
            profesores.Add(new Profesor("profesor2", 1095936475, "Lenguaje"));
            profesores.Add(new Profesor("profesor3", 1095936475, "Ciencias"));

            estudiantes.Add(new Estudiante("estudiante1", 1095465123, "Décimo"));
            estudiantes.Add(new Estudiante("estudiante2", 1095465123, "Undécimo"));
            estudiantes.Add(new Estudiante("estudiante3", 1095465123, "Octavo"));

            cursos.Add(new Curso("Matematicas"));
            cursos.Add(new Curso("Programación"));

        }

        
        

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (panelRegistrarBtns.Visible
            )
            {
                panelRegistrarBtns.Visible = false;
            }
            else
            {
                panelRegistrarBtns.Visible = true;
                panelInscribirBtns.Visible = false;
            }
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if (panelInscribirBtns.Visible
            )
            {
                panelInscribirBtns.Visible = false;
            }
            else
            {
                panelInscribirBtns.Visible = true;
                panelRegistrarBtns.Visible = false;

            }
        }

        public void loadform(Form formToLoad)
        {

            if (mainPanel.Controls.Count > 0)
            {
                Control control = mainPanel.Controls[0];
                if (control is Form oldForm)
                {
                    oldForm.Close();
                    oldForm.Dispose();
                }
                mainPanel.Controls.Remove(control);
            }

            formToLoad.TopLevel = false;
            formToLoad.FormBorderStyle = FormBorderStyle.None;
            formToLoad.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(formToLoad);
            mainPanel.Tag = formToLoad;
            formToLoad.Show();
        }

        private void btnNuevoEstudiante_Click(object sender, EventArgs e)
        {
            loadform(new RegistroNuevoEstudiante(estudiantes));
        }

        private void btnNuevoProfesor_Click(object sender, EventArgs e)
        {
            loadform(new RegistroNuevoProfesor(profesores));
        }

        private void btnNuevoCurso_Click(object sender, EventArgs e)
        {
            loadform(new RegistroNuevoCurso(cursos, profesores));
        }

        private void btnInformacionCursos_Click(object sender, EventArgs e)
        {
            loadform(new InformacionCursos(estudiantes, profesores, cursos));
        }

        private void btnInscribirEstudiante_Click(object sender, EventArgs e)
        {
            loadform(new InscribirCursoEstudiante(estudiantes, cursos));
        }
        private void btnInscribirProfesor_Click(object sender, EventArgs e)
        {
            loadform(new InscribirCursoProfesor(profesores, cursos));
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            loadform(new Calificar(estudiantes));
        }
    }
}
