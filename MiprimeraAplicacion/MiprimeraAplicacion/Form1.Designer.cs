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
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblcondicion = new System.Windows.Forms.Label();
            this.lblprioridad = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtSintomas = new System.Windows.Forms.TextBox();
            this.cboPrioridad = new System.Windows.Forms.ComboBox();
            this.ltsRespuesta = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnClasificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTIÓN DE TIEMPO EN SALUD";
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePaciente.Location = new System.Drawing.Point(27, 77);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(206, 20);
            this.lblNombrePaciente.TabIndex = 1;
            this.lblNombrePaciente.Text = " Nombre del paciente:  ";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledad.Location = new System.Drawing.Point(142, 126);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(69, 20);
            this.lbledad.TabIndex = 2;
            this.lbledad.Text = "Edad:  ";
            // 
            // lblcondicion
            // 
            this.lblcondicion.AutoSize = true;
            this.lblcondicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcondicion.Location = new System.Drawing.Point(15, 180);
            this.lblcondicion.Name = "lblcondicion";
            this.lblcondicion.Size = new System.Drawing.Size(209, 20);
            this.lblcondicion.TabIndex = 3;
            this.lblcondicion.Text = "Síntomas / condición:   ";
            // 
            // lblprioridad
            // 
            this.lblprioridad.AutoSize = true;
            this.lblprioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprioridad.Location = new System.Drawing.Point(42, 235);
            this.lblprioridad.Name = "lblprioridad";
            this.lblprioridad.Size = new System.Drawing.Size(169, 20);
            this.lblprioridad.TabIndex = 4;
            this.lblprioridad.Text = "Nivel de prioridad: ";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(42, 287);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(195, 20);
            this.lblresultado.TabIndex = 5;
            this.lblresultado.Text = "Resultado del Triage: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(262, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(242, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(248, 126);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 22);
            this.txtEdad.TabIndex = 7;
            // 
            // txtSintomas
            // 
            this.txtSintomas.Location = new System.Drawing.Point(240, 235);
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(185, 22);
            this.txtSintomas.TabIndex = 8;
            // 
            // cboPrioridad
            // 
            this.cboPrioridad.FormattingEnabled = true;
            this.cboPrioridad.Location = new System.Drawing.Point(233, 180);
            this.cboPrioridad.Name = "cboPrioridad";
            this.cboPrioridad.Size = new System.Drawing.Size(194, 24);
            this.cboPrioridad.TabIndex = 9;
            // 
            // ltsRespuesta
            // 
            this.ltsRespuesta.FormattingEnabled = true;
            this.ltsRespuesta.ItemHeight = 16;
            this.ltsRespuesta.Location = new System.Drawing.Point(28, 327);
            this.ltsRespuesta.Name = "ltsRespuesta";
            this.ltsRespuesta.Size = new System.Drawing.Size(397, 132);
            this.ltsRespuesta.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(458, 355);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(152, 56);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnClasificar
            // 
            this.btnClasificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasificar.Location = new System.Drawing.Point(458, 235);
            this.btnClasificar.Name = "btnClasificar";
            this.btnClasificar.Size = new System.Drawing.Size(152, 72);
            this.btnClasificar.TabIndex = 12;
            this.btnClasificar.Text = "Clasificar";
            this.btnClasificar.UseVisualStyleBackColor = true;
            this.btnClasificar.Click += new System.EventHandler(this.btnClasificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 502);
            this.Controls.Add(this.btnClasificar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.ltsRespuesta);
            this.Controls.Add(this.cboPrioridad);
            this.Controls.Add(this.txtSintomas);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblprioridad);
            this.Controls.Add(this.lblcondicion);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Gestion del tiempo ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblcondicion;
        private System.Windows.Forms.Label lblprioridad;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtSintomas;
        private System.Windows.Forms.ComboBox cboPrioridad;
        private System.Windows.Forms.ListBox ltsRespuesta;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnClasificar;
    }
}

