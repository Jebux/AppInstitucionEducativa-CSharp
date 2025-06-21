namespace AppInstitucionEducativa
{
    partial class RegistroNuevoProfesor
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
            inputNuevoProfesor = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnRegistrarNuevoProfesor = new Button();
            inputEspecialidadNuevoProfesor = new TextBox();
            label5 = new Label();
            inputDocumentoNuevoProfesor = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)inputDocumentoNuevoProfesor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(509, 54);
            label1.TabIndex = 1;
            label1.Text = "Registro Nuevos Profesores";
            // 
            // inputNuevoProfesor
            // 
            inputNuevoProfesor.Location = new Point(218, 114);
            inputNuevoProfesor.Name = "inputNuevoProfesor";
            inputNuevoProfesor.Size = new Size(265, 23);
            inputNuevoProfesor.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(74, 155);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 9;
            label3.Text = "Documento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(74, 116);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 8;
            label2.Text = "Nombre Profesor:";
            // 
            // btnRegistrarNuevoProfesor
            // 
            btnRegistrarNuevoProfesor.ForeColor = SystemColors.ActiveCaptionText;
            btnRegistrarNuevoProfesor.Location = new Point(408, 258);
            btnRegistrarNuevoProfesor.Name = "btnRegistrarNuevoProfesor";
            btnRegistrarNuevoProfesor.Size = new Size(75, 23);
            btnRegistrarNuevoProfesor.TabIndex = 17;
            btnRegistrarNuevoProfesor.Text = "Registrar";
            btnRegistrarNuevoProfesor.UseVisualStyleBackColor = true;
            btnRegistrarNuevoProfesor.Click += btnRegistrarNuevoProfesor_Click;
            // 
            // inputEspecialidadNuevoProfesor
            // 
            inputEspecialidadNuevoProfesor.Location = new Point(218, 196);
            inputEspecialidadNuevoProfesor.Name = "inputEspecialidadNuevoProfesor";
            inputEspecialidadNuevoProfesor.Size = new Size(265, 23);
            inputEspecialidadNuevoProfesor.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(74, 198);
            label5.Name = "label5";
            label5.Size = new Size(98, 21);
            label5.TabIndex = 13;
            label5.Text = "Especialidad:";
            // 
            // inputDocumentoNuevoProfesor
            // 
            inputDocumentoNuevoProfesor.Location = new Point(218, 153);
            inputDocumentoNuevoProfesor.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            inputDocumentoNuevoProfesor.Name = "inputDocumentoNuevoProfesor";
            inputDocumentoNuevoProfesor.Size = new Size(265, 23);
            inputDocumentoNuevoProfesor.TabIndex = 18;
            // 
            // RegistroNuevoProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 361);
            Controls.Add(inputDocumentoNuevoProfesor);
            Controls.Add(btnRegistrarNuevoProfesor);
            Controls.Add(inputEspecialidadNuevoProfesor);
            Controls.Add(label5);
            Controls.Add(inputNuevoProfesor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistroNuevoProfesor";
            Text = "RegistroNuevoProfesor";
            ((System.ComponentModel.ISupportInitialize)inputDocumentoNuevoProfesor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputNuevoProfesor;
        private Label label3;
        private Label label2;
        private Button btnRegistrarNuevoProfesor;
        private TextBox inputEspecialidadNuevoProfesor;
        private Label label5;
        private NumericUpDown inputDocumentoNuevoProfesor;
    }
}