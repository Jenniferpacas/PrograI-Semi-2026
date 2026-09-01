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
            this.lblsueldo = new System.Windows.Forms.Label();
            this.lblSSS = new System.Windows.Forms.Label();
            this.lblAFP = new System.Windows.Forms.Label();
            this.lblISR = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblSueldoneto = new System.Windows.Forms.Label();
            this.txtsueldo = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtISR = new System.Windows.Forms.TextBox();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.txtSueldoNeto = new System.Windows.Forms.TextBox();
            this.txtISSS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deducciones de Ley";
            // 
            // lblsueldo
            // 
            this.lblsueldo.AutoSize = true;
            this.lblsueldo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsueldo.Location = new System.Drawing.Point(63, 119);
            this.lblsueldo.Name = "lblsueldo";
            this.lblsueldo.Size = new System.Drawing.Size(166, 26);
            this.lblsueldo.TabIndex = 1;
            this.lblsueldo.Text = "Sueldo mensual:";
            // 
            // lblSSS
            // 
            this.lblSSS.AutoSize = true;
            this.lblSSS.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSS.Location = new System.Drawing.Point(83, 184);
            this.lblSSS.Name = "lblSSS";
            this.lblSSS.Size = new System.Drawing.Size(65, 26);
            this.lblSSS.TabIndex = 2;
            this.lblSSS.Text = "ISSS:";
            // 
            // lblAFP
            // 
            this.lblAFP.AutoSize = true;
            this.lblAFP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAFP.Location = new System.Drawing.Point(83, 277);
            this.lblAFP.Name = "lblAFP";
            this.lblAFP.Size = new System.Drawing.Size(60, 26);
            this.lblAFP.TabIndex = 3;
            this.lblAFP.Text = "AFP:";
            // 
            // lblISR
            // 
            this.lblISR.AutoSize = true;
            this.lblISR.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISR.Location = new System.Drawing.Point(83, 230);
            this.lblISR.Name = "lblISR";
            this.lblISR.Size = new System.Drawing.Size(54, 26);
            this.lblISR.TabIndex = 4;
            this.lblISR.Text = "ISR:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(83, 326);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(185, 26);
            this.lbltotal.TabIndex = 5;
            this.lbltotal.Text = "Total deducciones:";
            // 
            // lblSueldoneto
            // 
            this.lblSueldoneto.AutoSize = true;
            this.lblSueldoneto.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoneto.Location = new System.Drawing.Point(83, 375);
            this.lblSueldoneto.Name = "lblSueldoneto";
            this.lblSueldoneto.Size = new System.Drawing.Size(133, 26);
            this.lblSueldoneto.TabIndex = 6;
            this.lblSueldoneto.Text = "Sueldo Neto:";
            // 
            // txtsueldo
            // 
            this.txtsueldo.Location = new System.Drawing.Point(235, 123);
            this.txtsueldo.Name = "txtsueldo";
            this.txtsueldo.Size = new System.Drawing.Size(182, 22);
            this.txtsueldo.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(626, 240);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(184, 115);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtISR
            // 
            this.txtISR.Location = new System.Drawing.Point(265, 230);
            this.txtISR.Name = "txtISR";
            this.txtISR.ReadOnly = true;
            this.txtISR.Size = new System.Drawing.Size(182, 22);
            this.txtISR.TabIndex = 9;
            // 
            // txtAFP
            // 
            this.txtAFP.Location = new System.Drawing.Point(265, 281);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.ReadOnly = true;
            this.txtAFP.Size = new System.Drawing.Size(182, 22);
            this.txtAFP.TabIndex = 10;
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.Location = new System.Drawing.Point(265, 326);
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.ReadOnly = true;
            this.txtTOTAL.Size = new System.Drawing.Size(182, 22);
            this.txtTOTAL.TabIndex = 11;
            // 
            // txtSueldoNeto
            // 
            this.txtSueldoNeto.Location = new System.Drawing.Point(265, 375);
            this.txtSueldoNeto.Name = "txtSueldoNeto";
            this.txtSueldoNeto.ReadOnly = true;
            this.txtSueldoNeto.Size = new System.Drawing.Size(182, 22);
            this.txtSueldoNeto.TabIndex = 12;
            // 
            // txtISSS
            // 
            this.txtISSS.Location = new System.Drawing.Point(265, 184);
            this.txtISSS.Name = "txtISSS";
            this.txtISSS.ReadOnly = true;
            this.txtISSS.Size = new System.Drawing.Size(182, 22);
            this.txtISSS.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 502);
            this.Controls.Add(this.txtISSS);
            this.Controls.Add(this.txtSueldoNeto);
            this.Controls.Add(this.txtTOTAL);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.txtISR);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtsueldo);
            this.Controls.Add(this.lblSueldoneto);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblISR);
            this.Controls.Add(this.lblAFP);
            this.Controls.Add(this.lblSSS);
            this.Controls.Add(this.lblsueldo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Deducciones de ley";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsueldo;
        private System.Windows.Forms.Label lblSSS;
        private System.Windows.Forms.Label lblAFP;
        private System.Windows.Forms.Label lblISR;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblSueldoneto;
        private System.Windows.Forms.TextBox txtsueldo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtISR;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.TextBox txtTOTAL;
        private System.Windows.Forms.TextBox txtSueldoNeto;
        private System.Windows.Forms.TextBox txtISSS;
    }
}

