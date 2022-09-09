using DevExpress.Xpo;
using Etlik.RFID.Entity.Important;

namespace Etlik.RFID.Entity.EntityFramework
{
    [Persistent("tblpersoneltag")]
    public class tblpersoneltag : TabloObject
    {
        public tblpersoneltag(Session session) : base(session) { }
    }
}
