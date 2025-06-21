namespace AppInstitucionEducativa
{
    partial class RegistroNuevoCurso
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            inputNuevoCurso = new TextBox();
            inputProfesorNuevoCurso = new TextBox();
            btnRegistrarNuevoCurso = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(76, 18);
            label1.Name = "label1";
            label1.Size = new Size(409, 54);
            label1.TabIndex = 2;
            label1.Text = "Registro Nuevo Curso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(76, 135);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 3;
            label2.Text = "Nombre del curso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(76, 193);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 4;
            label3.Text = "Profesor a cargo:";
            // 
            // inputNuevoCurso
            // 
            inputNuevoCurso.Location = new Point(220, 133);
            inputNuevoCurso.Name = "inputNuevoCurso";
            inputNuevoCurso.Size = new Size(265, 23);
            inputNuevoCurso.TabIndex = 5;
            // 
            // inputProfesorNuevoCurso
            // 
            inputProfesorNuevoCurso.Location = new Point(220, 191);
            inputProfesorNuevoCurso.Name = "inputProfesorNuevoCurso";
            inputProfesorNuevoCurso.Size = new Size(265, 23);
            inputProfesorNuevoCurso.TabIndex = 6;
            // 
            // btnRegistrarNuevoCurso
            // 
            btnRegistrarNuevoCurso.ForeColor = SystemColors.ActiveCaptionText;
            btnRegistrarNuevoCurso.Location = new Point(410, 243);
            btnRegistrarNuevoCurso.Name = "btnRegistrarNuevoCurso";
            btnRegistrarNuevoCurso.Size = new Size(75, 23);
            btnRegistrarNuevoCurso.TabIndex = 7;
            btnRegistrarNuevoCurso.Text = "Registrar";
            btnRegistrarNuevoCurso.UseVisualStyleBackColor = true;
            btnRegistrarNuevoCurso.Click += btnRegistrarNuevoCurso_Click;
            // 
            // RegistroNuevoCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 361);
            Controls.Add(btnRegistrarNuevoCurso);
            Controls.Add(inputProfesorNuevoCurso);
            Controls.Add(inputNuevoCurso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistroNuevoCurso";
            Text = "RegistroNuevoCurso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox inputNuevoCurso;
        private TextBox inputProfesorNuevoCurso;
        private Button btnRegistrarNuevoCurso;
    }
}