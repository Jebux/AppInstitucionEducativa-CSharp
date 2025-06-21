namespace AppInstitucionEducativa
{
    partial class Calificar
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
            btnRegistrarCalificacion = new Button();
            inputNombreEstudiante = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            inputNota = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)inputNota).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrarCalificacion
            // 
            btnRegistrarCalificacion.ForeColor = SystemColors.ActiveCaptionText;
            btnRegistrarCalificacion.Location = new Point(408, 247);
            btnRegistrarCalificacion.Name = "btnRegistrarCalificacion";
            btnRegistrarCalificacion.Size = new Size(75, 23);
            btnRegistrarCalificacion.TabIndex = 13;
            btnRegistrarCalificacion.Text = "Registrar";
            btnRegistrarCalificacion.UseVisualStyleBackColor = true;
            btnRegistrarCalificacion.Click += btnRegistrarCalificacion_Click;
            // 
            // inputNombreEstudiante
            // 
            inputNombreEstudiante.Location = new Point(249, 137);
            inputNombreEstudiante.Name = "inputNombreEstudiante";
            inputNombreEstudiante.Size = new Size(234, 23);
            inputNombreEstudiante.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(74, 197);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 10;
            label3.Text = "Calificación:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(74, 139);
            label2.Name = "label2";
            label2.Size = new Size(172, 21);
            label2.TabIndex = 9;
            label2.Text = "Nombre del estudiante:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(74, 22);
            label1.Name = "label1";
            label1.Size = new Size(380, 54);
            label1.TabIndex = 8;
            label1.Text = "Registro Calificación";
            // 
            // inputNota
            // 
            inputNota.Location = new Point(249, 195);
            inputNota.Name = "inputNota";
            inputNota.Size = new Size(234, 23);
            inputNota.TabIndex = 14;
            // 
            // Calificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 361);
            Controls.Add(inputNota);
            Controls.Add(btnRegistrarCalificacion);
            Controls.Add(inputNombreEstudiante);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.Desktop;
            Name = "Calificar";
            Text = "Calificar";
            ((System.ComponentModel.ISupportInitialize)inputNota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarCalificacion;
        private TextBox inputNombreEstudiante;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown inputNota;
    }
}