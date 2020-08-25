namespace simulacion_tp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblRuta = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.chrGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnHistograma = new System.Windows.Forms.Button();
            this.cmbIntervalo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvTablaFecuencia = new System.Windows.Forms.DataGridView();
            this.Inf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDistribucion = new System.Windows.Forms.ComboBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabChi = new System.Windows.Forms.TabPage();
            this.dgvChi = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabKS = new System.Windows.Forms.TabPage();
            this.dgvKs = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtVarianza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.salidaPrueba = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTabulado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalculado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chrGrafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaFecuencia)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabChi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).BeginInit();
            this.tabKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(396, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(54, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(15, 24);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(33, 13);
            this.lblRuta.TabIndex = 1;
            this.lblRuta.Text = "Ruta:";
            // 
            // txtRuta
            // 
            this.txtRuta.Enabled = false;
            this.txtRuta.Location = new System.Drawing.Point(69, 21);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(315, 20);
            this.txtRuta.TabIndex = 2;
            // 
            // chrGrafico
            // 
            chartArea3.Name = "ChartArea1";
            this.chrGrafico.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chrGrafico.Legends.Add(legend3);
            this.chrGrafico.Location = new System.Drawing.Point(463, 87);
            this.chrGrafico.Name = "chrGrafico";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chrGrafico.Series.Add(series3);
            this.chrGrafico.Size = new System.Drawing.Size(543, 218);
            this.chrGrafico.TabIndex = 3;
            this.chrGrafico.Text = "chart1";
            this.chrGrafico.Visible = false;
            // 
            // btnHistograma
            // 
            this.btnHistograma.Location = new System.Drawing.Point(180, 57);
            this.btnHistograma.Name = "btnHistograma";
            this.btnHistograma.Size = new System.Drawing.Size(82, 24);
            this.btnHistograma.TabIndex = 6;
            this.btnHistograma.Text = "Histograma";
            this.btnHistograma.UseVisualStyleBackColor = true;
            this.btnHistograma.Click += new System.EventHandler(this.btnHistograma_Click);
            // 
            // cmbIntervalo
            // 
            this.cmbIntervalo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIntervalo.FormattingEnabled = true;
            this.cmbIntervalo.Location = new System.Drawing.Point(69, 58);
            this.cmbIntervalo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIntervalo.Name = "cmbIntervalo";
            this.cmbIntervalo.Size = new System.Drawing.Size(92, 21);
            this.cmbIntervalo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Intervalos:";
            // 
            // dgvTablaFecuencia
            // 
            this.dgvTablaFecuencia.AllowUserToAddRows = false;
            this.dgvTablaFecuencia.AllowUserToDeleteRows = false;
            this.dgvTablaFecuencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaFecuencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Inf,
            this.Sup,
            this.Fo});
            this.dgvTablaFecuencia.Location = new System.Drawing.Point(9, 87);
            this.dgvTablaFecuencia.Name = "dgvTablaFecuencia";
            this.dgvTablaFecuencia.RowHeadersWidth = 62;
            this.dgvTablaFecuencia.Size = new System.Drawing.Size(441, 184);
            this.dgvTablaFecuencia.TabIndex = 7;
            // 
            // Inf
            // 
            this.Inf.DataPropertyName = "Inf";
            this.Inf.HeaderText = "Intervalo Inferior";
            this.Inf.MinimumWidth = 8;
            this.Inf.Name = "Inf";
            this.Inf.Width = 150;
            // 
            // Sup
            // 
            this.Sup.DataPropertyName = "Sup";
            this.Sup.HeaderText = "Intervalo Superior";
            this.Sup.MinimumWidth = 8;
            this.Sup.Name = "Sup";
            this.Sup.Width = 150;
            // 
            // Fo
            // 
            this.Fo.DataPropertyName = "Fo";
            this.Fo.HeaderText = "FO";
            this.Fo.MinimumWidth = 8;
            this.Fo.Name = "Fo";
            this.Fo.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 286);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Distribución:";
            // 
            // cmbDistribucion
            // 
            this.cmbDistribucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistribucion.FormattingEnabled = true;
            this.cmbDistribucion.Location = new System.Drawing.Point(75, 284);
            this.cmbDistribucion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDistribucion.Name = "cmbDistribucion";
            this.cmbDistribucion.Size = new System.Drawing.Size(102, 21);
            this.cmbDistribucion.TabIndex = 9;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(194, 278);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(94, 32);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "Realizar Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabChi);
            this.tabControl1.Controls.Add(this.tabKS);
            this.tabControl1.Location = new System.Drawing.Point(9, 314);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(997, 248);
            this.tabControl1.TabIndex = 11;
            // 
            // tabChi
            // 
            this.tabChi.Controls.Add(this.dgvChi);
            this.tabChi.Location = new System.Drawing.Point(4, 22);
            this.tabChi.Margin = new System.Windows.Forms.Padding(2);
            this.tabChi.Name = "tabChi";
            this.tabChi.Padding = new System.Windows.Forms.Padding(2);
            this.tabChi.Size = new System.Drawing.Size(989, 222);
            this.tabChi.TabIndex = 0;
            this.tabChi.Text = "Chi Cuadrado";
            this.tabChi.UseVisualStyleBackColor = true;
            // 
            // dgvChi
            // 
            this.dgvChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column10,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dgvChi.Location = new System.Drawing.Point(10, 0);
            this.dgvChi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvChi.Name = "dgvChi";
            this.dgvChi.RowHeadersWidth = 62;
            this.dgvChi.RowTemplate.Height = 28;
            this.dgvChi.Size = new System.Drawing.Size(983, 226);
            this.dgvChi.TabIndex = 0;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Inf";
            this.Column11.HeaderText = "Intervalo Inf";
            this.Column11.MinimumWidth = 8;
            this.Column11.Name = "Column11";
            this.Column11.Width = 150;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Sup";
            this.Column10.HeaderText = "Intervalo Sup";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.Width = 150;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Fo";
            this.Column12.HeaderText = "FO";
            this.Column12.MinimumWidth = 8;
            this.Column12.Name = "Column12";
            this.Column12.Width = 150;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Fe";
            this.Column13.HeaderText = "FE";
            this.Column13.MinimumWidth = 8;
            this.Column13.Name = "Column13";
            this.Column13.Width = 150;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "C";
            this.Column14.HeaderText = "C";
            this.Column14.MinimumWidth = 8;
            this.Column14.Name = "Column14";
            this.Column14.Width = 150;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "Ca";
            this.Column15.HeaderText = "CA";
            this.Column15.MinimumWidth = 8;
            this.Column15.Name = "Column15";
            this.Column15.Width = 150;
            // 
            // tabKS
            // 
            this.tabKS.Controls.Add(this.dgvKs);
            this.tabKS.Location = new System.Drawing.Point(4, 22);
            this.tabKS.Margin = new System.Windows.Forms.Padding(2);
            this.tabKS.Name = "tabKS";
            this.tabKS.Padding = new System.Windows.Forms.Padding(2);
            this.tabKS.Size = new System.Drawing.Size(989, 222);
            this.tabKS.TabIndex = 1;
            this.tabKS.Text = "Kolgomorov Smirnof";
            this.tabKS.UseVisualStyleBackColor = true;
            // 
            // dgvKs
            // 
            this.dgvKs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column8,
            this.Column9,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvKs.Location = new System.Drawing.Point(5, 9);
            this.dgvKs.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKs.Name = "dgvKs";
            this.dgvKs.RowHeadersWidth = 62;
            this.dgvKs.RowTemplate.Height = 28;
            this.dgvKs.Size = new System.Drawing.Size(980, 209);
            this.dgvKs.TabIndex = 1;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Inf";
            this.Column2.HeaderText = "Intervalo Inferior";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Sup";
            this.Column1.HeaderText = "Intervalo Superior";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Fo";
            this.Column3.HeaderText = "Fo";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Fe";
            this.Column4.HeaderText = "Fe";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Po";
            this.Column8.HeaderText = "Po";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Pe";
            this.Column9.HeaderText = "Pe";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PAo";
            this.Column5.HeaderText = "PoA";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "PAe";
            this.Column6.HeaderText = "PeA";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "KS";
            this.Column7.HeaderText = "KS";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(93, 581);
            this.txtMedia.Margin = new System.Windows.Forms.Padding(2);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.ReadOnly = true;
            this.txtMedia.Size = new System.Drawing.Size(68, 20);
            this.txtMedia.TabIndex = 12;
            // 
            // txtVarianza
            // 
            this.txtVarianza.Location = new System.Drawing.Point(93, 621);
            this.txtVarianza.Margin = new System.Windows.Forms.Padding(2);
            this.txtVarianza.Name = "txtVarianza";
            this.txtVarianza.ReadOnly = true;
            this.txtVarianza.Size = new System.Drawing.Size(68, 20);
            this.txtVarianza.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 581);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Media:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 621);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Varianza:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.salidaPrueba);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(249, 567);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 187);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // salidaPrueba
            // 
            this.salidaPrueba.AutoSize = true;
            this.salidaPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salidaPrueba.Location = new System.Drawing.Point(33, 35);
            this.salidaPrueba.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.salidaPrueba.Name = "salidaPrueba";
            this.salidaPrueba.Size = new System.Drawing.Size(15, 20);
            this.salidaPrueba.TabIndex = 19;
            this.salidaPrueba.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 696);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tabulado:";
            this.label5.Visible = false;
            // 
            // txtTabulado
            // 
            this.txtTabulado.Location = new System.Drawing.Point(89, 694);
            this.txtTabulado.Margin = new System.Windows.Forms.Padding(2);
            this.txtTabulado.Name = "txtTabulado";
            this.txtTabulado.ReadOnly = true;
            this.txtTabulado.Size = new System.Drawing.Size(68, 20);
            this.txtTabulado.TabIndex = 17;
            this.txtTabulado.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 666);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Calculado:";
            this.label4.Visible = false;
            // 
            // txtCalculado
            // 
            this.txtCalculado.Location = new System.Drawing.Point(91, 662);
            this.txtCalculado.Margin = new System.Windows.Forms.Padding(2);
            this.txtCalculado.Name = "txtCalculado";
            this.txtCalculado.ReadOnly = true;
            this.txtCalculado.Size = new System.Drawing.Size(68, 20);
            this.txtCalculado.TabIndex = 15;
            this.txtCalculado.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 766);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTabulado);
            this.Controls.Add(this.txtVarianza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCalculado);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.cmbDistribucion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTablaFecuencia);
            this.Controls.Add(this.btnHistograma);
            this.Controls.Add(this.cmbIntervalo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chrGrafico);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.chrGrafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaFecuencia)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabChi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).EndInit();
            this.tabKS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrGrafico;
        private System.Windows.Forms.Button btnHistograma;
        private System.Windows.Forms.ComboBox cmbIntervalo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvTablaFecuencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDistribucion;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabChi;
        private System.Windows.Forms.TabPage tabKS;
        private System.Windows.Forms.DataGridView dgvChi;
        private System.Windows.Forms.DataGridView dgvKs;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtVarianza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTabulado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCalculado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label salidaPrueba;
    }
}