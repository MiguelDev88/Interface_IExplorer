using IExplorer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IExplorer
{
    public partial class frmIExplorer : Form
    {

        String phoneFile = "";
        Phone phone;

        public frmIExplorer()
        {
            InitializeComponent();
            cbPhonePath.Width = tvSearch.Bounds.Left - btnUndo.Bounds.Right - 45;

            Bitmap myImage = new Bitmap(Resources.samsung1ok);

            iexplorerDatos.setPhoneLogo(myImage);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_Resize(object sender, EventArgs e)
        {
            cbPhonePath.Width = tvSearch.Bounds.Left - btnUndo.Bounds.Right - 45;
        }

        private void btnFilesCat_Click(object sender, EventArgs e)
        {
            ListView lvFiles = new ListView();
            lvFiles.Dock = DockStyle.Fill;
            lvFiles.Parent = panelRightBottom;
            lvFiles.BorderStyle = BorderStyle.None;

            

            for (int i = 0; i<phone.files.Count; i++) {
                ListViewItem item = new ListViewItem();
                item.Text = phone.files[i];
                lvFiles.LargeImageList = iconosListView;
                lvFiles.Items.Add(item);
                item.ImageIndex = 0;
                item.Font = new Font("Arial", 10, FontStyle.Bold);

            }

            //panelRightBottom.Controls.Clear();


        }

        private void saveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void iexplorerDatos1_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void iexplorerDatos_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Phone));
                System.IO.FileStream stream = System.IO.File.OpenRead(files[0]);
                //phoneFile = files[0];
                
                phone = (Phone)serializer.Deserialize(stream);

                iexplorerDatos.setPhoneNum(phone.number);
                iexplorerDatos.setPhoneName(phone.name);
                iexplorerDatos.setSerialNum(phone.serialNum);
                iexplorerDatos.setSoftVersion(phone.softVersion);
                iexplorerDatos.setCapacity(phone.storage);
                iexplorerDatos.setFirmVersion(phone.firmVersion);

                float storageFree= phone.storage - phone.storageUsed;

                iexplorerDatos.setStorageUsed(phone.storageUsed);
                iexplorerDatos.setStorageFree(storageFree);

                iexplorerDatos.setIncrement((int)(phone.storage *storageFree / 10));


            }
            catch (Exception) { };
        }
    }
}
