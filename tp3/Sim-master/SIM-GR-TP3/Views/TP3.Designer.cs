namespace SIM_GR_TP3
{
    partial class TP3
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbIntervalo = new System.Windows.Forms.ComboBox();
            this.lblElapsedTimeGenerator = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudRandomNumbersCount = new System.Windows.Forms.NumericUpDown();
            this.dtgNumeros = new System.Windows.Forms.DataGridView();
            this.Orden2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tabRandomMethods = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudExponentialDistribLambda = new System.Windows.Forms.NumericUpDown();
            this.nudExponentialDistribSeed = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.nudNormalDistribDeviation = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudNormalDistribMedia = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudNormalDistribSeed = new System.Windows.Forms.NumericUpDown();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLambda = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudUniformDistribSeed = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblElapsedTimeFrecuencies = new System.Windows.Forms.Label();
            this.dtgIntervalos = new System.Windows.Forms.DataGridView();
            this.columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graficoObtenida = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGraficoExcel = new System.Windows.Forms.Button();
            this.gradlib = new System.Windows.Forms.Label();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.Integrantes = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandomNumbersCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNumeros)).BeginInit();
            this.tabRandomMethods.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExponentialDistribLambda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExponentialDistribSeed)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNormalDistribDeviation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNormalDistribMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNormalDistribSeed)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblLambda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUniformDistribSeed)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntervalos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoObtenida)).BeginInit();
            this.gbResult.SuspendLayout();
            this.Integrantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbIntervalo);
            this.groupBox1.Controls.Add(this.lblElapsedTimeGenerator);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudRandomNumbersCount);
            this.groupBox1.Controls.Add(this.dtgNumeros);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.tabRandomMethods);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 811);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbIntervalo
            // 
            this.cmbIntervalo.AllowDrop = true;
            this.cmbIntervalo.FormattingEnabled = true;
            this.cmbIntervalo.Location = new System.Drawing.Point(124, 183);
            this.cmbIntervalo.Name = "cmbIntervalo";
            this.cmbIntervalo.Size = new System.Drawing.Size(151, 21);
            this.cmbIntervalo.TabIndex = 4;
            // 
            // lblElapsedTimeGenerator
            // 
            this.lblElapsedTimeGenerator.AutoSize = true;
            this.lblElapsedTimeGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElapsedTimeGenerator.Location = new System.Drawing.Point(47, 781);
            this.lblElapsedTimeGenerator.Name = "lblElapsedTimeGenerator";
            this.lblElapsedTimeGenerator.Size = new System.Drawing.Size(103, 13);
            this.lblElapsedTimeGenerator.TabIndex = 13;
            this.lblElapsedTimeGenerator.Text = "time for generate";
            this.lblElapsedTimeGenerator.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Cantidad intervalos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad a generar:";
            // 
            // nudRandomNumbersCount
            // 
            this.nudRandomNumbersCount.Location = new System.Drawing.Point(124, 160);
            this.nudRandomNumbersCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudRandomNumbersCount.Name = "nudRandomNumbersCount";
            this.nudRandomNumbersCount.Size = new System.Drawing.Size(151, 20);
            this.nudRandomNumbersCount.TabIndex = 3;
            // 
            // dtgNumeros
            // 
            this.dtgNumeros.AllowUserToAddRows = false;
            this.dtgNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Orden2,
            this.Column1});
            this.dtgNumeros.Location = new System.Drawing.Point(13, 259);
            this.dtgNumeros.Name = "dtgNumeros";
            this.dtgNumeros.RowHeadersVisible = false;
            this.dtgNumeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgNumeros.Size = new System.Drawing.Size(154, 486);
            this.dtgNumeros.StandardTab = true;
            this.dtgNumeros.TabIndex = 5;
            // 
            // Orden2
            // 
            this.Orden2.HeaderText = "Orden";
            this.Orden2.Name = "Orden2";
            this.Orden2.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Números";
            this.Column1.Name = "Column1";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Location = new System.Drawing.Point(194, 218);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 28);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerate.Location = new System.Drawing.Point(9, 212);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(162, 41);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "GENERAR";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tabRandomMethods
            // 
            this.tabRandomMethods.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabRandomMethods.Controls.Add(this.tabPage2);
            this.tabRandomMethods.Controls.Add(this.tabPage3);
            this.tabRandomMethods.Controls.Add(this.tabPage1);
            this.tabRandomMethods.Location = new System.Drawing.Point(9, 9);
            this.tabRandomMethods.Multiline = true;
            this.tabRandomMethods.Name = "tabRandomMethods";
            this.tabRandomMethods.SelectedIndex = 0;
            this.tabRandomMethods.Size = new System.Drawing.Size(315, 135);
            this.tabRandomMethods.TabIndex = 0;
            this.tabRandomMethods.Selected += new System.Windows.Forms.TabControlEventHandler(this.distChange);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.nudExponentialDistribLambda);
            this.tabPage2.Controls.Add(this.nudExponentialDistribSeed);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(307, 106);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Exponencial";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "λ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Semilla:";
            this.label9.Visible = false;
            // 
            // nudExponentialDistribLambda
            // 
            this.nudExponentialDistribLambda.DecimalPlaces = 2;
            this.nudExponentialDistribLambda.Location = new System.Drawing.Point(33, 30);
            this.nudExponentialDistribLambda.Name = "nudExponentialDistribLambda";
            this.nudExponentialDistribLambda.Size = new System.Drawing.Size(120, 20);
            this.nudExponentialDistribLambda.TabIndex = 2;
            // 
            // nudExponentialDistribSeed
            // 
            this.nudExponentialDistribSeed.Location = new System.Drawing.Point(181, 6);
            this.nudExponentialDistribSeed.Name = "nudExponentialDistribSeed";
            this.nudExponentialDistribSeed.Size = new System.Drawing.Size(120, 20);
            this.nudExponentialDistribSeed.TabIndex = 7;
            this.nudExponentialDistribSeed.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.nudNormalDistribDeviation);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.nudNormalDistribMedia);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.nudNormalDistribSeed);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(307, 106);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Normal";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "σ";
            // 
            // nudNormalDistribDeviation
            // 
            this.nudNormalDistribDeviation.DecimalPlaces = 2;
            this.nudNormalDistribDeviation.Location = new System.Drawing.Point(38, 55);
            this.nudNormalDistribDeviation.Name = "nudNormalDistribDeviation";
            this.nudNormalDistribDeviation.Size = new System.Drawing.Size(120, 20);
            this.nudNormalDistribDeviation.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "μ";
            // 
            // nudNormalDistribMedia
            // 
            this.nudNormalDistribMedia.DecimalPlaces = 2;
            this.nudNormalDistribMedia.Location = new System.Drawing.Point(38, 29);
            this.nudNormalDistribMedia.Name = "nudNormalDistribMedia";
            this.nudNormalDistribMedia.Size = new System.Drawing.Size(120, 20);
            this.nudNormalDistribMedia.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Semilla:";
            this.label2.Visible = false;
            // 
            // nudNormalDistribSeed
            // 
            this.nudNormalDistribSeed.Location = new System.Drawing.Point(184, 6);
            this.nudNormalDistribSeed.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudNormalDistribSeed.Name = "nudNormalDistribSeed";
            this.nudNormalDistribSeed.Size = new System.Drawing.Size(120, 20);
            this.nudNormalDistribSeed.TabIndex = 2;
            this.nudNormalDistribSeed.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lblLambda);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.nudUniformDistribSeed);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(307, 106);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Poisson";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "μ";
            // 
            // lblLambda
            // 
            this.lblLambda.DecimalPlaces = 2;
            this.lblLambda.Location = new System.Drawing.Point(37, 30);
            this.lblLambda.Name = "lblLambda";
            this.lblLambda.Size = new System.Drawing.Size(120, 20);
            this.lblLambda.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Semilla:";
            this.label3.Visible = false;
            // 
            // nudUniformDistribSeed
            // 
            this.nudUniformDistribSeed.Location = new System.Drawing.Point(181, 6);
            this.nudUniformDistribSeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudUniformDistribSeed.Name = "nudUniformDistribSeed";
            this.nudUniformDistribSeed.Size = new System.Drawing.Size(120, 20);
            this.nudUniformDistribSeed.TabIndex = 0;
            this.nudUniformDistribSeed.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblElapsedTimeFrecuencies);
            this.groupBox2.Controls.Add(this.dtgIntervalos);
            this.groupBox2.Location = new System.Drawing.Point(343, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1003, 309);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblElapsedTimeFrecuencies
            // 
            this.lblElapsedTimeFrecuencies.AutoSize = true;
            this.lblElapsedTimeFrecuencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElapsedTimeFrecuencies.Location = new System.Drawing.Point(19, 676);
            this.lblElapsedTimeFrecuencies.Name = "lblElapsedTimeFrecuencies";
            this.lblElapsedTimeFrecuencies.Size = new System.Drawing.Size(48, 13);
            this.lblElapsedTimeFrecuencies.TabIndex = 12;
            this.lblElapsedTimeFrecuencies.Text = "label11";
            this.lblElapsedTimeFrecuencies.Visible = false;
            // 
            // dtgIntervalos
            // 
            this.dtgIntervalos.AllowUserToAddRows = false;
            this.dtgIntervalos.AllowUserToDeleteRows = false;
            this.dtgIntervalos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgIntervalos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgIntervalos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIntervalos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columna1,
            this.columna3,
            this.columna4,
            this.Column2,
            this.Column3});
            this.dtgIntervalos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgIntervalos.Location = new System.Drawing.Point(6, 19);
            this.dtgIntervalos.Name = "dtgIntervalos";
            this.dtgIntervalos.ReadOnly = true;
            this.dtgIntervalos.RowHeadersVisible = false;
            this.dtgIntervalos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgIntervalos.Size = new System.Drawing.Size(991, 276);
            this.dtgIntervalos.TabIndex = 8;
            // 
            // columna1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columna1.DefaultCellStyle = dataGridViewCellStyle2;
            this.columna1.HeaderText = "Intervalos";
            this.columna1.Name = "columna1";
            this.columna1.ReadOnly = true;
            // 
            // columna3
            // 
            this.columna3.HeaderText = "F. Observada";
            this.columna3.Name = "columna3";
            this.columna3.ReadOnly = true;
            // 
            // columna4
            // 
            this.columna4.HeaderText = "F. Esperada";
            this.columna4.Name = "columna4";
            this.columna4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "C";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "C (Acum)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // graficoObtenida
            // 
            this.graficoObtenida.AllowDrop = true;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Title = "Intervalos / Clases";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea1.AxisY.Title = "Frecuencia";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea1.Name = "ChartArea1";
            this.graficoObtenida.ChartAreas.Add(chartArea1);
            this.graficoObtenida.ImeMode = System.Windows.Forms.ImeMode.On;
            legend1.Name = "Legend1";
            this.graficoObtenida.Legends.Add(legend1);
            this.graficoObtenida.Location = new System.Drawing.Point(355, 406);
            this.graficoObtenida.Name = "graficoObtenida";
            this.graficoObtenida.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.BorderColor = System.Drawing.Color.Red;
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "PointWidth=1";
            series1.Legend = "Legend1";
            series1.LegendText = "Observada";
            series1.Name = "Observada";
            series1.SmartLabelStyle.Enabled = false;
            series2.BorderColor = System.Drawing.Color.Red;
            series2.ChartArea = "ChartArea1";
            series2.CustomProperties = "PointWidth=1";
            series2.Legend = "Legend1";
            series2.Name = "Esperada";
            this.graficoObtenida.Series.Add(series1);
            this.graficoObtenida.Series.Add(series2);
            this.graficoObtenida.Size = new System.Drawing.Size(991, 286);
            this.graficoObtenida.SuppressExceptions = true;
            this.graficoObtenida.TabIndex = 10;
            this.graficoObtenida.Text = "Gráfico";
            this.graficoObtenida.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            this.graficoObtenida.Visible = false;
            // 
            // btnGraficoExcel
            // 
            this.btnGraficoExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficoExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficoExcel.Location = new System.Drawing.Point(770, 328);
            this.btnGraficoExcel.Name = "btnGraficoExcel";
            this.btnGraficoExcel.Size = new System.Drawing.Size(232, 60);
            this.btnGraficoExcel.TabIndex = 14;
            this.btnGraficoExcel.Text = "Ver en Excel";
            this.btnGraficoExcel.UseVisualStyleBackColor = true;
            this.btnGraficoExcel.Click += new System.EventHandler(this.btnGraficoExcel_Click);
            // 
            // gradlib
            // 
            this.gradlib.AutoSize = true;
            this.gradlib.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradlib.Location = new System.Drawing.Point(6, 23);
            this.gradlib.Name = "gradlib";
            this.gradlib.Size = new System.Drawing.Size(184, 25);
            this.gradlib.TabIndex = 11;
            this.gradlib.Text = "Grados de Libertad:";
            this.gradlib.Visible = false;
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.gradlib);
            this.gbResult.Location = new System.Drawing.Point(344, 318);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(276, 70);
            this.gbResult.TabIndex = 15;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Resultado";
            // 
            // Integrantes
            // 
            this.Integrantes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Integrantes.Controls.Add(this.label5);
            this.Integrantes.Controls.Add(this.label11);
            this.Integrantes.Controls.Add(this.label12);
            this.Integrantes.Controls.Add(this.label13);
            this.Integrantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Integrantes.Location = new System.Drawing.Point(355, 695);
            this.Integrantes.Name = "Integrantes";
            this.Integrantes.Size = new System.Drawing.Size(689, 53);
            this.Integrantes.TabIndex = 16;
            this.Integrantes.TabStop = false;
            this.Integrantes.Text = "Grupo R";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(177, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Carlesso Nicolas - 58326";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(347, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Gordillo Gustavo - 16077";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(523, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Chavez Marcelo - 49904";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Camusso Matias - 58227";
            // 
            // TP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1386, 764);
            this.Controls.Add(this.Integrantes);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.btnGraficoExcel);
            this.Controls.Add(this.graficoObtenida);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TP3";
            this.Text = "SIM - Grupo R - TP 3";
            this.Load += new System.EventHandler(this.TP3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandomNumbersCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNumeros)).EndInit();
            this.tabRandomMethods.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExponentialDistribLambda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExponentialDistribSeed)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNormalDistribDeviation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNormalDistribMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNormalDistribSeed)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblLambda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUniformDistribSeed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntervalos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoObtenida)).EndInit();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.Integrantes.ResumeLayout(false);
            this.Integrantes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabRandomMethods;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGenerate;
        internal System.Windows.Forms.DataGridView dtgIntervalos;
        internal System.Windows.Forms.DataGridView dtgNumeros;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Orden2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudNormalDistribSeed;
        private System.Windows.Forms.NumericUpDown nudUniformDistribSeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudExponentialDistribLambda;
        private System.Windows.Forms.NumericUpDown nudExponentialDistribSeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudRandomNumbersCount;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.DataVisualization.Charting.Chart graficoObtenida;
        private System.Windows.Forms.Label gradlib;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lblElapsedTimeFrecuencies;
        private System.Windows.Forms.Label lblElapsedTimeGenerator;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudNormalDistribMedia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudNormalDistribDeviation;
        private System.Windows.Forms.Button btnGraficoExcel;
        private System.Windows.Forms.ComboBox cmbIntervalo;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown lblLambda;
        private System.Windows.Forms.GroupBox Integrantes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

