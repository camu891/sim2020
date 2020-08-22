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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblRuta = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.chrGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnHistograma = new System.Windows.Forms.Button();
            this.cmbIntervalo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvTablaFecuencia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDistribucion = new System.Windows.Forms.ComboBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvChi = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvKs = new System.Windows.Forms.DataGridView();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtVarianza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Inf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chrGrafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaFecuencia)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(594, 30);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(81, 35);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(22, 37);
            this.lblRuta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(48, 20);
            this.lblRuta.TabIndex = 1;
            this.lblRuta.Text = "Ruta:";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(104, 32);
            this.txtRuta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(470, 26);
            this.txtRuta.TabIndex = 2;
            // 
            // chrGrafico
            // 
            chartArea2.Name = "ChartArea1";
            this.chrGrafico.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrGrafico.Legends.Add(legend2);
            this.chrGrafico.Location = new System.Drawing.Point(594, 134);
            this.chrGrafico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chrGrafico.Name = "chrGrafico";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrGrafico.Series.Add(series2);
            this.chrGrafico.Size = new System.Drawing.Size(613, 283);
            this.chrGrafico.TabIndex = 3;
            this.chrGrafico.Text = "chart1";
            this.chrGrafico.Visible = false;
            // 
            // btnHistograma
            // 
            this.btnHistograma.Location = new System.Drawing.Point(318, 83);
            this.btnHistograma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHistograma.Name = "btnHistograma";
            this.btnHistograma.Size = new System.Drawing.Size(112, 33);
            this.btnHistograma.TabIndex = 6;
            this.btnHistograma.Text = "Histograma";
            this.btnHistograma.UseVisualStyleBackColor = true;
            this.btnHistograma.Click += new System.EventHandler(this.btnHistograma_Click);
            // 
            // cmbIntervalo
            // 
            this.cmbIntervalo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIntervalo.FormattingEnabled = true;
            this.cmbIntervalo.Location = new System.Drawing.Point(104, 89);
            this.cmbIntervalo.Name = "cmbIntervalo";
            this.cmbIntervalo.Size = new System.Drawing.Size(136, 28);
            this.cmbIntervalo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
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
            this.dgvTablaFecuencia.Location = new System.Drawing.Point(13, 134);
            this.dgvTablaFecuencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTablaFecuencia.Name = "dgvTablaFecuencia";
            this.dgvTablaFecuencia.RowHeadersWidth = 62;
            this.dgvTablaFecuencia.Size = new System.Drawing.Size(527, 283);
            this.dgvTablaFecuencia.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Distribución:";
            // 
            // cmbDistribucion
            // 
            this.cmbDistribucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistribucion.FormattingEnabled = true;
            this.cmbDistribucion.Location = new System.Drawing.Point(112, 437);
            this.cmbDistribucion.Name = "cmbDistribucion";
            this.cmbDistribucion.Size = new System.Drawing.Size(151, 28);
            this.cmbDistribucion.TabIndex = 9;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(306, 437);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(125, 33);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "Realizar Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 530);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1064, 219);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvChi);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1056, 186);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chi cuardrado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvChi
            // 
            this.dgvChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChi.Location = new System.Drawing.Point(15, 17);
            this.dgvChi.Name = "dgvChi";
            this.dgvChi.RowHeadersWidth = 62;
            this.dgvChi.RowTemplate.Height = 28;
            this.dgvChi.Size = new System.Drawing.Size(990, 150);
            this.dgvChi.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvKs);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1056, 186);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kolgomorov Smirnof";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvKs
            // 
            this.dgvKs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKs.Location = new System.Drawing.Point(33, 18);
            this.dgvKs.Name = "dgvKs";
            this.dgvKs.RowHeadersWidth = 62;
            this.dgvKs.RowTemplate.Height = 28;
            this.dgvKs.Size = new System.Drawing.Size(990, 150);
            this.dgvKs.TabIndex = 1;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(665, 502);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 26);
            this.txtMedia.TabIndex = 12;
            // 
            // txtVarianza
            // 
            this.txtVarianza.Location = new System.Drawing.Point(935, 502);
            this.txtVarianza.Name = "txtVarianza";
            this.txtVarianza.Size = new System.Drawing.Size(100, 26);
            this.txtVarianza.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Media:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(824, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Varianza:";
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 793);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVarianza);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.chrGrafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaFecuencia)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChi)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKs)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvChi;
        private System.Windows.Forms.DataGridView dgvKs;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtVarianza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fo;
    }
}