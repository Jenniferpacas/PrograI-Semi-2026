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
            this.lblserie = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.ltsValores = new System.Windows.Forms.ListBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblserie.Location = new System.Drawing.Point(32, 52);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(59, 20);
            this.lblserie.TabIndex = 0;
            this.lblserie.Text = "Serie:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.Location = new System.Drawing.Point(360, 116);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(114, 58);
            this.btnProcesar.TabIndex = 1;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // ltsValores
            // 
            this.ltsValores.FormattingEnabled = true;
            this.ltsValores.ItemHeight = 16;
            this.ltsValores.Location = new System.Drawing.Point(36, 116);
            this.ltsValores.Name = "ltsValores";
            this.ltsValores.Size = new System.Drawing.Size(289, 180);
            this.ltsValores.TabIndex = 2;
            this.ltsValores.SelectedIndexChanged += new System.EventHandler(this.ltsValores_SelectedIndexChanged);
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(97, 52);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(288, 22);
            this.txtSerie.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(360, 215);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(114, 59);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 331);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.ltsValores);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.lblserie);
            this.Name = "Form1";
            this.Text = "Combersores de longitud ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblserie;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.ListBox ltsValores;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

