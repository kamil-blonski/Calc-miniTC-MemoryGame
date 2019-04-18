using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC.ModelNS
{
    public class Model
    {
        public string [] GetDrives()
        {
            string[] drives = System.IO.Directory.GetLogicalDrives();
            return drives;
        }

    }
}
