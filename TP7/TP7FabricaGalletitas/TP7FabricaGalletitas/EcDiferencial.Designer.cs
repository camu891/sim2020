namespace TP7FabricaGalletitas
{
    partial class EcDiferencial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtHDescarga = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.txtToneladas = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.colT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDx1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDx2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtHDescarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToneladas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "h";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(136, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "[hs]";
            // 
            // txtHDescarga
            // 
            this.txtHDescarga.DecimalPlaces = 2;
            this.txtHDescarga.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtHDescarga.Location = new System.Drawing.Point(85, 14);
            this.txtHDescarga.Name = "txtHDescarga";
            this.txtHDescarga.Size = new System.Drawing.Size(45, 20);
            this.txtHDescarga.TabIndex = 15;
            this.txtHDescarga.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtToneladas
            // 
            this.txtToneladas.Location = new System.Drawing.Point(85, 50);
            this.txtToneladas.Name = "txtToneladas";
            this.txtToneladas.Size = new System.Drawing.Size(45, 20);
            this.txtToneladas.TabIndex = 19;
            this.txtToneladas.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Toneladas";
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colT,
            this.colX1,
            this.colDx1,
            this.colDx2});
            this.dgvResult.Location = new System.Drawing.Point(12, 91);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(443, 347);
            this.dgvResult.TabIndex = 20;
            // 
            // colT
            // 
            this.colT.HeaderText = "T";
            this.colT.Name = "colT";
            // 
            // colX1
            // 
            this.colX1.HeaderText = "X1";
            this.colX1.Name = "colX1";
            // 
            // colDx1
            // 
            this.colDx1.HeaderText = "Dx1=x2";
            this.colDx1.Name = "colDx1";
            // 
            // colDx2
            // 
            this.colDx2.HeaderText = "Dx2";
            this.colDx2.Name = "colDx2";
            // 
            // EcDiferencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.txtToneladas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtHDescarga);
            this.Controls.Add(this.label1);
            this.Name = "EcDiferencial";
            this.Text = "EcDiferencial";
            ((System.ComponentModel.ISupportInitialize)(this.txtHDescarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToneladas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown txtHDescarga;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown txtToneladas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDx1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDx2;
    }
}