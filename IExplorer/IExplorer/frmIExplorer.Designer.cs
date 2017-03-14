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
            this.lbImgPath = new System.Windows.Forms.ToolStripLabel();
            this.cbPhonePath = new System.Windows.Forms.ToolStripComboBox();
            this.cbMenu = new System.Windows.Forms.ToolStripComboBox();
            this.lbSearch = new System.Windows.Forms.ToolStripLabel();
            this.tvSearch = new System.Windows.Forms.ToolStripTextBox();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelRightBottom = new System.Windows.Forms.Panel();
            this.panelRightCenter = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnDataCat = new System.Windows.Forms.Button();
            this.btnFilesCat = new System.Windows.Forms.Button();
            this.btnMediaCat = new System.Windows.Forms.Button();
            this.iconosListView = new System.Windows.Forms.ImageList(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cMenuFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itsItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsItemShare = new System.Windows.Forms.ToolStripMenuItem();
            this.tsItemSend = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsItemRename = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSep4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsItemProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.iexplorerDatos = new IExplorer.Observador();
            this.treeNavigator = new IExplorer.Sujeto();
            this.toolBarMain.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelRightCenter.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.cMenuFiles.SuspendLayout();
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
            resources.ApplyResources(this.toolBarMain, "toolBarMain");
            this.toolBarMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUndo,
            this.btnRedo,
            this.toolStripSeparator1,
            this.lbImgPath,
            this.cbPhonePath,
            this.cbMenu,
            this.lbSearch,
            this.tvSearch});
            this.toolBarMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolBarMain.Name = "toolBarMain";
            this.toolBarMain.Stretch = true;
            this.toolBarMain.TabStop = true;
            this.toolTip.SetToolTip(this.toolBarMain, resources.GetString("toolBarMain.ToolTip"));
            this.toolBarMain.Resize += new System.EventHandler(this.toolStrip1_Resize);
            // 
            // btnUndo
            // 
            resources.ApplyResources(this.btnUndo, "btnUndo");
            this.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUndo.Image = global::IExplorer.Properties.Resources.boton_de_reproduccionmirror;
            this.btnUndo.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.btnUndo.Name = "btnUndo";
            // 
            // btnRedo
            // 
            resources.ApplyResources(this.btnRedo, "btnRedo");
            this.btnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRedo.Image = global::IExplorer.Properties.Resources.boton_de_reproduccion;
            this.btnRedo.Name = "btnRedo";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // lbImgPath
            // 
            resources.ApplyResources(this.lbImgPath, "lbImgPath");
            this.lbImgPath.Image = global::IExplorer.Properties.Resources.telefono_inteligente__1_;
            this.lbImgPath.Name = "lbImgPath";
            // 
            // cbPhonePath
            // 
            resources.ApplyResources(this.cbPhonePath, "cbPhonePath");
            this.cbPhonePath.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cbPhonePath.Name = "cbPhonePath";
            // 
            // cbMenu
            // 
            resources.ApplyResources(this.cbMenu, "cbMenu");
            this.cbMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cbMenu.Items.AddRange(new object[] {
            resources.GetString("cbMenu.Items"),
            resources.GetString("cbMenu.Items1"),
            resources.GetString("cbMenu.Items2")});
            this.cbMenu.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.cbMenu.Name = "cbMenu";
            // 
            // lbSearch
            // 
            resources.ApplyResources(this.lbSearch, "lbSearch");
            this.lbSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbSearch.Image = global::IExplorer.Properties.Resources.busqueda;
            this.lbSearch.Name = "lbSearch";
            // 
            // tvSearch
            // 
            resources.ApplyResources(this.tvSearch, "tvSearch");
            this.tvSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tvSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tvSearch.Name = "tvSearch";
            this.tvSearch.Click += new System.EventHandler(this.tvSearch_Click);
            // 
            // menuMain
            // 
            resources.ApplyResources(this.menuMain, "menuMain");
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Name = "menuMain";
            this.menuMain.TabStop = true;
            this.toolTip.SetToolTip(this.menuMain, resources.GetString("menuMain.ToolTip"));
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataToolStripMenuItem,
            this.saveDataToolStripMenuItem,
            this.toolStripSeparator2,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // loadDataToolStripMenuItem
            // 
            resources.ApplyResources(this.loadDataToolStripMenuItem, "loadDataToolStripMenuItem");
            this.loadDataToolStripMenuItem.Image = global::IExplorer.Properties.Resources.carpetaload;
            this.loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            // 
            // saveDataToolStripMenuItem
            // 
            resources.ApplyResources(this.saveDataToolStripMenuItem, "saveDataToolStripMenuItem");
            this.saveDataToolStripMenuItem.Image = global::IExplorer.Properties.Resources.guardar;
            this.saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // ExitToolStripMenuItem
            // 
            resources.ApplyResources(this.ExitToolStripMenuItem, "ExitToolStripMenuItem");
            this.ExitToolStripMenuItem.Image = global::IExplorer.Properties.Resources.icon;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.spanishToolStripMenuItem});
            this.languageToolStripMenuItem.Image = global::IExplorer.Properties.Resources.boton_seleccionar_idioma_cuadricula_de_la_tierra;
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Image = global::IExplorer.Properties.Resources.reino_unido;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.languageItem_Click);
            // 
            // spanishToolStripMenuItem
            // 
            resources.ApplyResources(this.spanishToolStripMenuItem, "spanishToolStripMenuItem");
            this.spanishToolStripMenuItem.Image = global::IExplorer.Properties.Resources.espana;
            this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            this.spanishToolStripMenuItem.Click += new System.EventHandler(this.languageItem_Click);
            // 
            // panelRight
            // 
            resources.ApplyResources(this.panelRight, "panelRight");
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.panelRightBottom);
            this.panelRight.Controls.Add(this.panelRightCenter);
            this.panelRight.Controls.Add(this.iexplorerDatos);
            this.panelRight.Name = "panelRight";
            this.toolTip.SetToolTip(this.panelRight, resources.GetString("panelRight.ToolTip"));
            // 
            // panelRightBottom
            // 
            resources.ApplyResources(this.panelRightBottom, "panelRightBottom");
            this.panelRightBottom.Name = "panelRightBottom";
            this.toolTip.SetToolTip(this.panelRightBottom, resources.GetString("panelRightBottom.ToolTip"));
            // 
            // panelRightCenter
            // 
            resources.ApplyResources(this.panelRightCenter, "panelRightCenter");
            this.panelRightCenter.BackColor = System.Drawing.Color.White;
            this.panelRightCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRightCenter.Controls.Add(this.panelButtons);
            this.panelRightCenter.Name = "panelRightCenter";
            this.panelRightCenter.TabStop = true;
            this.toolTip.SetToolTip(this.panelRightCenter, resources.GetString("panelRightCenter.ToolTip"));
            // 
            // panelButtons
            // 
            resources.ApplyResources(this.panelButtons, "panelButtons");
            this.panelButtons.Controls.Add(this.btnDataCat);
            this.panelButtons.Controls.Add(this.btnFilesCat);
            this.panelButtons.Controls.Add(this.btnMediaCat);
            this.panelButtons.Name = "panelButtons";
            this.toolTip.SetToolTip(this.panelButtons, resources.GetString("panelButtons.ToolTip"));
            // 
            // btnDataCat
            // 
            resources.ApplyResources(this.btnDataCat, "btnDataCat");
            this.btnDataCat.BackColor = System.Drawing.Color.White;
            this.btnDataCat.FlatAppearance.BorderSize = 0;
            this.btnDataCat.Image = global::IExplorer.Properties.Resources.la_computacion_en_nube__1_;
            this.btnDataCat.Name = "btnDataCat";
            this.toolTip.SetToolTip(this.btnDataCat, resources.GetString("btnDataCat.ToolTip"));
            this.btnDataCat.UseVisualStyleBackColor = false;
            // 
            // btnFilesCat
            // 
            resources.ApplyResources(this.btnFilesCat, "btnFilesCat");
            this.btnFilesCat.BackColor = System.Drawing.Color.White;
            this.btnFilesCat.FlatAppearance.BorderSize = 0;
            this.btnFilesCat.Image = global::IExplorer.Properties.Resources.carpeta;
            this.btnFilesCat.Name = "btnFilesCat";
            this.toolTip.SetToolTip(this.btnFilesCat, resources.GetString("btnFilesCat.ToolTip"));
            this.btnFilesCat.UseVisualStyleBackColor = false;
            this.btnFilesCat.Click += new System.EventHandler(this.btnFilesCat_Click);
            // 
            // btnMediaCat
            // 
            resources.ApplyResources(this.btnMediaCat, "btnMediaCat");
            this.btnMediaCat.BackColor = System.Drawing.Color.White;
            this.btnMediaCat.FlatAppearance.BorderSize = 0;
            this.btnMediaCat.Image = global::IExplorer.Properties.Resources.reproductor_de_musica;
            this.btnMediaCat.Name = "btnMediaCat";
            this.toolTip.SetToolTip(this.btnMediaCat, resources.GetString("btnMediaCat.ToolTip"));
            this.btnMediaCat.UseVisualStyleBackColor = false;
            // 
            // iconosListView
            // 
            this.iconosListView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconosListView.ImageStream")));
            this.iconosListView.TransparentColor = System.Drawing.Color.Transparent;
            this.iconosListView.Images.SetKeyName(0, "docs.png");
            // 
            // cMenuFiles
            // 
            resources.ApplyResources(this.cMenuFiles, "cMenuFiles");
            this.cMenuFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itsItemOpen,
            this.tsItemEdit,
            this.tsSep1,
            this.tsItemShare,
            this.tsItemSend,
            this.tsSep2,
            this.tsItemCut,
            this.tsItemCopy,
            this.tsSep3,
            this.tsItemDelete,
            this.tsItemRename,
            this.tsSep4,
            this.tsItemProperties});
            this.cMenuFiles.Name = "cMenuFiles";
            this.toolTip.SetToolTip(this.cMenuFiles, resources.GetString("cMenuFiles.ToolTip"));
            // 
            // itsItemOpen
            // 
            resources.ApplyResources(this.itsItemOpen, "itsItemOpen");
            this.itsItemOpen.Name = "itsItemOpen";
            // 
            // tsItemEdit
            // 
            resources.ApplyResources(this.tsItemEdit, "tsItemEdit");
            this.tsItemEdit.Name = "tsItemEdit";
            // 
            // tsSep1
            // 
            resources.ApplyResources(this.tsSep1, "tsSep1");
            this.tsSep1.Name = "tsSep1";
            // 
            // tsItemShare
            // 
            resources.ApplyResources(this.tsItemShare, "tsItemShare");
            this.tsItemShare.Name = "tsItemShare";
            // 
            // tsItemSend
            // 
            resources.ApplyResources(this.tsItemSend, "tsItemSend");
            this.tsItemSend.Name = "tsItemSend";
            // 
            // tsSep2
            // 
            resources.ApplyResources(this.tsSep2, "tsSep2");
            this.tsSep2.Name = "tsSep2";
            // 
            // tsItemCut
            // 
            resources.ApplyResources(this.tsItemCut, "tsItemCut");
            this.tsItemCut.Name = "tsItemCut";
            // 
            // tsItemCopy
            // 
            resources.ApplyResources(this.tsItemCopy, "tsItemCopy");
            this.tsItemCopy.Name = "tsItemCopy";
            // 
            // tsSep3
            // 
            resources.ApplyResources(this.tsSep3, "tsSep3");
            this.tsSep3.Name = "tsSep3";
            // 
            // tsItemDelete
            // 
            resources.ApplyResources(this.tsItemDelete, "tsItemDelete");
            this.tsItemDelete.Name = "tsItemDelete";
            // 
            // tsItemRename
            // 
            resources.ApplyResources(this.tsItemRename, "tsItemRename");
            this.tsItemRename.Name = "tsItemRename";
            // 
            // tsSep4
            // 
            resources.ApplyResources(this.tsSep4, "tsSep4");
            this.tsSep4.Name = "tsSep4";
            // 
            // tsItemProperties
            // 
            resources.ApplyResources(this.tsItemProperties, "tsItemProperties");
            this.tsItemProperties.Name = "tsItemProperties";
            // 
            // iexplorerDatos
            // 
            resources.ApplyResources(this.iexplorerDatos, "iexplorerDatos");
            this.iexplorerDatos.AllowDrop = true;
            this.iexplorerDatos.Name = "iexplorerDatos";
            this.iexplorerDatos.sujeto = null;
            this.toolTip.SetToolTip(this.iexplorerDatos, resources.GetString("iexplorerDatos.ToolTip"));
            this.iexplorerDatos.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.iexplorerDatos.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
            // 
            // treeNavigator
            // 
            resources.ApplyResources(this.treeNavigator, "treeNavigator");
            this.treeNavigator.AllowDrop = true;
            this.treeNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeNavigator.ForeColor = System.Drawing.Color.White;
            this.treeNavigator.ImageList = this.iconosTreeview;
            this.treeNavigator.Name = "treeNavigator";
            this.treeNavigator.observers = null;
            this.toolTip.SetToolTip(this.treeNavigator, resources.GetString("treeNavigator.ToolTip"));
            this.treeNavigator.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeNavigator_NodeMouseClick);
            this.treeNavigator.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.treeNavigator.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
            // 
            // frmIExplorer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.toolBarMain);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.treeNavigator);
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmIExplorer";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.toolBarMain.ResumeLayout(false);
            this.toolBarMain.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRightCenter.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.cMenuFiles.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelRightCenter;
        private System.Windows.Forms.Button btnMediaCat;
        private System.Windows.Forms.Button btnFilesCat;
        private System.Windows.Forms.Button btnDataCat;
        private System.Windows.Forms.ImageList iconosTreeview;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelRightBottom;
        private System.Windows.Forms.ImageList iconosListView;
        private System.Windows.Forms.ToolStripMenuItem saveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel lbImgPath;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip cMenuFiles;
        private System.Windows.Forms.ToolStripMenuItem itsItemOpen;
        private System.Windows.Forms.ToolStripMenuItem tsItemEdit;
        private System.Windows.Forms.ToolStripSeparator tsSep1;
        private System.Windows.Forms.ToolStripMenuItem tsItemShare;
        private System.Windows.Forms.ToolStripMenuItem tsItemSend;
        private System.Windows.Forms.ToolStripSeparator tsSep2;
        private System.Windows.Forms.ToolStripMenuItem tsItemCut;
        private System.Windows.Forms.ToolStripMenuItem tsItemCopy;
        private System.Windows.Forms.ToolStripSeparator tsSep3;
        private System.Windows.Forms.ToolStripMenuItem tsItemDelete;
        private System.Windows.Forms.ToolStripMenuItem tsItemRename;
        private System.Windows.Forms.ToolStripSeparator tsSep4;
        private System.Windows.Forms.ToolStripMenuItem tsItemProperties;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spanishToolStripMenuItem;
    }
}

