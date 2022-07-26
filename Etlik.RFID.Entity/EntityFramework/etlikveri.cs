using DevExpress.Xpo;
using Etlik.RFID.Entity.Important;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etlik.RFID.Entity.EntityFramework
{
    [Persistent("etlikveri")]

    public class etlikveri:TabloObject
    {
       

        public etlikveri(Session session) : base(session) { }

        
        string _meta = "";
        [Persistent("meta")]
        [Size(500)]
        public string meta
        {
            get { return _meta; }
            set { SetPropertyValue<string>("meta", ref _meta, value); }
        }

        string _reportermac = "";
        [Persistent("reportermac")]
        [Size(250)]
        public string reportermac
        {
            get { return _reportermac; }
            set { SetPropertyValue<string>("matnr", ref _reportermac, value); }
        }

        string _reportedmac = "";
        [Persistent("reportedmac")]
        [Size(250)]
        public string reportedmac
        {
            get { return _reportedmac; }
            set { SetPropertyValue<string>("reportedmac", ref _reportedmac, value); }
        }

        

        //public string meta { get; set; }
        //public string reportermac { get; set; }
        //public string reportedmac { get; set; }
    }
}
