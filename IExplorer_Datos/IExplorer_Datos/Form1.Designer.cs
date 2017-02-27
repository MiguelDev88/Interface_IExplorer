namespace IExplorer_Datos
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
            this.pbPhone = new System.Windows.Forms.PictureBox();
            this.lbPhoneName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPhone
            // 
            this.pbPhone.Location = new System.Drawing.Point(124, 37);
            this.pbPhone.Name = "pbPhone";
            this.pbPhone.Size = new System.Drawing.Size(100, 180);
            this.pbPhone.TabIndex = 0;
            this.pbPhone.TabStop = false;
            // 
            // lbPhoneName
            // 
            this.lbPhoneName.AutoSize = true;
            this.lbPhoneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneName.Location = new System.Drawing.Point(277, 40);
            this.lbPhoneName.Name = "lbPhoneName";
            this.lbPhoneName.Size = new System.Drawing.Size(155, 24);
            this.lbPhoneName.TabIndex = 1;
            this.lbPhoneName.Text = "Miguel\'s Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Capacity:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPhoneName);
            this.Controls.Add(this.pbPhone);
            this.Name = "Form1";
            this.Text = "IExplorer_Data";
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPhone;
        private System.Windows.Forms.Label lbPhoneName;
        private System.Windows.Forms.Label label1;
    }
}

