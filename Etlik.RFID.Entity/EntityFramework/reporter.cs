using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etlik.RFID.Entity.EntityFramework
{
    public class reporter
    {
        public string name { get; set; }
        public string mac { get; set; }
        public string ipv4 { get; set; }
        public string hwType { get; set; }
        public string swVersion { get; set; }
        public string swBuild { get; set; }
    }
}
