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
            // RegistroNuevoProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 361);
            Controls.Add(label1);
            Name = "RegistroNuevoProfesor";
            Text = "RegistroNuevoProfesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}