namespace MiprimeraAplicacion
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
            this.lblMetros = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtMetros = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVolumenregistrado = new System.Windows.Forms.Label();
            this.lblTarifaaplicada = new System.Windows.Forms.Label();
            this.lblcobro = new System.Windows.Forms.Label();
            this.lblservicios = new System.Windows.Forms.Label();
            this.txtVolumen = new System.Windows.Forms.TextBox();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtAlcantarillado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÁLCULO DE AGUA POTABLE ";
            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetros.Location = new System.Drawing.Point(118, 81);
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(384, 22);
            this.lblMetros.TabIndex = 1;
            this.lblMetros.Text = "Consumo del mes en metros cúbicos (m³):";
            this.lblMetros.Click += new System.EventHandler(this.lblMetros_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(59, 411);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(143, 22);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor a pagar: ";
            this.lblValor.Click += new System.EventHandler(this.lblValor_Click);
            // 
            // txtMetros
            // 
            this.txtMetros.Location = new System.Drawing.Point(146, 118);
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.Size = new System.Drawing.Size(330, 22);
            this.txtMetros.TabIndex = 3;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(63, 436);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(180, 22);
            this.txtValor.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(174, 146);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(273, 43);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular Recibo";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(438, 419);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(118, 39);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Detalle del consumo";
            // 
            // lblVolumenregistrado
            // 
            this.lblVolumenregistrado.AutoSize = true;
            this.lblVolumenregistrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumenregistrado.Location = new System.Drawing.Point(59, 242);
            this.lblVolumenregistrado.Name = "lblVolumenregistrado";
            this.lblVolumenregistrado.Size = new System.Drawing.Size(195, 22);
            this.lblVolumenregistrado.TabIndex = 8;
            this.lblVolumenregistrado.Text = "Volumen registrado: ";
            // 
            // lblTarifaaplicada
            // 
            this.lblTarifaaplicada.AutoSize = true;
            this.lblTarifaaplicada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarifaaplicada.Location = new System.Drawing.Point(59, 286);
            this.lblTarifaaplicada.Name = "lblTarifaaplicada";
            this.lblTarifaaplicada.Size = new System.Drawing.Size(219, 22);
            this.lblTarifaaplicada.TabIndex = 9;
            this.lblTarifaaplicada.Text = "Tarifa aplicada por m³: ";
            // 
            // lblcobro
            // 
            this.lblcobro.AutoSize = true;
            this.lblcobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcobro.Location = new System.Drawing.Point(59, 325);
            this.lblcobro.Name = "lblcobro";
            this.lblcobro.Size = new System.Drawing.Size(234, 22);
            this.lblcobro.TabIndex = 10;
            this.lblcobro.Text = "Cobro por m³ consumido:";
            // 
            // lblservicios
            // 
            this.lblservicios.AutoSize = true;
            this.lblservicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservicios.Location = new System.Drawing.Point(59, 359);
            this.lblservicios.Name = "lblservicios";
            this.lblservicios.Size = new System.Drawing.Size(258, 22);
            this.lblservicios.TabIndex = 11;
            this.lblservicios.Text = "Servicios de alcantarillado: ";
            // 
            // txtVolumen
            // 
            this.txtVolumen.Location = new System.Drawing.Point(260, 242);
            this.txtVolumen.Name = "txtVolumen";
            this.txtVolumen.Size = new System.Drawing.Size(152, 22);
            this.txtVolumen.TabIndex = 12;
            // 
            // txtTarifa
            // 
            this.txtTarifa.Location = new System.Drawing.Point(284, 286);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(152, 22);
            this.txtTarifa.TabIndex = 13;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(299, 325);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(152, 22);
            this.txtConsumo.TabIndex = 14;
            // 
            // txtAlcantarillado
            // 
            this.txtAlcantarillado.Location = new System.Drawing.Point(323, 361);
            this.txtAlcantarillado.Name = "txtAlcantarillado";
            this.txtAlcantarillado.Size = new System.Drawing.Size(152, 22);
            this.txtAlcantarillado.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 502);
            this.Controls.Add(this.txtAlcantarillado);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.txtTarifa);
            this.Controls.Add(this.txtVolumen);
            this.Controls.Add(this.lblservicios);
            this.Controls.Add(this.lblcobro);
            this.Controls.Add(this.lblTarifaaplicada);
            this.Controls.Add(this.lblVolumenregistrado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtMetros);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblMetros);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CÁLCULO DE AGUA POTABLE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMetros;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtMetros;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVolumenregistrado;
        private System.Windows.Forms.Label lblTarifaaplicada;
        private System.Windows.Forms.Label lblcobro;
        private System.Windows.Forms.Label lblservicios;
        private System.Windows.Forms.TextBox txtVolumen;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtAlcantarillado;
    }
}

