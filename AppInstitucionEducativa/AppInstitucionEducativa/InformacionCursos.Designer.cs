namespace AppInstitucionEducativa
{
    partial class InformacionCursos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            profesoresGrid = new DataGridView();
            cursosGrid = new DataGridView();
            tabControl1 = new TabControl();
            tabCursos = new TabPage();
            tabPage2 = new TabPage();
            estudiantesGrid = new DataGridView();
            tabPage1 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)profesoresGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosGrid).BeginInit();
            tabControl1.SuspendLayout();
            tabCursos.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)estudiantesGrid).BeginInit();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // profesoresGrid
            // 
            profesoresGrid.BackgroundColor = Color.White;
            profesoresGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            profesoresGrid.GridColor = SystemColors.InfoText;
            profesoresGrid.Location = new Point(6, 6);
            profesoresGrid.Name = "profesoresGrid";
            profesoresGrid.Size = new Size(414, 289);
            profesoresGrid.TabIndex = 1;
            // 
            // cursosGrid
            // 
            cursosGrid.BackgroundColor = Color.White;
            cursosGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cursosGrid.GridColor = SystemColors.InfoText;
            cursosGrid.Location = new Point(6, 6);
            cursosGrid.Name = "cursosGrid";
            cursosGrid.Size = new Size(414, 289);
            cursosGrid.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCursos);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(60, 20);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(434, 329);
            tabControl1.TabIndex = 3;
            // 
            // tabCursos
            // 
            tabCursos.Controls.Add(cursosGrid);
            tabCursos.Location = new Point(4, 24);
            tabCursos.Name = "tabCursos";
            tabCursos.Padding = new Padding(3);
            tabCursos.Size = new Size(426, 301);
            tabCursos.TabIndex = 0;
            tabCursos.Text = "Cursos";
            tabCursos.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(estudiantesGrid);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(426, 301);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Listado Estudiantes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // estudiantesGrid
            // 
            estudiantesGrid.BackgroundColor = Color.White;
            estudiantesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            estudiantesGrid.DefaultCellStyle = dataGridViewCellStyle1;
            estudiantesGrid.Location = new Point(6, 6);
            estudiantesGrid.Name = "estudiantesGrid";
            estudiantesGrid.Size = new Size(414, 250);
            estudiantesGrid.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(profesoresGrid);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(426, 301);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "ListadoProfesores";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // InformacionCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 361);
            Controls.Add(tabControl1);
            ForeColor = SystemColors.Desktop;
            Name = "InformacionCursos";
            Text = "InformacionCursos";
            ((System.ComponentModel.ISupportInitialize)profesoresGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosGrid).EndInit();
            tabControl1.ResumeLayout(false);
            tabCursos.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)estudiantesGrid).EndInit();
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView profesoresGrid;
        private DataGridView cursosGrid;
        private TabControl tabControl1;
        private TabPage tabCursos;
        private TabPage tabPage2;
        private DataGridView estudiantesGrid;
        private TabPage tabPage1;
    }
}