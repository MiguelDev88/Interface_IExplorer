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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbPhonePath.Width = tvSearch.Bounds.Left - btnUndo.Bounds.Right - 45;


            Bitmap myImage = new Bitmap(Resources.samsung1ok);

            iexplorerDatos1.setPhoneLogo(myImage);
            iexplorerDatos1.setIncrement(80);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_Resize(object sender, EventArgs e)
        {
            cbPhonePath.Width = tvSearch.Bounds.Left - btnUndo.Bounds.Right - 45;
        }
    }
}
