namespace AppInstitucionEducativa
{
    partial class InscribirCursoEstudiante
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
            btnInscribirEstudianteCurso = new Button();
            inputEstudianteNuevoCurso = new TextBox();
            inputNuevoCurso = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnInscribirEstudianteCurso
            // 
            btnInscribirEstudianteCurso.ForeColor = SystemColors.ActiveCaptionText;
            btnInscribirEstudianteCurso.Location = new Point(408, 264);
            btnInscribirEstudianteCurso.Name = "btnInscribirEstudianteCurso";
            btnInscribirEstudianteCurso.Size = new Size(75, 23);
            btnInscribirEstudianteCurso.TabIndex = 13;
            btnInscribirEstudianteCurso.Text = "Registrar";
            btnInscribirEstudianteCurso.UseVisualStyleBackColor = true;
            // 
            // inputEstudianteNuevoCurso
            // 
            inputEstudianteNuevoCurso.Location = new Point(218, 213);
            inputEstudianteNuevoCurso.Name = "inputEstudianteNuevoCurso";
            inputEstudianteNuevoCurso.Size = new Size(265, 23);
            inputEstudianteNuevoCurso.TabIndex = 12;
            // 
            // inputNuevoCurso
            // 
            inputNuevoCurso.Location = new Point(218, 154);
            inputNuevoCurso.Name = "inputNuevoCurso";
            inputNuevoCurso.Size = new Size(265, 23);
            inputNuevoCurso.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(69, 214);
            label3.Name = "label3";
            label3.Size = new Size(147, 21);
            label3.TabIndex = 10;
            label3.Text = "Nombre Estudiante:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(69, 156);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 9;
            label2.Text = "Nombre del curso:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(20, 34);
            label1.Name = "label1";
            label1.Size = new Size(524, 54);
            label1.TabIndex = 8;
            label1.Text = "Inscripción Curso Estudiante";
            // 
            // InscribirCursoEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 361);
            Controls.Add(btnInscribirEstudianteCurso);
            Controls.Add(inputEstudianteNuevoCurso);
            Controls.Add(inputNuevoCurso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InscribirCursoEstudiante";
            Text = "InscribirCursoEstudiante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInscribirEstudianteCurso;
        private TextBox inputEstudianteNuevoCurso;
        private TextBox inputNuevoCurso;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}