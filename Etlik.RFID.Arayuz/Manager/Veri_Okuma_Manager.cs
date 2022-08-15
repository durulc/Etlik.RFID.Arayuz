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

                string directory = System.IO.Path.Combine(@"C:\veriler\");

                string fileName = Guid.NewGuid().ToString() + ".txt";

                string fullPath = System.IO.Path.Combine(directory, fileName);



                using (Session session = XpoManager.Instance.GetNewSession())
                {
                    jSonVeri _Details = JsonConvert.DeserializeObject<jSonVeri>(v_gelen.ToString());

                    if (_Details.reported.Count > 0)
                    {

                        // REader
                        reporter _reporterTable = new reporter(session)
                        {
                            id = Guid.NewGuid().ToString().ToUpper(),
                            name = _Details.reporter.name,
                            mac = _Details.reporter.mac,
                            ipv4 = _Details.reporter.ipv4,
                            hwType = _Details.reporter.hwType,
                            swVersion = _Details.reporter.swVersion,
                            swBuild = _Details.reporter.swBuild,
                            aktif = 1,
                            createuser = "",
                            lastupdateuser = "",
                            databasekayitzamani = DateTime.Now,
                            guncellemezamani = DateTime.Now
                        };
                        _reporterTable.Save();

                        // tag

                        for (int i = 0; i < _Details.reported.Count; i++)
                        {

                            if (_Details.reported[i].mac.StartsWith("7C:69"))
                            {
                                reported _reportedTable = new reported(session)
                                {
                                    guncellemezamani = DateTime.Now,
                                    databasekayitzamani = DateTime.Now,
                                    aktif = 1,
                                    id = Guid.NewGuid().ToString().ToUpper(),

                                    model = _Details.reported[i].model,
                                    localname = _Details.reported[i].localName,
                                    mac = _Details.reported[i].mac,
                                    stats_frame_cnt = _Details.reported[i].stats.frame_cnt,
                                    // stats_uptime = _Details.reported[i].stats.uptime,
                                    // rssi_smooth = _Details.reported[i].rssi.smooth,
                                    rssi_smooth = -190,
                                    reporterid = _reporterTable.id,
                                    lastSeen = _Details.reported[i].lastSeen

                                };


                                if (_Details.reported[i].rssi != null)
                                {
                                    _reportedTable.rssi_smooth = _Details.reported[i].rssi.smooth;
                                }

                                _reportedTable.Save();

                                for (int j = 0; j < _Details.reported[i].beacons.Count; j++)
                                {
                                    new beacons(session)
                                    {
                                        id = Guid.NewGuid().ToString().ToUpper(),
                                        aktif = 1,
                                        createuser = "",
                                        databasekayitzamani = DateTime.Now,
                                        guncellemezamani = DateTime.Now,
                                        lastupdateuser = "",
                                        reportedid = _reportedTable.id,
                                        ibeacon_uuid = _Details.reported[i].beacons[j].ibeacon.uuid,
                                        ibeacon_major = _Details.reported[i].beacons[j].ibeacon.major,
                                        ibeacon_minor = _Details.reported[i].beacons[j].ibeacon.minor,
                                        ibeacon_power = _Details.reported[i].beacons[j].ibeacon.power
                                    }.Save();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string directory = System.IO.Path.Combine(@"C:\veriler\");

                string fileName = "hata_" + Guid.NewGuid().ToString() + ".txt";

                string fullPath = System.IO.Path.Combine(directory, fileName);

                System.IO.File.WriteAllText(fullPath, v_gelen.ToString() + "                  " + ex.ToString());
            }
        }

        internal void fn_VeriTabaniOlustur()
        {
            try
            {
                XpoManager.Instance.InitXpo();

            }
            catch (Exception ex)
            {

            }
        }
    }
}