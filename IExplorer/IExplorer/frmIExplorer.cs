using IExplorer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IExplorer
{
    public partial class frmIExplorer : Form
    {

        Phone phoneActive;
        List<Phone> phones;
        

        public frmIExplorer()
        {
            InitializeComponent();
            cbPhonePath.Width = tvSearch.Bounds.Left - lbImgPath.Bounds.Right - 45;
            phones = new List<Phone>();

            treeNavigator.attach(iexplorerDatos);

        }

        private void toolStrip1_Resize(object sender, EventArgs e)
        {
            cbPhonePath.Width = tvSearch.Bounds.Left - lbImgPath.Bounds.Right - 45;
        }

        private void btnFilesCat_Click(object sender, EventArgs e)
        {
            panelRightBottom.Controls.Clear();
            ListView lvFiles = new ListView();
            lvFiles.Dock = DockStyle.Fill;
            lvFiles.Parent = panelRightBottom;
            lvFiles.BorderStyle = BorderStyle.None;

            
            if(phoneActive!= null )
                for (int i = 0; i<phoneActive.files.Count; i++) {
                    ListViewItem item = new ListViewItem();
                    item.Text = phoneActive.files[i];
                    lvFiles.LargeImageList = iconosListView;
                    lvFiles.Items.Add(item);
                    item.ImageIndex = 0;
                    item.Font = new Font("Arial", 10, FontStyle.Bold);

                    cbPhonePath.Text = phoneActive.name + "/" + "Files";

                }

            lvFiles.MouseClick += listView_MouseClick;

        }

        private void listView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (((ListView)sender).FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    cMenuFiles.Show(Cursor.Position);
                }
            }
            else if(e.Button == MouseButtons.Left)
            {
                if (((ListView)sender).FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    cbPhonePath.Text = phoneActive.name + "/" + "Files" + "/"+ ((ListView)sender).FocusedItem.Text;
                }
            }
        }

        private void dragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;//cambio el iconito
        }

        private void dragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Phone));
                System.IO.FileStream stream = System.IO.File.OpenRead(files[0]);
                phoneActive = (Phone)serializer.Deserialize(stream);

                treeNavigator.newNode(phoneActive);
                phones.Add(phoneActive);

                treeNavigator.notify(phoneActive);


            }
            catch (Exception) { };
        }

        private void treeNavigator_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent == null)
            {
                if (phoneActive != phones[e.Node.Index])
                {
                    panelRightBottom.Controls.Clear();
                    phoneActive = phones[e.Node.Index];
                    treeNavigator.notify(phoneActive);
                }
                cbPhonePath.Text = phoneActive.name;

            }
            else
            {
                if (phoneActive != phones[e.Node.Parent.Index])
                {
                    panelRightBottom.Controls.Clear();

                    phoneActive = phones[e.Node.Parent.Index];
                    treeNavigator.notify(phoneActive);
                }
                cbPhonePath.Text = phoneActive.name + "/" + e.Node.Text;
            }
        }

        private void languageItem_Click(object sender, EventArgs e)
        {
            switch (((ToolStripItem)sender).Name)
            {
                case ("spanishToolStripMenuItem"):
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
                    break;
                case ("englishToolStripMenuItem"):
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    break;
            }
            Controls.Clear();
            treeNavigator.detach(iexplorerDatos);
            InitializeComponent();
            treeNavigator.attach(iexplorerDatos);

            foreach (Phone p in phones)
            {
                treeNavigator.newNode(p);
                treeNavigator.notify(p);
            }
        }

        private void tvSearch_Click(object sender, EventArgs e)
        {
            tvSearch.Text = "";
        }



        /*
private void tsItemDelete_Click(object sender, EventArgs e)
{
   //temp= phoneActive.files;

   //((ListView)(((ContextMenuStrip)sender).Parent)).SelectedItems;
   phoneActive.files.Remove(((ListView)(((ContextMenuStrip)sender).Parent)).SelectedItems[0].Text);

   ((ListView)(((ContextMenuStrip)sender).Parent)).Items.Remove(((ListView)(((ContextMenuStrip)sender).Parent)).SelectedItems[0]);

}
*/
    }
}
