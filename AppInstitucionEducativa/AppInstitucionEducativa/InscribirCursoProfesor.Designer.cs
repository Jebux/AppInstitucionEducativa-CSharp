namespace AppInstitucionEducativa
{
    partial class InscribirCursoProfesor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnInscribirProfesorCurso = new Button();
            inputNombreProfesorNuevoCurso = new TextBox();
            inputNombreNuevoCursoProfesor = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnInscribirProfesorCurso
            // 
            btnInscribirProfesorCurso.ForeColor = SystemColors.ActiveCaptionText;
            btnInscribirProfesorCurso.Location = new Point(407, 262);
            btnInscribirProfesorCurso.Name = "btnInscribirProfesorCurso";
            btnInscribirProfesorCurso.Size = new Size(75, 23);
            btnInscribirProfesorCurso.TabIndex = 19;
            btnInscribirProfesorCurso.Text = "Registrar";
            btnInscribirProfesorCurso.UseVisualStyleBackColor = true;
            btnInscribirProfesorCurso.Click += btnInscribirProfesorCurso_Click;
            // 
            // inputNombreProfesorNuevoCurso
            // 
            inputNombreProfesorNuevoCurso.Location = new Point(217, 211);
            inputNombreProfesorNuevoCurso.Name = "inputNombreProfesorNuevoCurso";
            inputNombreProfesorNuevoCurso.Size = new Size(265, 23);
            inputNombreProfesorNuevoCurso.TabIndex = 18;
            // 
            // inputNombreNuevoCursoProfesor
            // 
            inputNombreNuevoCursoProfesor.Location = new Point(217, 152);
            inputNombreNuevoCursoProfesor.Name = "inputNombreNuevoCursoProfesor";
            inputNombreNuevoCursoProfesor.Size = new Size(265, 23);
            inputNombreNuevoCursoProfesor.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(68, 212);
            label3.Name = "label3";
            label3.Size = new Size(134, 21);
            label3.TabIndex = 16;
            label3.Text = "Nombre Profesor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(68, 154);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 15;
            label2.Text = "Nombre del curso:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(40, 32);
            label1.Name = "label1";
            label1.Size = new Size(485, 54);
            label1.TabIndex = 14;
            label1.Text = "Inscripción Curso Profesor";
            // 
            // InscribirCursoProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 361);
            Controls.Add(btnInscribirProfesorCurso);
            Controls.Add(inputNombreProfesorNuevoCurso);
            Controls.Add(inputNombreNuevoCursoProfesor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InscribirCursoProfesor";
            Text = "InscribirCursoProfesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInscribirProfesorCurso;
        private TextBox inputNombreProfesorNuevoCurso;
        private TextBox inputNombreNuevoCursoProfesor;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}