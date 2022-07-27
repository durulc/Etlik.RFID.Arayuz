using DevExpress.Xpo;
using Etlik.RFID.Entity.Important;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etlik.RFID.Entity.EntityFramework
{
    [Persistent("anatablo")]
    public class anatablo : TabloObject
    {
        public anatablo(Session session) : base(session) { }

        int _meta = -1;
        [Persistent("meta")]
        [Size(500)]
        public int meta
        {
            get { return _meta; }
            set { SetPropertyValue<int>("meta", ref _meta, value); }
        }

        string _reporterid = "";
        [Persistent("reporterid")]
        [Size(500)]
        public string reporterid
        {
            get { return _reporterid; }
            set { SetPropertyValue<string>("reporterid", ref _reporterid, value); }
        }
    }
}
