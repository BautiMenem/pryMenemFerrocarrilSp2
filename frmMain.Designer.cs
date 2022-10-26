namespace pryMenemFerrocarrilSp2
{
    partial class frmMain
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
            this.lblDias = new System.Windows.Forms.Label();
            this.nudDias = new System.Windows.Forms.NumericUpDown();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.mrcCosto = new System.Windows.Forms.GroupBox();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).BeginInit();
            this.mrcCosto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(137, 84);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(30, 13);
            this.lblDias.TabIndex = 0;
            this.lblDias.Text = "Días";
            // 
            // nudDias
            // 
            this.nudDias.Location = new System.Drawing.Point(213, 82);
            this.nudDias.Name = "nudDias";
            this.nudDias.Size = new System.Drawing.Size(74, 20);
            this.nudDias.TabIndex = 1;
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(137, 126);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(51, 13);
            this.lblDistancia.TabIndex = 2;
            this.lblDistancia.Text = "Distancia";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(213, 126);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(74, 20);
            this.txtDistancia.TabIndex = 3;
            // 
            // mrcCosto
            // 
            this.mrcCosto.Controls.Add(this.lblTotal);
            this.mrcCosto.Controls.Add(this.lblPrecio);
            this.mrcCosto.Location = new System.Drawing.Point(117, 179);
            this.mrcCosto.Name = "mrcCosto";
            this.mrcCosto.Size = new System.Drawing.Size(217, 100);
            this.mrcCosto.TabIndex = 4;
            this.mrcCosto.TabStop = false;
            this.mrcCosto.Text = "Costo";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Location = new System.Drawing.Point(293, 129);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(22, 13);
            this.lblKm.TabIndex = 5;
            this.lblKm.Text = "Km";
            this.lblKm.Click += new System.EventHandler(this.lblKm_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(14, 34);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 13);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio Km";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(17, 64);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.mrcCosto);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.nudDias);
            this.Controls.Add(this.lblDias);
            this.Name = "frmMain";
            this.Text = "Ferrocarril - Calculo";
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).EndInit();
            this.mrcCosto.ResumeLayout(false);
            this.mrcCosto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.NumericUpDown nudDias;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.GroupBox mrcCosto;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrecio;
    }
}

