namespace TP7Panaderia
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
            this.txtH = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.txtProductos = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.colMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtT0 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRelHmin = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTiempoCoccionTempMax = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRelHmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTiempoCoccionTempMax)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "h:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(127, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "[h]";
            // 
            // txtH
            // 
            this.txtH.DecimalPlaces = 2;
            this.txtH.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtH.Location = new System.Drawing.Point(76, 15);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(45, 20);
            this.txtH.TabIndex = 15;
            this.txtH.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtProductos
            // 
            this.txtProductos.Location = new System.Drawing.Point(76, 51);
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(45, 20);
            this.txtProductos.TabIndex = 19;
            this.txtProductos.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Productos:";
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMin,
            this.colTiempo,
            this.colTemp,
            this.colDT});
            this.dgvResult.Location = new System.Drawing.Point(12, 91);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(443, 347);
            this.dgvResult.TabIndex = 20;
            // 
            // colMin
            // 
            this.colMin.HeaderText = "Min";
            this.colMin.Name = "colMin";
            // 
            // colTiempo
            // 
            this.colTiempo.HeaderText = "t";
            this.colTiempo.Name = "colTiempo";
            // 
            // colTemp
            // 
            this.colTemp.HeaderText = "T";
            this.colTemp.Name = "colTemp";
            // 
            // colDT
            // 
            this.colDT.HeaderText = "dT/dt";
            this.colDT.Name = "colDT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "[uni]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "[uni]";
            // 
            // txtT0
            // 
            this.txtT0.Location = new System.Drawing.Point(186, 52);
            this.txtT0.Name = "txtT0";
            this.txtT0.Size = new System.Drawing.Size(45, 20);
            this.txtT0.TabIndex = 26;
            this.txtT0.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "T0:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "[h/min]";
            // 
            // txtRelHmin
            // 
            this.txtRelHmin.DecimalPlaces = 2;
            this.txtRelHmin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtRelHmin.Location = new System.Drawing.Point(186, 16);
            this.txtRelHmin.Name = "txtRelHmin";
            this.txtRelHmin.Size = new System.Drawing.Size(45, 20);
            this.txtRelHmin.TabIndex = 23;
            this.txtRelHmin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "rel:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "[h/min]";
            // 
            // txtTiempoCoccionTempMax
            // 
            this.txtTiempoCoccionTempMax.Location = new System.Drawing.Point(366, 14);
            this.txtTiempoCoccionTempMax.Name = "txtTiempoCoccionTempMax";
            this.txtTiempoCoccionTempMax.Size = new System.Drawing.Size(45, 20);
            this.txtTiempoCoccionTempMax.TabIndex = 29;
            this.txtTiempoCoccionTempMax.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Tiempo coccion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(297, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "temp max:";
            // 
            // EcDiferencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTiempoCoccionTempMax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtT0);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRelHmin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.txtProductos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.label1);
            this.Name = "EcDiferencial";
            this.Text = "EcDiferencial";
            ((System.ComponentModel.ISupportInitialize)(this.txtH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRelHmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTiempoCoccionTempMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown txtH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown txtProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtT0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtRelHmin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtTiempoCoccionTempMax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}