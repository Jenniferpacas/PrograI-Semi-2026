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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMonto = new System.Windows.Forms.TabPage();
            this.tabArea = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboDe = new System.Windows.Forms.ComboBox();
            this.cboA = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabMonto.SuspendLayout();
            this.tabArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMonto);
            this.tabControl1.Controls.Add(this.tabArea);
            this.tabControl1.Location = new System.Drawing.Point(16, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(618, 359);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMonto
            // 
            this.tabMonto.Controls.Add(this.lblRespuesta);
            this.tabMonto.Controls.Add(this.btnCalcular);
            this.tabMonto.Controls.Add(this.txtmonto);
            this.tabMonto.Controls.Add(this.label1);
            this.tabMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMonto.Location = new System.Drawing.Point(4, 25);
            this.tabMonto.Name = "tabMonto";
            this.tabMonto.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonto.Size = new System.Drawing.Size(610, 330);
            this.tabMonto.TabIndex = 0;
            this.tabMonto.Text = "Monto economico";
            this.tabMonto.UseVisualStyleBackColor = true;
            this.tabMonto.Click += new System.EventHandler(this.tabMonto_Click);
            // 
            // tabArea
            // 
            this.tabArea.Controls.Add(this.cboA);
            this.tabArea.Controls.Add(this.cboDe);
            this.tabArea.Controls.Add(this.txtCantidad);
            this.tabArea.Controls.Add(this.btnConvertir);
            this.tabArea.Controls.Add(this.lblResultado);
            this.tabArea.Controls.Add(this.lblA);
            this.tabArea.Controls.Add(this.lblDe);
            this.tabArea.Controls.Add(this.lblcantidad);
            this.tabArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabArea.Location = new System.Drawing.Point(4, 25);
            this.tabArea.Name = "tabArea";
            this.tabArea.Padding = new System.Windows.Forms.Padding(3);
            this.tabArea.Size = new System.Drawing.Size(610, 330);
            this.tabArea.TabIndex = 1;
            this.tabArea.Text = "Conversor de area ";
            this.tabArea.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto de actividad economica:";
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(290, 34);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(173, 24);
            this.txtmonto.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(42, 76);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(155, 93);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(35, 201);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(113, 18);
            this.lblRespuesta.TabIndex = 3;
            this.lblRespuesta.Text = "Valor a pagar:";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(54, 37);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(79, 18);
            this.lblcantidad.TabIndex = 0;
            this.lblcantidad.Text = "Cantidad:";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(54, 108);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(34, 18);
            this.lblDe.TabIndex = 1;
            this.lblDe.Text = "De:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(350, 108);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(18, 18);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "A";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(54, 260);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(89, 18);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado:";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(48, 154);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(129, 65);
            this.btnConvertir.TabIndex = 4;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(142, 40);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(167, 24);
            this.txtCantidad.TabIndex = 5;
            // 
            // cboDe
            // 
            this.cboDe.FormattingEnabled = true;
            this.cboDe.Items.AddRange(new object[] {
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada",
            "Metro Cuadrado",
            "Tareas",
            "Manzana",
            "Hectárea"});
            this.cboDe.Location = new System.Drawing.Point(99, 105);
            this.cboDe.Name = "cboDe";
            this.cboDe.Size = new System.Drawing.Size(194, 26);
            this.cboDe.TabIndex = 6;
            // 
            // cboA
            // 
            this.cboA.FormattingEnabled = true;
            this.cboA.Items.AddRange(new object[] {
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada",
            "Metro Cuadrado",
            "Tareas",
            "Manzana",
            "Hectárea"});
            this.cboA.Location = new System.Drawing.Point(374, 105);
            this.cboA.Name = "cboA";
            this.cboA.Size = new System.Drawing.Size(182, 26);
            this.cboA.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 432);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Parcial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabMonto.ResumeLayout(false);
            this.tabMonto.PerformLayout();
            this.tabArea.ResumeLayout(false);
            this.tabArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMonto;
        private System.Windows.Forms.TabPage tabArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.ComboBox cboA;
        private System.Windows.Forms.ComboBox cboDe;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnConvertir;
    }
}

