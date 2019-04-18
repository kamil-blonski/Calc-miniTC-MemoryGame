using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC.VievNS
{
    public interface InterfaceViev
    {
        InterfacePanelViev Left { get; }
        InterfacePanelViev Right { get; }
    }
}
