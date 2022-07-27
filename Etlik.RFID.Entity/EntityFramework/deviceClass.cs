using DevExpress.Xpo;
using Etlik.RFID.Entity.Important;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etlik.RFID.Entity.EntityFramework
{
    [Persistent("deviceClass")]
    public class deviceClass : TabloObject
    {
        public deviceClass(Session session) : base(session) { }

        string _reportedid = "";
        [Persistent("reportedid")]
        [Size(500)]
        public string reportedid
        {
            get { return _reportedid; }
            set { SetPropertyValue<string>("reportedid", ref _reportedid, value); }
        }

        string _devicename = "";
        [Persistent("devicename")]
        [Size(500)]
        public string devicename
        {
            get { return _devicename; }
            set { SetPropertyValue<string>("devicename", ref _devicename, value); }
        }
    }
}
