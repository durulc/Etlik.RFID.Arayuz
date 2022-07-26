using DevExpress.Xpo;
using Etlik.RFID.Entity.Important;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etlik.RFID.Entity.EntityFramework
{
    [Persistent("okumaverisi")]
    public class okumaverisi: TabloObject
    {
        public okumaverisi(Session session) : base(session) { }

        string _mac = "";
        [Persistent("mac")]
        [Size(500)]
        public string mac
        {
            get { return _mac; }
            set { SetPropertyValue<string>("mac", ref _mac, value); }
        }

        string _readermac = "";
        [Persistent("readermac")]
        [Size(500)]
        public string readermac
        {
            get { return _readermac; }
            set { SetPropertyValue<string>("readermac", ref _readermac, value); }
        }

        string _vendorName = "";
        [Persistent("vendorName")]
        [Size(250)]
        public string vendorName
        {
            get { return _vendorName; }
            set { SetPropertyValue<string>("vendorName", ref _vendorName, value); }
        }


    }
}
