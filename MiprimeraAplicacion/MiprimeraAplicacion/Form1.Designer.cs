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
            this.SuspendLayout();
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.Location = new System.Drawing.Point(78, 55);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(42, 16);
            this.lblserie.TabIndex = 0;
            this.lblserie.Text = "Serie:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(301, 158);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(114, 58);
            this.btnProcesar.TabIndex = 1;
            this.btnProcesar.Text = "Prosesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // ltsValores
            // 
            this.ltsValores.FormattingEnabled = true;
            this.ltsValores.ItemHeight = 16;
            this.ltsValores.Location = new System.Drawing.Point(36, 139);
            this.ltsValores.Name = "ltsValores";
            this.ltsValores.Size = new System.Drawing.Size(211, 148);
            this.ltsValores.TabIndex = 2;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(147, 52);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(100, 22);
            this.txtSerie.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 403);
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
    }
}

