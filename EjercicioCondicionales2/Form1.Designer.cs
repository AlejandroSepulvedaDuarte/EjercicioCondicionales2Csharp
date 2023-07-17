namespace EjercicioCondicionales2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHorasTrabajadas = new System.Windows.Forms.TextBox();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbResumenPago = new System.Windows.Forms.GroupBox();
            this.lblSalarioNeto = new System.Windows.Forms.Label();
            this.lbl_incremento = new System.Windows.Forms.Label();
            this.lblSalud = new System.Windows.Forms.Label();
            this.lblSalariobase = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbResumenPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cálculo de salario empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresa las horas trabjadas del empleado: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingresa el  valor de la hora:  ";
            // 
            // txtHorasTrabajadas
            // 
            this.txtHorasTrabajadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtHorasTrabajadas.Location = new System.Drawing.Point(511, 69);
            this.txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            this.txtHorasTrabajadas.Size = new System.Drawing.Size(276, 34);
            this.txtHorasTrabajadas.TabIndex = 4;
            // 
            // txtValorHora
            // 
            this.txtValorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorHora.Location = new System.Drawing.Point(511, 116);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(276, 34);
            this.txtValorHora.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCalcular.Location = new System.Drawing.Point(511, 169);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(135, 43);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gbResumenPago
            // 
            this.gbResumenPago.Controls.Add(this.lblSalarioNeto);
            this.gbResumenPago.Controls.Add(this.lbl_incremento);
            this.gbResumenPago.Controls.Add(this.lblSalud);
            this.gbResumenPago.Controls.Add(this.lblSalariobase);
            this.gbResumenPago.Controls.Add(this.label7);
            this.gbResumenPago.Controls.Add(this.label6);
            this.gbResumenPago.Controls.Add(this.label5);
            this.gbResumenPago.Controls.Add(this.label4);
            this.gbResumenPago.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResumenPago.Location = new System.Drawing.Point(17, 233);
            this.gbResumenPago.Name = "gbResumenPago";
            this.gbResumenPago.Size = new System.Drawing.Size(753, 205);
            this.gbResumenPago.TabIndex = 7;
            this.gbResumenPago.TabStop = false;
            this.gbResumenPago.Text = "Resumen de pago";
            this.gbResumenPago.Visible = false;
            // 
            // lblSalarioNeto
            // 
            this.lblSalarioNeto.AutoSize = true;
            this.lblSalarioNeto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioNeto.Location = new System.Drawing.Point(166, 147);
            this.lblSalarioNeto.Name = "lblSalarioNeto";
            this.lblSalarioNeto.Size = new System.Drawing.Size(21, 24);
            this.lblSalarioNeto.TabIndex = 7;
            this.lblSalarioNeto.Text = "0";
            // 
            // lbl_incremento
            // 
            this.lbl_incremento.AutoSize = true;
            this.lbl_incremento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_incremento.Location = new System.Drawing.Point(166, 106);
            this.lbl_incremento.Name = "lbl_incremento";
            this.lbl_incremento.Size = new System.Drawing.Size(21, 24);
            this.lbl_incremento.TabIndex = 6;
            this.lbl_incremento.Text = "0";
            // 
            // lblSalud
            // 
            this.lblSalud.AutoSize = true;
            this.lblSalud.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalud.Location = new System.Drawing.Point(166, 65);
            this.lblSalud.Name = "lblSalud";
            this.lblSalud.Size = new System.Drawing.Size(21, 24);
            this.lblSalud.TabIndex = 5;
            this.lblSalud.Text = "0";
            // 
            // lblSalariobase
            // 
            this.lblSalariobase.AutoSize = true;
            this.lblSalariobase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalariobase.Location = new System.Drawing.Point(166, 30);
            this.lblSalariobase.Name = "lblSalariobase";
            this.lblSalariobase.Size = new System.Drawing.Size(21, 24);
            this.lblSalariobase.TabIndex = 4;
            this.lblSalariobase.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Salario a pagar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Incremento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pago salud";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Salario base";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLimpiar.Location = new System.Drawing.Point(652, 169);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(135, 43);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gbResumenPago);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.txtHorasTrabajadas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbResumenPago.ResumeLayout(false);
            this.gbResumenPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHorasTrabajadas;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gbResumenPago;
        private System.Windows.Forms.Label lblSalarioNeto;
        private System.Windows.Forms.Label lbl_incremento;
        private System.Windows.Forms.Label lblSalud;
        private System.Windows.Forms.Label lblSalariobase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

