namespace WindowsFormsApplication1
{
    partial class TP4
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_cantDias = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_generarSimulacion = new System.Windows.Forms.Button();
            this.dgv_simulacion = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pol_20fras = new System.Windows.Forms.RadioButton();
            this.pol_10Fras = new System.Windows.Forms.RadioButton();
            this.lbl_resultados = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioCada10mil = new System.Windows.Forms.RadioButton();
            this.txt_hasta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_desde = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.txt_precVenta = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label58 = new System.Windows.Forms.Label();
            this.txt_gramosFrasco = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.txt_horasTurno = new System.Windows.Forms.TextBox();
            this.txt_precCompra = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pol_3Fras = new System.Windows.Forms.RadioButton();
            this.pol_2Fras = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pol_3dias = new System.Windows.Forms.RadioButton();
            this.pol_2dias = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pol_Congr = new System.Windows.Forms.RadioButton();
            this.pol_Leng = new System.Windows.Forms.RadioButton();
            this.Integrantes = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_Resultados2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.Integrantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_cantDias
            // 
            this.txt_cantDias.Location = new System.Drawing.Point(683, 116);
            this.txt_cantDias.Name = "txt_cantDias";
            this.txt_cantDias.Size = new System.Drawing.Size(140, 20);
            this.txt_cantDias.TabIndex = 19;
            this.txt_cantDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantDias_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(591, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cantidad de dias";
            // 
            // btn_generarSimulacion
            // 
            this.btn_generarSimulacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generarSimulacion.Location = new System.Drawing.Point(594, 150);
            this.btn_generarSimulacion.Name = "btn_generarSimulacion";
            this.btn_generarSimulacion.Size = new System.Drawing.Size(313, 28);
            this.btn_generarSimulacion.TabIndex = 17;
            this.btn_generarSimulacion.Text = "Generar simulación";
            this.btn_generarSimulacion.UseVisualStyleBackColor = true;
            this.btn_generarSimulacion.Click += new System.EventHandler(this.btn_generarSimulacion_Click);
            // 
            // dgv_simulacion
            // 
            this.dgv_simulacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_simulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_simulacion.Location = new System.Drawing.Point(12, 237);
            this.dgv_simulacion.Name = "dgv_simulacion";
            this.dgv_simulacion.Size = new System.Drawing.Size(1612, 506);
            this.dgv_simulacion.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pol_20fras);
            this.groupBox1.Controls.Add(this.pol_10Fras);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 71);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Politicas de almacenamiento";
            // 
            // pol_20fras
            // 
            this.pol_20fras.AutoSize = true;
            this.pol_20fras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pol_20fras.Location = new System.Drawing.Point(100, 35);
            this.pol_20fras.Name = "pol_20fras";
            this.pol_20fras.Size = new System.Drawing.Size(86, 21);
            this.pol_20fras.TabIndex = 1;
            this.pol_20fras.TabStop = true;
            this.pol_20fras.Text = "20 frascos";
            this.pol_20fras.UseVisualStyleBackColor = true;
            // 
            // pol_10Fras
            // 
            this.pol_10Fras.AutoSize = true;
            this.pol_10Fras.Checked = true;
            this.pol_10Fras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pol_10Fras.Location = new System.Drawing.Point(6, 35);
            this.pol_10Fras.Name = "pol_10Fras";
            this.pol_10Fras.Size = new System.Drawing.Size(88, 21);
            this.pol_10Fras.TabIndex = 0;
            this.pol_10Fras.TabStop = true;
            this.pol_10Fras.Text = "10 Frascos";
            this.pol_10Fras.UseVisualStyleBackColor = true;
            // 
            // lbl_resultados
            // 
            this.lbl_resultados.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultados.Location = new System.Drawing.Point(12, 762);
            this.lbl_resultados.Name = "lbl_resultados";
            this.lbl_resultados.Size = new System.Drawing.Size(476, 99);
            this.lbl_resultados.TabIndex = 32;
            this.lbl_resultados.Text = "Resultados: -";
            this.lbl_resultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioCada10mil);
            this.groupBox2.Controls.Add(this.txt_hasta);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_desde);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 133);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rango a mostrar";
            // 
            // radioCada10mil
            // 
            this.radioCada10mil.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.radioCada10mil.AutoSize = true;
            this.radioCada10mil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCada10mil.Location = new System.Drawing.Point(11, 97);
            this.radioCada10mil.Name = "radioCada10mil";
            this.radioCada10mil.Size = new System.Drawing.Size(146, 21);
            this.radioCada10mil.TabIndex = 19;
            this.radioCada10mil.Text = "Mostrar Cada 10 mil";
            this.radioCada10mil.UseVisualStyleBackColor = true;
            this.radioCada10mil.CheckedChanged += new System.EventHandler(this.radioCada10mil_CheckedChanged);
            // 
            // txt_hasta
            // 
            this.txt_hasta.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_hasta.Location = new System.Drawing.Point(80, 66);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(79, 25);
            this.txt_hasta.TabIndex = 3;
            this.txt_hasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_hasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hasta_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label9.Location = new System.Drawing.Point(29, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Hasta";
            // 
            // txt_desde
            // 
            this.txt_desde.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_desde.Location = new System.Drawing.Point(80, 35);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(79, 25);
            this.txt_desde.TabIndex = 1;
            this.txt_desde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_desde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_desde_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label10.Location = new System.Drawing.Point(29, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Desde";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(6, 36);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(122, 17);
            this.label55.TabIndex = 96;
            this.label55.Text = "Prec Venta x100 gr";
            // 
            // txt_precVenta
            // 
            this.txt_precVenta.Enabled = false;
            this.txt_precVenta.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_precVenta.Location = new System.Drawing.Point(134, 31);
            this.txt_precVenta.Name = "txt_precVenta";
            this.txt_precVenta.Size = new System.Drawing.Size(36, 25);
            this.txt_precVenta.TabIndex = 97;
            this.txt_precVenta.Text = "150";
            this.txt_precVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_precVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precVenta_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label58);
            this.groupBox3.Controls.Add(this.txt_gramosFrasco);
            this.groupBox3.Controls.Add(this.label57);
            this.groupBox3.Controls.Add(this.txt_horasTurno);
            this.groupBox3.Controls.Add(this.txt_precCompra);
            this.groupBox3.Controls.Add(this.label56);
            this.groupBox3.Controls.Add(this.label55);
            this.groupBox3.Controls.Add(this.txt_precVenta);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(936, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 106);
            this.groupBox3.TabIndex = 98;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precios";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(6, 76);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(107, 17);
            this.label58.TabIndex = 101;
            this.label58.Text = "Gramos x frasco";
            // 
            // txt_gramosFrasco
            // 
            this.txt_gramosFrasco.Enabled = false;
            this.txt_gramosFrasco.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_gramosFrasco.Location = new System.Drawing.Point(119, 68);
            this.txt_gramosFrasco.Name = "txt_gramosFrasco";
            this.txt_gramosFrasco.Size = new System.Drawing.Size(36, 25);
            this.txt_gramosFrasco.TabIndex = 102;
            this.txt_gramosFrasco.Text = "170";
            this.txt_gramosFrasco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_gramosFrasco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precFaltante_KeyPress);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(165, 71);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(93, 17);
            this.label57.TabIndex = 99;
            this.label57.Text = "Horas x turno";
            // 
            // txt_horasTurno
            // 
            this.txt_horasTurno.Enabled = false;
            this.txt_horasTurno.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_horasTurno.Location = new System.Drawing.Point(264, 68);
            this.txt_horasTurno.Name = "txt_horasTurno";
            this.txt_horasTurno.Size = new System.Drawing.Size(36, 25);
            this.txt_horasTurno.TabIndex = 100;
            this.txt_horasTurno.Text = "8";
            this.txt_horasTurno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_horasTurno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precCementerio_KeyPress);
            // 
            // txt_precCompra
            // 
            this.txt_precCompra.Enabled = false;
            this.txt_precCompra.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_precCompra.Location = new System.Drawing.Point(336, 31);
            this.txt_precCompra.Name = "txt_precCompra";
            this.txt_precCompra.Size = new System.Drawing.Size(36, 25);
            this.txt_precCompra.TabIndex = 99;
            this.txt_precCompra.Text = "250";
            this.txt_precCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_precCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precCompra_KeyPress);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(196, 35);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(134, 17);
            this.label56.TabIndex = 98;
            this.label56.Text = "Prec Compra xfrasco";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1055, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 99;
            this.button1.Text = "Habilitar Precios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pol_3Fras);
            this.groupBox4.Controls.Add(this.pol_2Fras);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(320, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 71);
            this.groupBox4.TabIndex = 101;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Politicas de compras";
            // 
            // pol_3Fras
            // 
            this.pol_3Fras.AutoSize = true;
            this.pol_3Fras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pol_3Fras.Location = new System.Drawing.Point(113, 35);
            this.pol_3Fras.Name = "pol_3Fras";
            this.pol_3Fras.Size = new System.Drawing.Size(81, 21);
            this.pol_3Fras.TabIndex = 1;
            this.pol_3Fras.TabStop = true;
            this.pol_3Fras.Text = "3 Frascos";
            this.pol_3Fras.UseVisualStyleBackColor = true;
            // 
            // pol_2Fras
            // 
            this.pol_2Fras.AutoSize = true;
            this.pol_2Fras.Checked = true;
            this.pol_2Fras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pol_2Fras.Location = new System.Drawing.Point(6, 35);
            this.pol_2Fras.Name = "pol_2Fras";
            this.pol_2Fras.Size = new System.Drawing.Size(81, 21);
            this.pol_2Fras.TabIndex = 0;
            this.pol_2Fras.TabStop = true;
            this.pol_2Fras.Text = "2 Frascos";
            this.pol_2Fras.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pol_3dias);
            this.groupBox5.Controls.Add(this.pol_2dias);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(579, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(248, 71);
            this.groupBox5.TabIndex = 106;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Politicas periodo de compras";
            // 
            // pol_3dias
            // 
            this.pol_3dias.AutoSize = true;
            this.pol_3dias.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pol_3dias.Location = new System.Drawing.Point(113, 35);
            this.pol_3dias.Name = "pol_3dias";
            this.pol_3dias.Size = new System.Drawing.Size(61, 21);
            this.pol_3dias.TabIndex = 1;
            this.pol_3dias.Text = "3 días";
            this.pol_3dias.UseVisualStyleBackColor = true;
            // 
            // pol_2dias
            // 
            this.pol_2dias.AutoSize = true;
            this.pol_2dias.Checked = true;
            this.pol_2dias.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pol_2dias.Location = new System.Drawing.Point(26, 35);
            this.pol_2dias.Name = "pol_2dias";
            this.pol_2dias.Size = new System.Drawing.Size(61, 21);
            this.pol_2dias.TabIndex = 0;
            this.pol_2dias.TabStop = true;
            this.pol_2dias.Text = "2 días";
            this.pol_2dias.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.txtM);
            this.groupBox6.Controls.Add(this.txtC);
            this.groupBox6.Controls.Add(this.txtA);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.txtX);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.pol_Congr);
            this.groupBox6.Controls.Add(this.pol_Leng);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(234, 98);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(325, 133);
            this.groupBox6.TabIndex = 107;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tipo de randoms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "c";
            // 
            // txtM
            // 
            this.txtM.Enabled = false;
            this.txtM.Location = new System.Drawing.Point(214, 88);
            this.txtM.Margin = new System.Windows.Forms.Padding(2);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(27, 25);
            this.txtM.TabIndex = 16;
            this.txtM.Text = "101";
            // 
            // txtC
            // 
            this.txtC.Enabled = false;
            this.txtC.Location = new System.Drawing.Point(162, 88);
            this.txtC.Margin = new System.Windows.Forms.Padding(2);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(27, 25);
            this.txtC.TabIndex = 15;
            this.txtC.Text = "43";
            // 
            // txtA
            // 
            this.txtA.Enabled = false;
            this.txtA.Location = new System.Drawing.Point(116, 88);
            this.txtA.Margin = new System.Windows.Forms.Padding(2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(27, 25);
            this.txtA.TabIndex = 14;
            this.txtA.Text = "13";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "a";
            // 
            // txtX
            // 
            this.txtX.Enabled = false;
            this.txtX.Location = new System.Drawing.Point(68, 88);
            this.txtX.Margin = new System.Windows.Forms.Padding(2);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(27, 25);
            this.txtX.TabIndex = 12;
            this.txtX.Text = "37";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "x";
            // 
            // pol_Congr
            // 
            this.pol_Congr.AutoSize = true;
            this.pol_Congr.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pol_Congr.Location = new System.Drawing.Point(165, 34);
            this.pol_Congr.Name = "pol_Congr";
            this.pol_Congr.Size = new System.Drawing.Size(102, 21);
            this.pol_Congr.TabIndex = 3;
            this.pol_Congr.TabStop = true;
            this.pol_Congr.Text = "Congruencial";
            this.pol_Congr.UseVisualStyleBackColor = true;
            this.pol_Congr.Click += new System.EventHandler(this.allowMostrarRnds);
            // 
            // pol_Leng
            // 
            this.pol_Leng.AutoSize = true;
            this.pol_Leng.Checked = true;
            this.pol_Leng.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pol_Leng.Location = new System.Drawing.Point(17, 34);
            this.pol_Leng.Name = "pol_Leng";
            this.pol_Leng.Size = new System.Drawing.Size(95, 21);
            this.pol_Leng.TabIndex = 2;
            this.pol_Leng.TabStop = true;
            this.pol_Leng.Text = "De lenguaje";
            this.pol_Leng.UseVisualStyleBackColor = true;
            this.pol_Leng.Click += new System.EventHandler(this.allowMostrarRnds);
            // 
            // Integrantes
            // 
            this.Integrantes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Integrantes.Controls.Add(this.label1);
            this.Integrantes.Controls.Add(this.label11);
            this.Integrantes.Controls.Add(this.label12);
            this.Integrantes.Controls.Add(this.label13);
            this.Integrantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Integrantes.Location = new System.Drawing.Point(945, 867);
            this.Integrantes.Name = "Integrantes";
            this.Integrantes.Size = new System.Drawing.Size(689, 53);
            this.Integrantes.TabIndex = 108;
            this.Integrantes.TabStop = false;
            this.Integrantes.Text = "Grupo R";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Carlesso Nicolas - 58326";
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
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(707, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Mostrar Rnds";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_Resultados2
            // 
            this.lbl_Resultados2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultados2.Location = new System.Drawing.Point(524, 762);
            this.lbl_Resultados2.Name = "lbl_Resultados2";
            this.lbl_Resultados2.Size = new System.Drawing.Size(480, 99);
            this.lbl_Resultados2.TabIndex = 109;
            this.lbl_Resultados2.Text = "-";
            this.lbl_Resultados2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButton1
            // 
            this.radioButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(11, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // TP4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1861, 932);
            this.Controls.Add(this.lbl_Resultados2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Integrantes);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_resultados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_simulacion);
            this.Controls.Add(this.txt_cantDias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_generarSimulacion);
            this.Name = "TP4";
            this.Text = "TP 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.Integrantes.ResumeLayout(false);
            this.Integrantes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cantDias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_generarSimulacion;
        private System.Windows.Forms.DataGridView dgv_simulacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton pol_20fras;
        private System.Windows.Forms.RadioButton pol_10Fras;
        private System.Windows.Forms.Label lbl_resultados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_hasta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_desde;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox txt_precVenta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox txt_horasTurno;
        private System.Windows.Forms.TextBox txt_precCompra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox txt_gramosFrasco;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton pol_3Fras;
        private System.Windows.Forms.RadioButton pol_2Fras;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton pol_3dias;
        private System.Windows.Forms.RadioButton pol_2dias;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton pol_Congr;
        private System.Windows.Forms.RadioButton pol_Leng;
        private System.Windows.Forms.GroupBox Integrantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_Resultados2;
        private System.Windows.Forms.RadioButton radioCada10mil;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

