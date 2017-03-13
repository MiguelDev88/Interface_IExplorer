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
        /// <summary>
        /// Sets the Phone's Name to the value of the designated String
        /// </summary>
        /// <param name="phoneName"></param>
        public void setPhoneName (String phoneName)
        {
            lbPhoneName.Text = phoneName;
        }
        /// <summary>
        /// Sets the Phone's Software Version to the value of the designated String
        /// </summary>
        /// <param name="Software Version"></param>
        public void setSoftVersion(String softVersion)
        {
            lbSoftVersion.Text = softVersion;
        }
        /// <summary>
        /// Sets the Phone's Firmware Version to the value of the designated String
        /// </summary>
        /// <param name="Firmware Version"></param>
        public void setFirmVersion(String firmVersion)
        {
            lbFirmVersion.Text = firmVersion;
        }
        /// <summary>
        /// Sets the Phone's Serial Number to the value of the designated String
        /// </summary>
        /// <param name="Serial Number"></param>
        public void setSerialNum(String serialNum)
        {
            lbSerial.Text = serialNum;
        }
        /// <summary>
        /// Sets the Phone's Number to the value of the designated String
        /// </summary>
        /// <param name="Phone Number"></param>
        public void setPhoneNum(String phoneNum)
        {
            lbNumber.Text = phoneNum;
        }
        /// <summary>
        /// Sets the Phone's actual Storage Used to the designated Value
        /// </summary>
        /// <param name="Storage Used Value"></param>
        public void setStorageUsed(float storageUsed)
        {
            lbStorageUsed.Text = ""+storageUsed + " GB Used";
        }
        /// <summary>
        /// Sets the Phone's actual Storage Free to the designated Value
        /// </summary>
        /// <param name="Storage Free Value"></param>
        public void setStorageFree(float storageFree)
        {
            lbStorageFree.Text = ""+storageFree+" GB Free";
        }
        /// <summary>
        /// Sets the Phone Logo to the value of the designated Image
        /// </summary>
        /// <param name="Logo Img"></param>
        public void setPhoneLogo (Bitmap img)
        {
            pbPhone.Image = img;
        }
        /// <summary>
        /// Sets the Storage Progress bar Value 
        /// </summary>
        /// <param name="Progresbar Value"></param>
        public void setIncrement (int value)
        {
            pbStorage.Value= value;
        }
        /// <summary>
        /// Sets the Phone's Maximum capacity to the designated Value
        /// </summary>
        /// <param name="capacity"></param>
        public void setCapacity (float capacity)
        {
            lbCapacity.Text = ""+capacity + " GB";
        }

    }
}
