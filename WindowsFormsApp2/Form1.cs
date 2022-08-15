using DevExpress.Xpo;
using Etlik.RFID.Arayuz.cIslem;
using Etlik.RFID.Entity.EntityFramework;
using Etlik.RFID.Entity.Important;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string _YaziParse = "{\"idDeviceData\": 0,\"deviceUid\": \"\",\"gsmNetwork\": \"\",\"gsmNetworkQuality\": 0.0,\"wifiNetworkState\": true/false,\"wifiSignalQuality\": 0.0,\"ethernetState\": true/false,\"onPower\": true/false,\"batteryVoltage\": 0.0,\"batteryPercent\": 0,\"batteryLife\": 0,\"fridgeTemprature\": 0.0,\"internalModuleTemprature\": 0.0,\"externalModuleTemprature\": 0.0,\"doorOpen\": true/false,\"lightLevel\": 0.0,\"alarmCode\": \"\",\"alarmDescription\": \"\",\"faultCode\": \"\",\"faultDescription\": \"\",\"workingCounter\": 0L,\"restartCounter\": 0L,\"dataSize\": 0.0,\"reportDate\": \"TIMESTAMP\",\"fridgeName\": \"\",\"reportDateEpoch\": 0L}";
             string _YaziParse = "{\"meta\":{\"version\":1},\"reporter\":{\"name\":\"6c:c4:9f:c9:99:52\",\"mac\":\"6C:C4:9F:C9:99:52\",\"ipv4\":\"192.168.32.24\",\"ipv6\":\"fe80::6ec4:9fff:fec9:9952\",\"hwType\":\"AP-505\",\"swVersion\":\"8.7.1.9\",\"swBuild\":\"83631\",\"time\":1660297208},\"reported\":[{\"deviceClass\":[\"iBeacon\"],\"model\":\"iBeacon\",\"localName\":\"mcz\",\"mac\":\"7C:69:7B:00:01:F4\",\"stats\":{\"frame_cnt\":1},\"beacons\":[{\"ibeacon\":{\"uuid\":\"FB0B57A2-8228-44CD-913A-94A122BA1206\",\"major\":1001,\"minor\":2022,\"power\":-40}}],\"rssi\":{\"smooth\":-86},\"BeaconEvent\":{\"event\":\"update\"},\"lastSeen\":1660297193},{\"deviceClass\":[\"iBeacon\"],\"model\":\"iBeacon\",\"localName\":\"mcz\",\"mac\":\"7C:69:7B:00:01:F6\",\"stats\":{\"frame_cnt\":0},\"beacons\":[{\"ibeacon\":{\"uuid\":\"FB0B57A2-8228-44CD-913A-94A122BA1206\",\"major\":1001,\"minor\":2022,\"power\":-40}}],\"BeaconEvent\":{\"event\":\"ageout\"},\"lastSeen\":1660297111},{\"deviceClass\":[\"iBeacon\"],\"model\":\"iBeacon\",\"mac\":\"7C:69:7B:00:01:F9\",\"stats\":{\"frame_cnt\":1},\"beacons\":[{\"ibeacon\":{\"uuid\":\"FB0B57A2-8228-44CD-913A-94A122BA1206\",\"major\":1001,\"minor\":2022,\"power\":-40}}],\"rssi\":{\"smooth\":-91},\"BeaconEvent\":{\"event\":\"update\"},\"lastSeen\":1660297185},{\"deviceClass\":[\"iBeacon\"],\"model\":\"iBeacon\",\"localName\":\"mcz\",\"mac\":\"7C:69:7B:00:01:FE\",\"stats\":{\"frame_cnt\":1},\"beacons\":[{\"ibeacon\":{\"uuid\":\"FB0B57A2-8228-44CD-913A-94A122BA1206\",\"major\":1001,\"minor\":2022,\"power\":-40}}],\"rssi\":{\"smooth\":-90},\"BeaconEvent\":{\"event\":\"update\"},\"lastSeen\":1660297180}]}";


            #region Değişkenler


            #endregion

          

                string directory = System.IO.Path.Combine(@"C:\veriler\");

                string fileName = Guid.NewGuid().ToString() + ".txt";

                string fullPath = System.IO.Path.Combine(directory, fileName);

                using (Session session = XpoManager.Instance.GetNewSession())
                {
                    jSonVeri _Details = JsonConvert.DeserializeObject<jSonVeri>(_YaziParse.ToString());

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
                       // _reporterTable.Save();

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
                                    rssi_smooth = _Details.reported[i].rssi.smooth,
                                    reporterid = _reporterTable.id,
                                    lastSeen = _Details.reported[i].lastSeen

                                };
                                //_reportedTable.Save();

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
                                    };
                                }
                            }
                        }
                    }
                }
           




        }
    }
}
