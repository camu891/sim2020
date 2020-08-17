namespace simulacion_tp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSiguienteRND = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblFormulaC1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFormula = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.Integrantes = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.random = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTamanio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbLenguaje = new System.Windows.Forms.RadioButton();
            this.rbMultiplicativo = new System.Windows.Forms.RadioButton();
            this.rbMixto = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblGradosLibertad = new System.Windows.Forms.Label();
            this.chrGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvTablaFecuencia = new System.Windows.Forms.DataGridView();
            this.btnHistograma = new System.Windows.Forms.Button();
            this.cmbIntervalo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblFormulaA = new System.Windows.Forms.Label();
            this.lblFormulaC2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Integrantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrGrafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaFecuencia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.Integrantes);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.grilla);
            this.groupBox1.Controls.Add(this.txtTamanio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtG);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.txtK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbLenguaje);
            this.groupBox1.Controls.Add(this.rbMultiplicativo);
            this.groupBox1.Controls.Add(this.rbMixto);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(458, 688);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Controls.Add(this.btnSiguienteRND);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(6, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 80);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Siguiente RND";
            // 
            // btnSiguienteRND
            // 
            this.btnSiguienteRND.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSiguienteRND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteRND.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSiguienteRND.Location = new System.Drawing.Point(7, 27);
            this.btnSiguienteRND.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiguienteRND.Name = "btnSiguienteRND";
            this.btnSiguienteRND.Size = new System.Drawing.Size(175, 31);
            this.btnSiguienteRND.TabIndex = 16;
            this.btnSiguienteRND.Text = "Generar RND";
            this.btnSiguienteRND.UseVisualStyleBackColor = false;
            this.btnSiguienteRND.Click += new System.EventHandler(this.btnSiguienteRND_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Controls.Add(this.lblFormulaC2);
            this.groupBox4.Controls.Add(this.lblFormulaA);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.lblFormulaC1);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.lblFormula);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(6, 331);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(185, 206);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fórmula";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 92);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "m = módulo";
            // 
            // lblFormulaC1
            // 
            this.lblFormulaC1.AutoSize = true;
            this.lblFormulaC1.Location = new System.Drawing.Point(17, 110);
            this.lblFormulaC1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormulaC1.Name = "lblFormulaC1";
            this.lblFormulaC1.Size = new System.Drawing.Size(74, 13);
            this.lblFormulaC1.TabIndex = 21;
            this.lblFormulaC1.Text = "c = cte aditiva";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 75);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "a = cte multiplicativa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 58);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "X0 = semilla";
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Location = new System.Drawing.Point(15, 28);
            this.lblFormula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(111, 13);
            this.lblFormula.TabIndex = 18;
            this.lblFormula.Text = "Xi+1 = ( a * Xi ) mod m";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 206);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(184, 24);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Integrantes
            // 
            this.Integrantes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Integrantes.Controls.Add(this.label10);
            this.Integrantes.Controls.Add(this.label9);
            this.Integrantes.Controls.Add(this.label8);
            this.Integrantes.Controls.Add(this.label7);
            this.Integrantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Integrantes.Location = new System.Drawing.Point(8, 557);
            this.Integrantes.Name = "Integrantes";
            this.Integrantes.Size = new System.Drawing.Size(185, 126);
            this.Integrantes.TabIndex = 14;
            this.Integrantes.TabStop = false;
            this.Integrantes.Text = "Grupo R";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Carlesso Nicolas - 58326";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Gordillo Gustavo - 16077";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Chavez Marcelo - 49904";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Camusso Matias - 58227";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenerar.Location = new System.Drawing.Point(8, 150);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(182, 43);
            this.btnGenerar.TabIndex = 13;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            this.grilla.AllowUserToDeleteRows = false;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.posicion,
            this.random});
            this.grilla.Location = new System.Drawing.Point(195, 14);
            this.grilla.Margin = new System.Windows.Forms.Padding(2);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.RowHeadersWidth = 51;
            this.grilla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grilla.RowTemplate.Height = 24;
            this.grilla.Size = new System.Drawing.Size(259, 669);
            this.grilla.TabIndex = 2;
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
            // txtTamanio
            // 
            this.txtTamanio.Location = new System.Drawing.Point(68, 110);
            this.txtTamanio.Margin = new System.Windows.Forms.Padding(2);
            this.txtTamanio.Name = "txtTamanio";
            this.txtTamanio.Size = new System.Drawing.Size(27, 20);
            this.txtTamanio.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tamaño";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "g";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "c";
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(164, 86);
            this.txtG.Margin = new System.Windows.Forms.Padding(2);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(27, 20);
            this.txtG.TabIndex = 8;
            this.txtG.TextChanged += new System.EventHandler(this.txtG_TextChanged);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(114, 86);
            this.txtC.Margin = new System.Windows.Forms.Padding(2);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(27, 20);
            this.txtC.TabIndex = 7;
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(68, 86);
            this.txtK.Margin = new System.Windows.Forms.Padding(2);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(27, 20);
            this.txtK.TabIndex = 6;
            this.txtK.TextChanged += new System.EventHandler(this.txtK_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "k";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(20, 86);
            this.txtX.Margin = new System.Windows.Forms.Padding(2);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(27, 20);
            this.txtX.TabIndex = 4;
            this.txtX.TextChanged += new System.EventHandler(this.txtX_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "x";
            // 
            // rbLenguaje
            // 
            this.rbLenguaje.AutoSize = true;
            this.rbLenguaje.Location = new System.Drawing.Point(5, 63);
            this.rbLenguaje.Margin = new System.Windows.Forms.Padding(2);
            this.rbLenguaje.Name = "rbLenguaje";
            this.rbLenguaje.Size = new System.Drawing.Size(69, 17);
            this.rbLenguaje.TabIndex = 2;
            this.rbLenguaje.TabStop = true;
            this.rbLenguaje.Text = "Lenguaje";
            this.rbLenguaje.UseVisualStyleBackColor = true;
            this.rbLenguaje.Visible = false;
            this.rbLenguaje.CheckedChanged += new System.EventHandler(this.rbLenguaje_CheckedChanged);
            // 
            // rbMultiplicativo
            // 
            this.rbMultiplicativo.AutoSize = true;
            this.rbMultiplicativo.Location = new System.Drawing.Point(5, 41);
            this.rbMultiplicativo.Margin = new System.Windows.Forms.Padding(2);
            this.rbMultiplicativo.Name = "rbMultiplicativo";
            this.rbMultiplicativo.Size = new System.Drawing.Size(86, 17);
            this.rbMultiplicativo.TabIndex = 1;
            this.rbMultiplicativo.TabStop = true;
            this.rbMultiplicativo.Text = "Multiplicativo";
            this.rbMultiplicativo.UseVisualStyleBackColor = true;
            this.rbMultiplicativo.CheckedChanged += new System.EventHandler(this.rbMultiplicativo_CheckedChanged);
            // 
            // rbMixto
            // 
            this.rbMixto.AutoSize = true;
            this.rbMixto.Location = new System.Drawing.Point(5, 18);
            this.rbMixto.Margin = new System.Windows.Forms.Padding(2);
            this.rbMixto.Name = "rbMixto";
            this.rbMixto.Size = new System.Drawing.Size(50, 17);
            this.rbMixto.TabIndex = 0;
            this.rbMixto.TabStop = true;
            this.rbMixto.Text = "Mixto";
            this.rbMixto.UseVisualStyleBackColor = true;
            this.rbMixto.CheckedChanged += new System.EventHandler(this.rbLineal_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblGradosLibertad);
            this.groupBox2.Controls.Add(this.chrGrafico);
            this.groupBox2.Controls.Add(this.dgvTablaFecuencia);
            this.groupBox2.Controls.Add(this.btnHistograma);
            this.groupBox2.Controls.Add(this.cmbIntervalo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(472, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(678, 689);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Histograma";
            // 
            // lblGradosLibertad
            // 
            this.lblGradosLibertad.AutoSize = true;
            this.lblGradosLibertad.Location = new System.Drawing.Point(4, 299);
            this.lblGradosLibertad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGradosLibertad.Name = "lblGradosLibertad";
            this.lblGradosLibertad.Size = new System.Drawing.Size(0, 13);
            this.lblGradosLibertad.TabIndex = 5;
            // 
            // chrGrafico
            // 
            chartArea9.Name = "ChartArea1";
            this.chrGrafico.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chrGrafico.Legends.Add(legend9);
            this.chrGrafico.Location = new System.Drawing.Point(4, 299);
            this.chrGrafico.Margin = new System.Windows.Forms.Padding(2);
            this.chrGrafico.Name = "chrGrafico";
            series17.ChartArea = "ChartArea1";
            series17.Legend = "Legend1";
            series17.Name = "Series1";
            series18.ChartArea = "ChartArea1";
            series18.Legend = "Legend1";
            series18.Name = "Series2";
            this.chrGrafico.Series.Add(series17);
            this.chrGrafico.Series.Add(series18);
            this.chrGrafico.Size = new System.Drawing.Size(668, 366);
            this.chrGrafico.TabIndex = 4;
            this.chrGrafico.Text = "chart1";
            title9.Name = "Histograma de frecuencias";
            this.chrGrafico.Titles.Add(title9);
            // 
            // dgvTablaFecuencia
            // 
            this.dgvTablaFecuencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaFecuencia.Location = new System.Drawing.Point(5, 44);
            this.dgvTablaFecuencia.Name = "dgvTablaFecuencia";
            this.dgvTablaFecuencia.RowHeadersWidth = 51;
            this.dgvTablaFecuencia.Size = new System.Drawing.Size(668, 249);
            this.dgvTablaFecuencia.TabIndex = 3;
            // 
            // btnHistograma
            // 
            this.btnHistograma.Location = new System.Drawing.Point(164, 15);
            this.btnHistograma.Name = "btnHistograma";
            this.btnHistograma.Size = new System.Drawing.Size(75, 23);
            this.btnHistograma.TabIndex = 2;
            this.btnHistograma.Text = "Histograma";
            this.btnHistograma.UseVisualStyleBackColor = true;
            this.btnHistograma.Click += new System.EventHandler(this.btnHistograma_Click);
            // 
            // cmbIntervalo
            // 
            this.cmbIntervalo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIntervalo.FormattingEnabled = true;
            this.cmbIntervalo.Location = new System.Drawing.Point(68, 17);
            this.cmbIntervalo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIntervalo.Name = "cmbIntervalo";
            this.cmbIntervalo.Size = new System.Drawing.Size(92, 21);
            this.cmbIntervalo.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Intervalos";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 142);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "m = 2^g (g número entero)";
            // 
            // lblFormulaA
            // 
            this.lblFormulaA.AutoSize = true;
            this.lblFormulaA.Location = new System.Drawing.Point(17, 159);
            this.lblFormulaA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormulaA.Name = "lblFormulaA";
            this.lblFormulaA.Size = new System.Drawing.Size(65, 13);
            this.lblFormulaA.TabIndex = 24;
            this.lblFormulaA.Text = "a = 1 + 4 * k";
            // 
            // lblFormulaC2
            // 
            this.lblFormulaC2.AutoSize = true;
            this.lblFormulaC2.Location = new System.Drawing.Point(17, 175);
            this.lblFormulaC2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormulaC2.Name = "lblFormulaC2";
            this.lblFormulaC2.Size = new System.Drawing.Size(136, 13);
            this.lblFormulaC2.TabIndex = 25;
            this.lblFormulaC2.Text = "c = relativamente primo a m";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(270, 21);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(225, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Intervalos: Inferior (abierto) - Superior (cerrado)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1152, 709);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Generador de números aleatorios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Integrantes.ResumeLayout(false);
            this.Integrantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrGrafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaFecuencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLenguaje;
        private System.Windows.Forms.RadioButton rbMultiplicativo;
        private System.Windows.Forms.RadioButton rbMixto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTamanio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn random;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbIntervalo;
        private System.Windows.Forms.Button btnHistograma;
        private System.Windows.Forms.DataGridView dgvTablaFecuencia;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrGrafico;
        private System.Windows.Forms.Label lblGradosLibertad;
        private System.Windows.Forms.GroupBox Integrantes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSiguienteRND;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblFormulaC1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblFormulaC2;
        private System.Windows.Forms.Label lblFormulaA;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
    }
}

