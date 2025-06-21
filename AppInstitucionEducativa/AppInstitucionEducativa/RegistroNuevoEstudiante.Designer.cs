namespace AppInstitucionEducativa
{
    partial class RegistroNuevoEstudiante
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
            inputNuevoEstudiante = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            inputGradoEstudiante = new TextBox();
            inputDocumentoEstudiante = new NumericUpDown();
            btnRegistrarEstudiante = new Button();
            ((System.ComponentModel.ISupportInitialize)inputDocumentoEstudiante).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(527, 54);
            label1.TabIndex = 0;
            label1.Text = "Registro Nuevos Estudiantes";
            // 
            // inputNuevoEstudiante
            // 
            inputNuevoEstudiante.Location = new Point(240, 112);
            inputNuevoEstudiante.Name = "inputNuevoEstudiante";
            inputNuevoEstudiante.Size = new Size(256, 23);
            inputNuevoEstudiante.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(81, 113);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(81, 156);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 4;
            label3.Text = "Documento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(81, 202);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 6;
            label4.Text = "Grado:";
            // 
            // inputGradoEstudiante
            // 
            inputGradoEstudiante.Location = new Point(240, 201);
            inputGradoEstudiante.Name = "inputGradoEstudiante";
            inputGradoEstudiante.Size = new Size(256, 23);
            inputGradoEstudiante.TabIndex = 5;
            // 
            // inputDocumentoEstudiante
            // 
            inputDocumentoEstudiante.Location = new Point(240, 154);
            inputDocumentoEstudiante.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            inputDocumentoEstudiante.Name = "inputDocumentoEstudiante";
            inputDocumentoEstudiante.Size = new Size(256, 23);
            inputDocumentoEstudiante.TabIndex = 7;
            // 
            // btnRegistrarEstudiante
            // 
            btnRegistrarEstudiante.ForeColor = SystemColors.Desktop;
            btnRegistrarEstudiante.Location = new Point(421, 246);
            btnRegistrarEstudiante.Name = "btnRegistrarEstudiante";
            btnRegistrarEstudiante.Size = new Size(75, 23);
            btnRegistrarEstudiante.TabIndex = 8;
            btnRegistrarEstudiante.Text = "Registrar";
            btnRegistrarEstudiante.UseVisualStyleBackColor = true;
            btnRegistrarEstudiante.Click += btnRegistrarEstudiante_Click;
            // 
            // RegistroNuevoEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 361);
            Controls.Add(btnRegistrarEstudiante);
            Controls.Add(inputDocumentoEstudiante);
            Controls.Add(label4);
            Controls.Add(inputGradoEstudiante);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(inputNuevoEstudiante);
            Controls.Add(label1);
            Name = "RegistroNuevoEstudiante";
            Text = "RegistroNuevoEstudiante";
            ((System.ComponentModel.ISupportInitialize)inputDocumentoEstudiante).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputNuevoEstudiante;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox inputGradoEstudiante;
        private NumericUpDown inputDocumentoEstudiante;
        private Button btnRegistrarEstudiante;
    }
}