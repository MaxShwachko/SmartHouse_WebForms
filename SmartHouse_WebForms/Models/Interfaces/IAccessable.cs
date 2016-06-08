using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse_WebForms.Models.Interfaces
{
    interface IAccessable
    {
        bool Access { get; set; }

        bool IsAccess();
    }
}
