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
            estudiantesGrid = new DataGridView();
            profesoresGrid = new DataGridView();
            cursosGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)estudiantesGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profesoresGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cursosGrid).BeginInit();
            SuspendLayout();
            // 
            // estudiantesGrid
            // 
            estudiantesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            estudiantesGrid.Location = new Point(35, 27);
            estudiantesGrid.Name = "estudiantesGrid";
            estudiantesGrid.Size = new Size(240, 150);
            estudiantesGrid.TabIndex = 0;
            // 
            // profesoresGrid
            // 
            profesoresGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            profesoresGrid.Location = new Point(294, 126);
            profesoresGrid.Name = "profesoresGrid";
            profesoresGrid.Size = new Size(240, 150);
            profesoresGrid.TabIndex = 1;
            // 
            // cursosGrid
            // 
            cursosGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cursosGrid.Location = new Point(35, 199);
            cursosGrid.Name = "cursosGrid";
            cursosGrid.Size = new Size(240, 150);
            cursosGrid.TabIndex = 2;
            // 
            // InformacionCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 361);
            Controls.Add(cursosGrid);
            Controls.Add(profesoresGrid);
            Controls.Add(estudiantesGrid);
            Name = "InformacionCursos";
            Text = "InformacionCursos";
            ((System.ComponentModel.ISupportInitialize)estudiantesGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)profesoresGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)cursosGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView estudiantesGrid;
        private DataGridView profesoresGrid;
        private DataGridView cursosGrid;
    }
}