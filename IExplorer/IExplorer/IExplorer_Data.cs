using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IExplorer
{
    public partial class IExplorer_Data : UserControl
    {
        public IExplorer_Data()
        {
            InitializeComponent();
        }

        public void setIncrement (int increment)
        {
            pbStorage.Increment(increment);
        }
    }
}
