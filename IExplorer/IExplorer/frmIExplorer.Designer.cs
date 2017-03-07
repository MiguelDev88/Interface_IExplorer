namespace IExplorer
{
    partial class frmIExplorer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIExplorer));
            this.iconosTreeview = new System.Windows.Forms.ImageList(this.components);
            this.toolBarMain = new System.Windows.Forms.ToolStrip();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.btnRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cbPhonePath = new System.Windows.Forms.ToolStripComboBox();
            this.cbMenu = new System.Windows.Forms.ToolStripComboBox();
            this.lbSearch = new System.Windows.Forms.ToolStripLabel();
            this.tvSearch = new System.Windows.Forms.ToolStripTextBox();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelRightBottom = new System.Windows.Forms.Panel();
            this.panelRightCenter = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnDataCat = new System.Windows.Forms.Button();
            this.btnFilesCat = new System.Windows.Forms.Button();
            this.btnMediaCat = new System.Windows.Forms.Button();
            this.statusHelp = new System.Windows.Forms.StatusStrip();
            this.lbHelp = new System.Windows.Forms.ToolStripStatusLabel();
            this.iconosListView = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iexplorerDatos = new IExplorer.Observador();
            this.treeNavigator = new IExplorer.Sujeto();
            this.toolBarMain.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelRightCenter.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.statusHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconosTreeview
            // 
            this.iconosTreeview.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconosTreeview.ImageStream")));
            this.iconosTreeview.TransparentColor = System.Drawing.Color.Transparent;
            this.iconosTreeview.Images.SetKeyName(0, "compas-de-dibujo.png");
            this.iconosTreeview.Images.SetKeyName(1, "contorno-de-corchea.png");
            this.iconosTreeview.Images.SetKeyName(2, "deshacer-flecha.png");
            this.iconosTreeview.Images.SetKeyName(3, "estrella.png");
            this.iconosTreeview.Images.SetKeyName(4, "imagen.png");
            this.iconosTreeview.Images.SetKeyName(5, "llamada-smartphone .png");
            this.iconosTreeview.Images.SetKeyName(6, "silueta-del-icono-de-hogar.png");
            // 
            // toolBarMain
            // 
            this.toolBarMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUndo,
            this.btnRedo,
            this.toolStripSeparator1,
            this.cbPhonePath,
            this.cbMenu,
            this.lbSearch,
            this.tvSearch});
            this.toolBarMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolBarMain.Location = new System.Drawing.Point(0, 24);
            this.toolBarMain.Name = "toolBarMain";
            this.toolBarMain.Size = new System.Drawing.Size(969, 25);
            this.toolBarMain.Stretch = true;
            this.toolBarMain.TabIndex = 3;
            this.toolBarMain.Text = "toolStrip1";
            this.toolBarMain.Resize += new System.EventHandler(this.toolStrip1_Resize);
            // 
            // btnUndo
            // 
            this.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUndo.Image = global::IExplorer.Properties.Resources.boton_de_reproduccionmirror;
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(23, 22);
            this.btnUndo.Text = "toolStripButton1";
            // 
            // btnRedo
            // 
            this.btnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRedo.Image = global::IExplorer.Properties.Resources.boton_de_reproduccion;
            this.btnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(23, 22);
            this.btnRedo.Text = "toolStripButton2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cbPhonePath
            // 
            this.cbPhonePath.AutoSize = false;
            this.cbPhonePath.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cbPhonePath.Name = "cbPhonePath";
            this.cbPhonePath.Size = new System.Drawing.Size(100, 23);
            // 
            // cbMenu
            // 
            this.cbMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cbMenu.AutoSize = false;
            this.cbMenu.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.cbMenu.Name = "cbMenu";
            this.cbMenu.Size = new System.Drawing.Size(30, 23);
            // 
            // lbSearch
            // 
            this.lbSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbSearch.AutoSize = false;
            this.lbSearch.Image = global::IExplorer.Properties.Resources.busqueda;
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(22, 22);
            // 
            // tvSearch
            // 
            this.tvSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tvSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tvSearch.Name = "tvSearch";
            this.tvSearch.Size = new System.Drawing.Size(250, 25);
            this.tvSearch.Text = "asdasd";
            this.tvSearch.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(969, 24);
            this.menuMain.TabIndex = 25;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataToolStripMenuItem,
            this.saveDataToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadDataToolStripMenuItem
            // 
            this.loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            this.loadDataToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.loadDataToolStripMenuItem.Text = "&Load Data";
            // 
            // saveDataToolStripMenuItem
            // 
            this.saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            this.saveDataToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.saveDataToolStripMenuItem.Text = "&Save Data";
            this.saveDataToolStripMenuItem.Click += new System.EventHandler(this.saveDataToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.languageToolStripMenuItem.Text = "&Language";
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.panelRightBottom);
            this.panelRight.Controls.Add(this.panelRightCenter);
            this.panelRight.Controls.Add(this.iexplorerDatos);
            this.panelRight.Location = new System.Drawing.Point(232, 56);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(738, 515);
            this.panelRight.TabIndex = 27;
            // 
            // panelRightBottom
            // 
            this.panelRightBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRightBottom.Location = new System.Drawing.Point(3, 286);
            this.panelRightBottom.Name = "panelRightBottom";
            this.panelRightBottom.Size = new System.Drawing.Size(742, 226);
            this.panelRightBottom.TabIndex = 4;
            // 
            // panelRightCenter
            // 
            this.panelRightCenter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRightCenter.BackColor = System.Drawing.Color.White;
            this.panelRightCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRightCenter.Controls.Add(this.panelButtons);
            this.panelRightCenter.Location = new System.Drawing.Point(-8, 238);
            this.panelRightCenter.Name = "panelRightCenter";
            this.panelRightCenter.Size = new System.Drawing.Size(747, 47);
            this.panelRightCenter.TabIndex = 3;
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelButtons.Controls.Add(this.btnDataCat);
            this.panelButtons.Controls.Add(this.btnFilesCat);
            this.panelButtons.Controls.Add(this.btnMediaCat);
            this.panelButtons.Location = new System.Drawing.Point(237, 3);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(338, 38);
            this.panelButtons.TabIndex = 3;
            // 
            // btnDataCat
            // 
            this.btnDataCat.BackColor = System.Drawing.Color.White;
            this.btnDataCat.FlatAppearance.BorderSize = 0;
            this.btnDataCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataCat.Image = global::IExplorer.Properties.Resources.la_computacion_en_nube__1_;
            this.btnDataCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataCat.Location = new System.Drawing.Point(112, 0);
            this.btnDataCat.Name = "btnDataCat";
            this.btnDataCat.Size = new System.Drawing.Size(111, 37);
            this.btnDataCat.TabIndex = 1;
            this.btnDataCat.Text = "       Data";
            this.btnDataCat.UseVisualStyleBackColor = false;
            // 
            // btnFilesCat
            // 
            this.btnFilesCat.BackColor = System.Drawing.Color.White;
            this.btnFilesCat.FlatAppearance.BorderSize = 0;
            this.btnFilesCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilesCat.Image = global::IExplorer.Properties.Resources.carpeta;
            this.btnFilesCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilesCat.Location = new System.Drawing.Point(224, 0);
            this.btnFilesCat.Name = "btnFilesCat";
            this.btnFilesCat.Size = new System.Drawing.Size(111, 37);
            this.btnFilesCat.TabIndex = 2;
            this.btnFilesCat.Text = "        Files";
            this.btnFilesCat.UseVisualStyleBackColor = false;
            this.btnFilesCat.Click += new System.EventHandler(this.btnFilesCat_Click);
            // 
            // btnMediaCat
            // 
            this.btnMediaCat.BackColor = System.Drawing.Color.White;
            this.btnMediaCat.FlatAppearance.BorderSize = 0;
            this.btnMediaCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMediaCat.Image = global::IExplorer.Properties.Resources.reproductor_de_musica;
            this.btnMediaCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMediaCat.Location = new System.Drawing.Point(0, 0);
            this.btnMediaCat.Name = "btnMediaCat";
            this.btnMediaCat.Size = new System.Drawing.Size(111, 37);
            this.btnMediaCat.TabIndex = 0;
            this.btnMediaCat.Text = "        Media";
            this.btnMediaCat.UseVisualStyleBackColor = false;
            // 
            // statusHelp
            // 
            this.statusHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbHelp});
            this.statusHelp.Location = new System.Drawing.Point(0, 579);
            this.statusHelp.Name = "statusHelp";
            this.statusHelp.Size = new System.Drawing.Size(969, 22);
            this.statusHelp.TabIndex = 28;
            this.statusHelp.Text = "statusHelp";
            // 
            // lbHelp
            // 
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.Size = new System.Drawing.Size(58, 17);
            this.lbHelp.Text = "Hola q tal";
            // 
            // iconosListView
            // 
            this.iconosListView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconosListView.ImageStream")));
            this.iconosListView.TransparentColor = System.Drawing.Color.Transparent;
            this.iconosListView.Images.SetKeyName(0, "docs.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // iexplorerDatos
            // 
            this.iexplorerDatos.AllowDrop = true;
            this.iexplorerDatos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iexplorerDatos.Location = new System.Drawing.Point(203, 20);
            this.iexplorerDatos.Name = "iexplorerDatos";
            this.iexplorerDatos.Size = new System.Drawing.Size(379, 212);
            this.iexplorerDatos.sujeto = null;
            this.iexplorerDatos.TabIndex = 2;
            this.iexplorerDatos.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.iexplorerDatos.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
            // 
            // treeNavigator
            // 
            this.treeNavigator.AllowDrop = true;
            this.treeNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeNavigator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeNavigator.ForeColor = System.Drawing.Color.White;
            this.treeNavigator.ImageIndex = 0;
            this.treeNavigator.ImageList = this.iconosTreeview;
            this.treeNavigator.Location = new System.Drawing.Point(8, 57);
            this.treeNavigator.Margin = new System.Windows.Forms.Padding(0);
            this.treeNavigator.Name = "treeNavigator";
            this.treeNavigator.observers = null;
            this.treeNavigator.SelectedImageIndex = 0;
            this.treeNavigator.Size = new System.Drawing.Size(221, 514);
            this.treeNavigator.TabIndex = 1;
            this.treeNavigator.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeNavigator_NodeMouseClick);
            this.treeNavigator.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.treeNavigator.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
            // 
            // frmIExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 601);
            this.Controls.Add(this.statusHelp);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolBarMain);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.treeNavigator);
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmIExplorer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "IExplorer";
            this.toolBarMain.ResumeLayout(false);
            this.toolBarMain.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRightCenter.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.statusHelp.ResumeLayout(false);
            this.statusHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sujeto treeNavigator;
        private Observador iexplorerDatos;
        private System.Windows.Forms.ToolStrip toolBarMain;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripButton btnRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cbPhonePath;
        private System.Windows.Forms.ToolStripComboBox cbMenu;
        private System.Windows.Forms.ToolStripTextBox tvSearch;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel lbSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.StatusStrip statusHelp;
        private System.Windows.Forms.ToolStripStatusLabel lbHelp;
        private System.Windows.Forms.Panel panelRightCenter;
        private System.Windows.Forms.Button btnMediaCat;
        private System.Windows.Forms.Button btnFilesCat;
        private System.Windows.Forms.Button btnDataCat;
        private System.Windows.Forms.ImageList iconosTreeview;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelRightBottom;
        private System.Windows.Forms.ImageList iconosListView;
        private System.Windows.Forms.ToolStripMenuItem saveDataToolStripMenuItem;
    }
}

