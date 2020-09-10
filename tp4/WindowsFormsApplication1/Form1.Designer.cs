namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.rb_Pb1 = new System.Windows.Forms.RadioButton();
            this.rb_Pa = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_reservaciones = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_resultados = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.lbl_resultados_D = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_simulacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_cantDias
            // 
            this.txt_cantDias.Location = new System.Drawing.Point(300, 133);
            this.txt_cantDias.Name = "txt_cantDias";
            this.txt_cantDias.Size = new System.Drawing.Size(140, 20);
            this.txt_cantDias.TabIndex = 19;
            this.txt_cantDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantDias_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cantidad de dias";
            // 
            // btn_generarSimulacion
            // 
            this.btn_generarSimulacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generarSimulacion.Location = new System.Drawing.Point(211, 167);
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
            this.dgv_simulacion.Size = new System.Drawing.Size(1612, 509);
            this.dgv_simulacion.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Pb1);
            this.groupBox1.Controls.Add(this.rb_Pa);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 71);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Politicas de almacenamiento";
            // 
            // rb_Pb1
            // 
            this.rb_Pb1.AutoSize = true;
            this.rb_Pb1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Pb1.Location = new System.Drawing.Point(71, 35);
            this.rb_Pb1.Name = "rb_Pb1";
            this.rb_Pb1.Size = new System.Drawing.Size(58, 21);
            this.rb_Pb1.TabIndex = 1;
            this.rb_Pb1.TabStop = true;
            this.rb_Pb1.Text = "PolitB";
            this.rb_Pb1.UseVisualStyleBackColor = true;
            // 
            // rb_Pa
            // 
            this.rb_Pa.AutoSize = true;
            this.rb_Pa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Pa.Location = new System.Drawing.Point(6, 35);
            this.rb_Pa.Name = "rb_Pa";
            this.rb_Pa.Size = new System.Drawing.Size(59, 21);
            this.rb_Pa.TabIndex = 0;
            this.rb_Pa.TabStop = true;
            this.rb_Pa.Text = "PolitA";
            this.rb_Pa.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(197, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 30);
            this.label3.TabIndex = 25;
            this.label3.Text = "10 frascos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_reservaciones
            // 
            this.lbl_reservaciones.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_reservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_reservaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_reservaciones.Location = new System.Drawing.Point(347, 47);
            this.lbl_reservaciones.Name = "lbl_reservaciones";
            this.lbl_reservaciones.Size = new System.Drawing.Size(155, 30);
            this.lbl_reservaciones.TabIndex = 24;
            this.lbl_reservaciones.Text = "  20 frascos";
            this.lbl_reservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 41);
            this.label1.TabIndex = 23;
            this.label1.Text = "Politica A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(347, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 41);
            this.label2.TabIndex = 22;
            this.label2.Text = "Politica B";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(682, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 30);
            this.label4.TabIndex = 29;
            this.label4.Text = "2 Frascos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(682, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 41);
            this.label5.TabIndex = 28;
            this.label5.Text = "Politica A";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(834, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 30);
            this.label6.TabIndex = 31;
            this.label6.Text = "3 frascos";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(834, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 41);
            this.label8.TabIndex = 30;
            this.label8.Text = "Politica B";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_resultados
            // 
            this.lbl_resultados.Location = new System.Drawing.Point(12, 784);
            this.lbl_resultados.Name = "lbl_resultados";
            this.lbl_resultados.Size = new System.Drawing.Size(766, 38);
            this.lbl_resultados.TabIndex = 32;
            this.lbl_resultados.Text = "Resultados de la simulación politica elegida";
            this.lbl_resultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_hasta);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_desde);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 115);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rango a mostrar";
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
            this.label55.Size = new System.Drawing.Size(73, 17);
            this.label55.TabIndex = 96;
            this.label55.Text = "Prec Venta";
            // 
            // txt_precVenta
            // 
            this.txt_precVenta.Enabled = false;
            this.txt_precVenta.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_precVenta.Location = new System.Drawing.Point(87, 32);
            this.txt_precVenta.Name = "txt_precVenta";
            this.txt_precVenta.Size = new System.Drawing.Size(36, 25);
            this.txt_precVenta.TabIndex = 97;
            this.txt_precVenta.Text = "1";
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
            this.groupBox3.Location = new System.Drawing.Point(804, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 106);
            this.groupBox3.TabIndex = 98;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precios por cada rosa";
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
            this.txt_gramosFrasco.Text = "0,1";
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
            this.txt_horasTurno.Text = "0,09";
            this.txt_horasTurno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_horasTurno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precCementerio_KeyPress);
            // 
            // txt_precCompra
            // 
            this.txt_precCompra.Enabled = false;
            this.txt_precCompra.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_precCompra.Location = new System.Drawing.Point(214, 33);
            this.txt_precCompra.Name = "txt_precCompra";
            this.txt_precCompra.Size = new System.Drawing.Size(36, 25);
            this.txt_precCompra.TabIndex = 99;
            this.txt_precCompra.Text = "0,75";
            this.txt_precCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_precCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precCompra_KeyPress);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(124, 37);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(86, 17);
            this.label56.TabIndex = 98;
            this.label56.Text = "Prec Compra";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 99;
            this.button1.Text = "Habilitar Precios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_resultados_D
            // 
            this.lbl_resultados_D.Location = new System.Drawing.Point(12, 835);
            this.lbl_resultados_D.Name = "lbl_resultados_D";
            this.lbl_resultados_D.Size = new System.Drawing.Size(766, 38);
            this.lbl_resultados_D.TabIndex = 100;
            this.lbl_resultados_D.Text = "Resultados de la simulación pto d";
            this.lbl_resultados_D.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.radioButton4);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(508, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 71);
            this.groupBox4.TabIndex = 101;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Politicas de compras";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(71, 35);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 21);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "PolitB";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(6, 35);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(59, 21);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "PolitA";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(997, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(168, 71);
            this.groupBox5.TabIndex = 106;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Politicas periodo de compras";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(71, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "PolitB";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(6, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 21);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "PolitA";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(1323, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 30);
            this.label11.TabIndex = 105;
            this.label11.Text = "3 días";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(1323, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 41);
            this.label12.TabIndex = 104;
            this.label12.Text = "Politica B";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(1171, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 30);
            this.label13.TabIndex = 103;
            this.label13.Text = "2 días";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(1171, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 41);
            this.label14.TabIndex = 102;
            this.label14.Text = "Politica A";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 902);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_resultados_D);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_resultados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_reservaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_simulacion);
            this.Controls.Add(this.txt_cantDias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_generarSimulacion);
            this.Name = "Form1";
            this.Text = "Form1";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cantDias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_generarSimulacion;
        private System.Windows.Forms.DataGridView dgv_simulacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Pb1;
        private System.Windows.Forms.RadioButton rb_Pa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_reservaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.Label lbl_resultados_D;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

