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
            testingGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)testingGrid).BeginInit();
            SuspendLayout();
            // 
            // testingGrid
            // 
            testingGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            testingGrid.Location = new Point(166, 113);
            testingGrid.Name = "testingGrid";
            testingGrid.Size = new Size(240, 150);
            testingGrid.TabIndex = 0;
            // 
            // InformacionCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 361);
            Controls.Add(testingGrid);
            Name = "InformacionCursos";
            Text = "InformacionCursos";
            Load += InformacionCursos_Load;
            ((System.ComponentModel.ISupportInitialize)testingGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView testingGrid;
    }
}