namespace PizzeriaTP5
{
    partial class EulerForm
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
            this.dataGridViewEuler = new System.Windows.Forms.DataGridView();
            this.colT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDerivada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEuler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEuler
            // 
            this.dataGridViewEuler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEuler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colT,
            this.colC,
            this.colDerivada});
            this.dataGridViewEuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEuler.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEuler.Name = "dataGridViewEuler";
            this.dataGridViewEuler.Size = new System.Drawing.Size(334, 450);
            this.dataGridViewEuler.TabIndex = 0;
            // 
            // colT
            // 
            this.colT.HeaderText = "t [min]";
            this.colT.Name = "colT";
            // 
            // colC
            // 
            this.colC.HeaderText = "C";
            this.colC.Name = "colC";
            // 
            // colDerivada
            // 
            this.colDerivada.HeaderText = "dC/dt";
            this.colDerivada.Name = "colDerivada";
            // 
            // EulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.dataGridViewEuler);
            this.Name = "EulerForm";
            this.Text = "Euler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEuler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn colT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDerivada;
    }
}