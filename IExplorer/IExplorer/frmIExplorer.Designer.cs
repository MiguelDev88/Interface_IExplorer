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
            this.statusHelp = new System.Windows.Forms.StatusStrip();
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
            this.btnUndo.Text = "btnUndo";
            this.btnUndo.ToolTipText = "Undo 1 step";
            // 
            // btnRedo
            // 
            this.btnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRedo.Image = global::IExplorer.Properties.Resources.boton_de_reproduccion;
            this.btnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(23, 22);
            this.btnRedo.Text = "btnRedo";
            this.btnRedo.ToolTipText = "Redo 1 step";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lbImgPath
            // 
            this.lbImgPath.Image = global::IExplorer.Properties.Resources.telefono_inteligente__1_;
            this.lbImgPath.Name = "lbImgPath";
            this.lbImgPath.Size = new System.Drawing.Size(16, 22);
            // 
            // cbPhonePath
            // 
            this.cbPhonePath.AutoSize = false;
            this.cbPhonePath.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cbPhonePath.Name = "cbPhonePath";
            this.cbPhonePath.Size = new System.Drawing.Size(100, 23);
            this.cbPhonePath.ToolTipText = "Phone Path";
            // 
            // cbMenu
            // 
            this.cbMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cbMenu.AutoSize = false;
            this.cbMenu.Items.AddRange(new object[] {
            "Verde",
            "Azul",
            "Amarillo"});
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
            this.tvSearch.Text = "Search";
            this.tvSearch.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tvSearch.ToolTipText = "Search";
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
            this.saveDataToolStripMenuItem,
            this.toolStripSeparator2,
            this.ExitToolStripMenuItem});
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(124, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.ExitToolStripMenuItem.Text = "&Exit";
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
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.spanishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.languageToolStripMenuItem.Text = "&Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.englishToolStripMenuItem.Text = "&English";
            // 
            // spanishToolStripMenuItem
            // 
            this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            this.spanishToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.spanishToolStripMenuItem.Text = "&Spanish";
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
            this.toolTip.SetToolTip(this.btnDataCat, "App Data");
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
            this.toolTip.SetToolTip(this.btnFilesCat, "Files in this phone");
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
            this.toolTip.SetToolTip(this.btnMediaCat, "Music, Videos, Etc");
            this.btnMediaCat.UseVisualStyleBackColor = false;
            // 
            // statusHelp
            // 
            this.statusHelp.Location = new System.Drawing.Point(0, 579);
            this.statusHelp.Name = "statusHelp";
            this.statusHelp.Size = new System.Drawing.Size(969, 22);
            this.statusHelp.TabIndex = 28;
            this.statusHelp.Text = "statusHelp";
            // 
            // iconosListView
            // 
            this.iconosListView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconosListView.ImageStream")));
            this.iconosListView.TransparentColor = System.Drawing.Color.Transparent;
            this.iconosListView.Images.SetKeyName(0, "docs.png");
            // 
            // cMenuFiles
            // 
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
            this.cMenuFiles.Size = new System.Drawing.Size(132, 226);
            // 
            // itsItemOpen
            // 
            this.itsItemOpen.Name = "itsItemOpen";
            this.itsItemOpen.Size = new System.Drawing.Size(131, 22);
            this.itsItemOpen.Text = "&Open";
            // 
            // tsItemEdit
            // 
            this.tsItemEdit.Name = "tsItemEdit";
            this.tsItemEdit.Size = new System.Drawing.Size(131, 22);
            this.tsItemEdit.Text = "&Edit";
            // 
            // tsSep1
            // 
            this.tsSep1.Name = "tsSep1";
            this.tsSep1.Size = new System.Drawing.Size(128, 6);
            // 
            // tsItemShare
            // 
            this.tsItemShare.Name = "tsItemShare";
            this.tsItemShare.Size = new System.Drawing.Size(131, 22);
            this.tsItemShare.Text = "S&hare With";
            // 
            // tsItemSend
            // 
            this.tsItemSend.Name = "tsItemSend";
            this.tsItemSend.Size = new System.Drawing.Size(131, 22);
            this.tsItemSend.Text = "&Send";
            // 
            // tsSep2
            // 
            this.tsSep2.Name = "tsSep2";
            this.tsSep2.Size = new System.Drawing.Size(128, 6);
            // 
            // tsItemCut
            // 
            this.tsItemCut.Name = "tsItemCut";
            this.tsItemCut.Size = new System.Drawing.Size(131, 22);
            this.tsItemCut.Text = "&Cut";
            // 
            // tsItemCopy
            // 
            this.tsItemCopy.Name = "tsItemCopy";
            this.tsItemCopy.Size = new System.Drawing.Size(131, 22);
            this.tsItemCopy.Text = "C&opy";
            // 
            // tsSep3
            // 
            this.tsSep3.Name = "tsSep3";
            this.tsSep3.Size = new System.Drawing.Size(128, 6);
            // 
            // tsItemDelete
            // 
            this.tsItemDelete.Name = "tsItemDelete";
            this.tsItemDelete.Size = new System.Drawing.Size(131, 22);
            this.tsItemDelete.Text = "&Delete";
            // 
            // tsItemRename
            // 
            this.tsItemRename.Name = "tsItemRename";
            this.tsItemRename.Size = new System.Drawing.Size(131, 22);
            this.tsItemRename.Text = "&Rename";
            // 
            // tsSep4
            // 
            this.tsSep4.Name = "tsSep4";
            this.tsSep4.Size = new System.Drawing.Size(128, 6);
            // 
            // tsItemProperties
            // 
            this.tsItemProperties.Name = "tsItemProperties";
            this.tsItemProperties.Size = new System.Drawing.Size(131, 22);
            this.tsItemProperties.Text = "&Properties";
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
            this.toolTip.SetToolTip(this.iexplorerDatos, "Phone Data");
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
        private System.Windows.Forms.StatusStrip statusHelp;
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

