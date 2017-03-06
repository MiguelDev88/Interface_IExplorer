using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IExplorer_Datos
{
    public partial class IexplorerDatos : UserControl
    {
        public IexplorerDatos()
        {
            InitializeComponent();
        }

        public void setPhoneName (String phoneName)
        {
            lbPhoneName.Text = phoneName;
        }

        public void setSoftVersion(String softVersion)
        {
            lbSoftVersion.Text = softVersion;
        }

        public void setFirmVersion(String firmVersion)
        {
            lbFirmVersion.Text = firmVersion;
        }

        public void setSerialNum(String serialNum)
        {
            lbSerial.Text = serialNum;
        }

        public void setPhoneNum(String phoneNum)
        {
            lbNumber.Text = phoneNum;
        }

        public void setStorageUsed(String storageUsed)
        {
            lbStorageUsed.Text = storageUsed;
        }

        public void setStorageFree(String storageFree)
        {
            lbStorageFree.Text = storageFree;
        }

        public void setPhoneLogo (Bitmap img)
        {
            pbPhone.Image = img;
        }

        public void setIncrement (int increment)
        {
            pbStorage.Increment(increment);
        }

    }
}
