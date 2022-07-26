using DevExpress.Xpo;
using Etlik.RFID.Arayuz.cIslem;
using Etlik.RFID.Entity.EntityFramework;
using Etlik.RFID.Entity.Important;
using Newtonsoft.Json;
using System;

namespace Etlik.RFID.Arayuz.Manager
{
    public class Veri_Okuma_Manager
    {
        internal void fn_RTLS(object v_gelen)
        {
            #region Değişkenler
            #endregion

            try
            {

                //string directory = System.IO.Path.Combine(@"C:\veriler\");

                //string fileName = Guid.NewGuid().ToString() + ".txt";

                //string fullPath = System.IO.Path.Combine(directory, fileName);


                //System.IO.File.WriteAllText(fullPath, v_gelen.ToString());

              
                using (Session session = XpoManager.Instance.GetNewSession())
                {
                    //new etlikveri(session)
                    //{
                    //    id = Guid.NewGuid().ToString().ToUpper()
                    //}.Save();
                    //etlikveri _Temp = session.Query<etlikveri>().FirstOrDefault(w => w.aktif == 1);
                    jSonVeri _Details = JsonConvert.DeserializeObject<jSonVeri>(v_gelen.ToString());
                    //cJson_01 _Details = JsonConvert.DeserializeObject<cJson_01>(v_gelen.ToString());

                    etlikveri _anatablo = new etlikveri(session)
                    {
                        meta = _Details.meta.version.ToString(),
                        //reportedmac = _Details.reported.ToList().FirstOrDefault().mac,
                        reportermac = _Details.reporter.mac,
                        id = Guid.NewGuid().ToString().ToUpper()
                    };
                    _anatablo.Save();

                    for (int i = 0; i < _Details.reported.Count; i++)
                    {
                        new okumaverisi(session)
                        {
                            id = Guid.NewGuid().ToString().ToUpper(),
                            readermac = _anatablo.id,
                            mac = _Details.reported[i].mac,
                            vendorName = _Details.reported[i].vendorName
                        }.Save();

                    }
                }
                //reporter abc = new reporter();
                //abc.mac = "1";
                //return abc;
            }
            catch (Exception ex)
            {
                string directory = System.IO.Path.Combine(@"C:\veriler\");

                string fileName = "hata_" + Guid.NewGuid().ToString() + ".txt";

                string fullPath = System.IO.Path.Combine(directory, fileName);


                System.IO.File.WriteAllText(fullPath, ex.ToString());
            }
        }

        internal void fn_VeriTabaniOlustur()
        {
            try
            {
                XpoManager.Instance.InitXpo();

            }
            catch (Exception ex)
            { }
        }
    }
}