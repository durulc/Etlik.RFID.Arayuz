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
            bool deviceuygunlugu = false;

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
                        if (_Details.reported[i].mac.ToUpper().StartsWith("7C:69"))
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
                    #region 27.07.2022 Tüm Verinin İşlenmesi Başlangıç
                    //--------------------------------------------------27.07.2022 Tüm Verinin İşlenmesi Başlangıç--------------------------------------------------//



                   

                    for (int i = 0; i < _Details.reported.Count; i++)
                    {
                        
                        if (_Details.reported[i].mac.ToUpper().StartsWith("7C:69"))
                        {
                            deviceuygunlugu = true;
                            reported _reportedTable = new reported(session)
                            {

                                id = Guid.NewGuid().ToString().ToUpper(),

                                model = _Details.reported[i].model,
                                vendorName = _Details.reported[i].vendorName,
                                mac = _Details.reported[i].mac,

                                stats_frame_cnt = _Details.reported[i].stats.frame_cnt,
                                stats_uptime = _Details.reported[i].stats.uptime,

                                rssi_smooth = _Details.reported[i].rssi.smooth,

                                beaconevent_event = _Details.reported[i].BeaconEvent.@event,

                                firmware_banka = _Details.reported[i].firmware.bankA,
                                firmware_bankb = _Details.reported[i].firmware.bankB,

                                txpower = _Details.reported[i].txpower,
                                lastSeen = _Details.reported[i].lastSeen,

                            };
                            _reportedTable.Save();

                            for (int j = 0; j < _Details.reported[i].beacons.Count; j++)
                            {
                                new beacons(session)
                                {
                                    id = Guid.NewGuid().ToString().ToUpper(),

                                    reportedid = _reportedTable.id,
                                    ibeacon_uuid = _Details.reported[i].beacons[j].ibeacon.uuid,
                                    ibeacon_major = _Details.reported[i].beacons[j].ibeacon.major,
                                    ibeacon_minor = _Details.reported[i].beacons[j].ibeacon.minor,
                                    ibeacon_power = _Details.reported[i].beacons[j].ibeacon.power


                                }.Save();
                            }

                            for (int k = 0; k < _Details.reported[i].deviceClass.Count; k++)
                            {
                                new deviceClass(session)
                                {
                                    id = Guid.NewGuid().ToString().ToUpper(),
                                    reportedid = _reportedTable.id,
                                    devicename = _Details.reported[i].deviceClass[k]
                                }.Save();
                            }

                        }
                    }

                    if (deviceuygunlugu)
                    {
                        #region Reporter
                        reporter _reporterTable = new reporter(session)
                        {
                            id = Guid.NewGuid().ToString().ToUpper(),
                            name = _Details.reporter.name,
                            mac = _Details.reporter.mac,
                            ipv4 = _Details.reporter.ipv4,
                            hwType = _Details.reporter.hwType,
                            swVersion = _Details.reporter.swVersion,
                            swBuild = _Details.reporter.swBuild
                        };
                        _reporterTable.Save();

                        #endregion

                        new anatablo(session)
                        {
                            id = Guid.NewGuid().ToString().ToUpper(),
                            meta = _Details.meta.version,
                            reporterid = _reporterTable.id

                        }.Save();

                        deviceuygunlugu = false;
                    }
                    else
                    {
                        deviceuygunlugu = false;
                    }



                    //--------------------------------------------------27.07.2022 Tüm Verinin İşlenmesi Bitiş--------------------------------------------------//
                    #endregion
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