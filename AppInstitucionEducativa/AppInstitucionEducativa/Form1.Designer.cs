namespace AppInstitucionEducativa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button8 = new Button();
            btnCalificar = new Button();
            panelInscribirBtns = new Panel();
            button6 = new Button();
            button7 = new Button();
            btnInscribir = new Button();
            panelRegistrarBtns = new Panel();
            btnNuevoCurso = new Button();
            btnNuevoProfesor = new Button();
            btnNuevoEstudiante = new Button();
            btnRegistrar = new Button();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            mainPanel = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panelInscribirBtns.SuspendLayout();
            panelRegistrarBtns.SuspendLayout();
            panel2.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 111, 140);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(btnCalificar);
            panel1.Controls.Add(panelInscribirBtns);
            panel1.Controls.Add(btnInscribir);
            panel1.Controls.Add(panelRegistrarBtns);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(182, 393);
            panel1.TabIndex = 0;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(28, 72, 89);
            button8.Dock = DockStyle.Top;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.Transparent;
            button8.Location = new Point(0, 397);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Size = new Size(182, 40);
            button8.TabIndex = 7;
            button8.Text = "INFORMACIÓN CURSOS";
            button8.UseVisualStyleBackColor = false;
            button8.Click += btnInformacionCursos_Click;
            // 
            // btnCalificar
            // 
            btnCalificar.BackColor = Color.FromArgb(28, 72, 89);
            btnCalificar.Dock = DockStyle.Top;
            btnCalificar.FlatAppearance.BorderSize = 0;
            btnCalificar.FlatStyle = FlatStyle.Flat;
            btnCalificar.ForeColor = Color.Transparent;
            btnCalificar.Location = new Point(0, 357);
            btnCalificar.Margin = new Padding(0);
            btnCalificar.Name = "btnCalificar";
            btnCalificar.Size = new Size(182, 40);
            btnCalificar.TabIndex = 6;
            btnCalificar.Text = "CALIFICAR";
            btnCalificar.UseVisualStyleBackColor = false;
            btnCalificar.Click += btnCalificar_Click;
            // 
            // panelInscribirBtns
            // 
            panelInscribirBtns.Controls.Add(button6);
            panelInscribirBtns.Controls.Add(button7);
            panelInscribirBtns.Dock = DockStyle.Top;
            panelInscribirBtns.Location = new Point(0, 275);
            panelInscribirBtns.Name = "panelInscribirBtns";
            panelInscribirBtns.Size = new Size(182, 82);
            panelInscribirBtns.TabIndex = 5;
            panelInscribirBtns.Visible = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(187, 226, 242);
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.Black;
            button6.Location = new Point(0, 40);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(182, 42);
            button6.TabIndex = 3;
            button6.Text = "  Inscribir Profesor a Curso";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            button6.Click += btnInscribirProfesor_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(187, 226, 242);
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.Black;
            button7.Location = new Point(0, 0);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(182, 40);
            button7.TabIndex = 2;
            button7.Text = "  Inscribir Estudiante a Curso";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            button7.Click += btnInscribirEstudiante_Click;
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = Color.FromArgb(28, 72, 89);
            btnInscribir.Dock = DockStyle.Top;
            btnInscribir.FlatAppearance.BorderSize = 0;
            btnInscribir.FlatStyle = FlatStyle.Flat;
            btnInscribir.ForeColor = Color.Transparent;
            btnInscribir.Location = new Point(0, 235);
            btnInscribir.Margin = new Padding(0);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(182, 40);
            btnInscribir.TabIndex = 3;
            btnInscribir.Text = "INSCRIBIR";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // panelRegistrarBtns
            // 
            panelRegistrarBtns.Controls.Add(btnNuevoCurso);
            panelRegistrarBtns.Controls.Add(btnNuevoProfesor);
            panelRegistrarBtns.Controls.Add(btnNuevoEstudiante);
            panelRegistrarBtns.Dock = DockStyle.Top;
            panelRegistrarBtns.Location = new Point(0, 113);
            panelRegistrarBtns.Name = "panelRegistrarBtns";
            panelRegistrarBtns.Size = new Size(182, 122);
            panelRegistrarBtns.TabIndex = 2;
            panelRegistrarBtns.Visible = false;
            // 
            // btnNuevoCurso
            // 
            btnNuevoCurso.BackColor = Color.FromArgb(187, 226, 242);
            btnNuevoCurso.Dock = DockStyle.Top;
            btnNuevoCurso.FlatAppearance.BorderSize = 0;
            btnNuevoCurso.FlatStyle = FlatStyle.Flat;
            btnNuevoCurso.ForeColor = Color.Black;
            btnNuevoCurso.Location = new Point(0, 80);
            btnNuevoCurso.Margin = new Padding(0);
            btnNuevoCurso.Name = "btnNuevoCurso";
            btnNuevoCurso.Size = new Size(182, 42);
            btnNuevoCurso.TabIndex = 4;
            btnNuevoCurso.Text = "   Curso";
            btnNuevoCurso.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevoCurso.UseVisualStyleBackColor = false;
            btnNuevoCurso.Click += btnNuevoCurso_Click;
            // 
            // btnNuevoProfesor
            // 
            btnNuevoProfesor.BackColor = Color.FromArgb(187, 226, 242);
            btnNuevoProfesor.Dock = DockStyle.Top;
            btnNuevoProfesor.FlatAppearance.BorderSize = 0;
            btnNuevoProfesor.FlatStyle = FlatStyle.Flat;
            btnNuevoProfesor.ForeColor = Color.Black;
            btnNuevoProfesor.Location = new Point(0, 40);
            btnNuevoProfesor.Margin = new Padding(0);
            btnNuevoProfesor.Name = "btnNuevoProfesor";
            btnNuevoProfesor.Size = new Size(182, 40);
            btnNuevoProfesor.TabIndex = 3;
            btnNuevoProfesor.Text = "   Profesor";
            btnNuevoProfesor.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevoProfesor.UseVisualStyleBackColor = false;
            btnNuevoProfesor.Click += btnNuevoProfesor_Click;
            // 
            // btnNuevoEstudiante
            // 
            btnNuevoEstudiante.BackColor = Color.FromArgb(187, 226, 242);
            btnNuevoEstudiante.Dock = DockStyle.Top;
            btnNuevoEstudiante.FlatAppearance.BorderSize = 0;
            btnNuevoEstudiante.FlatStyle = FlatStyle.Flat;
            btnNuevoEstudiante.ForeColor = Color.Black;
            btnNuevoEstudiante.Location = new Point(0, 0);
            btnNuevoEstudiante.Margin = new Padding(0);
            btnNuevoEstudiante.Name = "btnNuevoEstudiante";
            btnNuevoEstudiante.Size = new Size(182, 40);
            btnNuevoEstudiante.TabIndex = 2;
            btnNuevoEstudiante.Text = "   Estudiante";
            btnNuevoEstudiante.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevoEstudiante.UseVisualStyleBackColor = false;
            btnNuevoEstudiante.Click += btnNuevoEstudiante_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(28, 72, 89);
            btnRegistrar.Dock = DockStyle.Top;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.ForeColor = Color.Transparent;
            btnRegistrar.Location = new Point(0, 73);
            btnRegistrar.Margin = new Padding(0);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(182, 40);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Enabled = false;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(182, 73);
            label2.TabIndex = 0;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(11, 30, 38);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(754, 76);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(164, 9);
            label1.Name = "label1";
            label1.Size = new Size(423, 54);
            label1.TabIndex = 0;
            label1.Text = "Institución Educativa X";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.WhiteSmoke;
            mainPanel.Controls.Add(label3);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(182, 76);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(572, 393);
            mainPanel.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(144, 162);
            label3.Name = "label3";
            label3.Size = new Size(320, 37);
            label3.TabIndex = 0;
            label3.Text = "Bienvenido a la App";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 84);
            ClientSize = new Size(754, 469);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = Color.FromArgb(224, 224, 224);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panelInscribirBtns.ResumeLayout(false);
            panelRegistrarBtns.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel mainPanel;
        private Label label1;
        private Label label2;
        private Button btnRegistrar;
        private Panel panelRegistrarBtns;
        private Button btnNuevoCurso;
        private Button btnNuevoProfesor;
        private Button btnNuevoEstudiante;
        private Button btnInscribir;
        private Panel panelInscribirBtns;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button btnCalificar;
        private Label label3;
    }
}
