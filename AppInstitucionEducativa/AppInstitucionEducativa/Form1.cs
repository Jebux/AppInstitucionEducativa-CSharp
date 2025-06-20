namespace AppInstitucionEducativa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Persona> integrantes = new List<Persona>(); 
        private void label2_Click(object sender, EventArgs e)
        {

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
                var oldForm = mainPanel.Controls[0] as Form;
                oldForm?.Close();
                oldForm?.Dispose();
                mainPanel.Controls.RemoveAt(0);
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
            loadform(new RegistroNuevoEstudiante(integrantes));
        }

        private void btnNuevoProfesor_Click(object sender, EventArgs e)
        {
            loadform(new RegistroNuevoProfesor());
        }

        private void btnNuevoCurso_Click(object sender, EventArgs e)
        {
            loadform(new RegistroNuevoCurso());
        }
    }
}
