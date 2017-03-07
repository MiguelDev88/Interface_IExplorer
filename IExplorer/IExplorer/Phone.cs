using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IExplorer
{
    public class Phone
    {
        public String number { get; set; }
        public String model { get; set; }
        public String name { get; set; }
        public float storage { get; set; }
        public float storageUsed { get; set; }
        public String serialNum { get; set; }
        public String firmVersion { get; set; }
        public String softVersion { get; set; }
        public List<String> files { get; set; }


        public Phone() { }

        public Phone(String number, String model, String name, float storage, float storageUsed, String firmVersion, String softVersion, String serialNum, List<String> files)
        {
            this.number=number;
            this.model = model;
            this.name = name;
            this.storage = storage;
            this.storageUsed = storageUsed;
            this.firmVersion = firmVersion;
            this.softVersion = softVersion;
            this.serialNum = serialNum;
            this.files = files;
        }

    }
}
