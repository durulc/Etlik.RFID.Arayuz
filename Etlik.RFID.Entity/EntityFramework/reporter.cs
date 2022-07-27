using DevExpress.Xpo;
using Etlik.RFID.Entity.Important;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etlik.RFID.Entity.EntityFramework
{

    [Persistent("reporter")]
    public class reporter : TabloObject
    {
        public reporter(Session session) : base(session) { }

        string _name = "";
        [Persistent("name")]
        [Size(500)]
        public string name
        {
            get { return _name; }
            set { SetPropertyValue<string>("name", ref _name, value); }
        }

        string _mac = "";
        [Persistent("mac")]
        [Size(500)]
        public string mac
        {
            get { return _mac; }
            set { SetPropertyValue<string>("mac", ref _mac, value); }
        }

        string _ipv4 = "";
        [Persistent("ipv4")]
        [Size(500)]
        public string ipv4
        {
            get { return _ipv4; }
            set { SetPropertyValue<string>("ipv4", ref _ipv4, value); }
        }

        string _hwType = "";
        [Persistent("hwType")]
        [Size(500)]
        public string hwType
        {
            get { return _hwType; }
            set { SetPropertyValue<string>("hwType", ref _hwType, value); }
        }

        string _swVersion = "";
        [Persistent("swVersion")]
        [Size(500)]
        public string swVersion
        {
            get { return _swVersion; }
            set { SetPropertyValue<string>("swVersion", ref _swVersion, value); }
        }

        string _swBuild = "";
        [Persistent("swBuild")]
        [Size(500)]
        public string swBuild
        {
            get { return _swBuild; }
            set { SetPropertyValue<string>("swBuild", ref _swBuild, value); }
        }

        //public string name { get; set; }
        //public string mac { get; set; }
        //public string ipv4 { get; set; }
        //public string hwType { get; set; }
        //public string swVersion { get; set; }
        //public string swBuild { get; set; }
    }
}
