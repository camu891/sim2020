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
            this.pol_20fras = new System.Windows.Forms.RadioButton();
            this.pol_10Fras = new System.Windows.Forms.RadioButton();
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
            this.pol_3Fras = new System.Windows.Forms.RadioButton();
            this.pol_2Fras = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pol_3dias = new System.Windows.Forms.RadioButton();
            this.pol_2dias = new System.Windows.Forms.RadioButton();
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
            this.groupBox3.Location = new System.Drawing.Point(804, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 106);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 902);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lbl_resultados_D);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_resultados);
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
        private System.Windows.Forms.Label lbl_resultados_D;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton pol_3Fras;
        private System.Windows.Forms.RadioButton pol_2Fras;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton pol_3dias;
        private System.Windows.Forms.RadioButton pol_2dias;
    }
}

