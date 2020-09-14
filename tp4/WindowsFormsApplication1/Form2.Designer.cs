namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.grilla = new System.Windows.Forms.DataGridView();
            this.posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.random = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            this.grilla.AllowUserToDeleteRows = false;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.posicion,
            this.random});
            this.grilla.Location = new System.Drawing.Point(58, 11);
            this.grilla.Margin = new System.Windows.Forms.Padding(2);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.RowHeadersWidth = 51;
            this.grilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grilla.RowTemplate.Height = 24;
            this.grilla.Size = new System.Drawing.Size(259, 476);
            this.grilla.TabIndex = 3;
            // 
            // posicion
            // 
            this.posicion.DataPropertyName = "posicion";
            this.posicion.Frozen = true;
            this.posicion.HeaderText = "Posición";
            this.posicion.MinimumWidth = 6;
            this.posicion.Name = "posicion";
            this.posicion.ReadOnly = true;
            this.posicion.Width = 125;
            // 
            // random
            // 
            this.random.DataPropertyName = "random";
            this.random.Frozen = true;
            this.random.HeaderText = "Random";
            this.random.MinimumWidth = 6;
            this.random.Name = "random";
            this.random.ReadOnly = true;
            this.random.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 504);
            this.Controls.Add(this.grilla);
            this.Name = "Form2";
            this.Text = "Ventana de Randoms";
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn random;
    }
}