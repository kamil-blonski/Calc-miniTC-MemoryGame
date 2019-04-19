using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC
{
    public interface InterfacePanelViev
    {
        string CurrentPath { get; set; }
        string[] Drives { set; }
        string[] FilesInDirectory { set; }
        event Action LoadingDrives;
        event Action <string> ChangingDrive;
        event Action<string> ShowFilesInDirectory;
    }
}
