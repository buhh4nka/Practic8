using System;
using System.Collections.Generic;
using System.Text;

namespace Practic8
{
    interface ICargoTransport
    {
        public string Name { get; set; }
        public int LoadCapacity { get; set; }
    }
}
