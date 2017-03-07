using IExplorer.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IExplorer
{
    class Observador : IExplorer_Datos.IexplorerDatos

    {
        public Sujeto sujeto { get; set; }

        public void update(Phone phone) {

            this.setPhoneNum(phone.number);
            this.setPhoneName(phone.name);
            this.setSerialNum(phone.serialNum);
            this.setSoftVersion(phone.softVersion);
            this.setCapacity(phone.storage);
            this.setFirmVersion(phone.firmVersion);

            float storageFree = phone.storage - phone.storageUsed;

            this.setStorageUsed(phone.storageUsed);
            this.setStorageFree(storageFree);
            this.setIncrement(0);
            this.setIncrement((int)(100 * phone.storageUsed / phone.storage));

            switch (phone.model)
            {
                case "samsung":
                    this.setPhoneLogo(new Bitmap(Resources.samsung1ok));
                    break;
                case "iphone":
                    this.setPhoneLogo(new Bitmap(Resources.IPhone_a));
                    break;
                case "otro":
                    this.setPhoneLogo(new Bitmap(Resources.galaxy2));
                    break; 
            }


        }

    }
}
