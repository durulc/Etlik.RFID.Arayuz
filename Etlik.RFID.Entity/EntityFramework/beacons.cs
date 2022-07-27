using DevExpress.Xpo;
using Etlik.RFID.Entity.Important;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etlik.RFID.Entity.EntityFramework
{
    [Persistent("beacons")]
    public class beacons: TabloObject
    {
        public beacons(Session session) : base(session) { }

        string _reportedid = "";
        [Persistent("reportedid")]
        [Size(500)]
        public string reportedid
        {
            get { return _reportedid; }
            set { SetPropertyValue<string>("reportedid", ref _reportedid, value); }
        }

        string _ibeacon_uuid = "";
        [Persistent("ibeacon_uuid")]
        [Size(500)]
        public string ibeacon_uuid
        {
            get { return _ibeacon_uuid; }
            set { SetPropertyValue<string>("ibeacon_uuid", ref _ibeacon_uuid, value); }
        }

        int _ibeacon_major = -1;
        [Persistent("ibeacon_major")]
        [Size(500)]
        public int ibeacon_major
        {
            get { return _ibeacon_major; }
            set { SetPropertyValue<int>("ibeacon_major", ref _ibeacon_major, value); }
        }

        int _ibeacon_minor = -1;
        [Persistent("ibeacon_minor")]
        [Size(500)]
        public int ibeacon_minor
        {
            get { return _ibeacon_minor; }
            set { SetPropertyValue<int>("ibeacon_minor", ref _ibeacon_minor, value); }
        }

        int _ibeacon_power = -1;
        [Persistent("ibeacon_power")]
        [Size(500)]
        public int ibeacon_power
        {
            get { return _ibeacon_power; }
            set { SetPropertyValue<int>("ibeacon_power", ref _ibeacon_power, value); }
        }

       

        //public string uuid { get; set; }
        //public int major { get; set; }
        //public int minor { get; set; }
        //public int power { get; set; }
    }
}
