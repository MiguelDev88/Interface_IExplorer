namespace IExplorer
{
    partial class frmIExplorer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.iExplorer_Data1 = new IExplorer.IExplorer_Data();
            this.SuspendLayout();
            // 
            // iExplorer_Data1
            // 
            this.iExplorer_Data1.Location = new System.Drawing.Point(-23, -46);
            this.iExplorer_Data1.Name = "iExplorer_Data1";
            this.iExplorer_Data1.Size = new System.Drawing.Size(407, 292);
            this.iExplorer_Data1.TabIndex = 0;
            // 
            // frmIExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 358);
            this.Controls.Add(this.iExplorer_Data1);
            this.Name = "frmIExplorer";
            this.Text = "IExplorer";
            this.ResumeLayout(false);

        }

        #endregion

        private IExplorer_Data iExplorer_Data1;
    }
}