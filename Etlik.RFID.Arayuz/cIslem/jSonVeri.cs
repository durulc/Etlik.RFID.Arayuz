using System.Collections.Generic;

namespace Etlik.RFID.Arayuz.cIslem
{
    public class jSonVeri
    {
        public v_meta meta { get; set; }
        public v_reporter reporter { get; set; }
        public List<v_reported> reported { get; set; }

    }


    public class v_meta
    {
        public string version { get; set; }
    }

    public class v_reporter
    {
        public string name { get; set; }
        public string mac { get; set; }
        public string ipv4 { get; set; }
        public string hwType { get; set; }
        public string swVersion { get; set; }
        public string swBuild { get; set; }

    }

    public class v_reported
    {
        public List<string> deviceClass { get; set; }
        public string model { get; set; }
        public string vendorName { get; set; }
        public string mac { get; set; }
        public v_stats stats { get; set; }
        public List<v_beacons> beacons { get; set; }
        public v_rssi rssi { get; set; }
        public v_BeaconEvent BeaconEvent { get; set; }
        public int txpower { get; set; }
        public int lastSeen { get; set; }
        public v_firmware firmware { get; set; }
        public v_sensors sensors { get; set; }


    }
    public class v_beacons
    {
        public v_ibeacon ibeacon { get; set; }
    }
    public class v_ibeacon
    {
        public string uuid { get; set; }
        public int major { get; set; }
        public int minor { get; set; }
        public int power { get; set; }

    }

    public class v_stats
    {
        public int frame_cnt { get; set; }
        public int uptime { get; set; }
    }

    public class v_rssi
    {
        public int smooth { get; set; }
    }
    public class v_BeaconEvent
    {
        public string @event { get; set; }
    }
    public class v_firmware
    {
        public string bankB { get; set; }
        public string bankA { get; set; }
    }
    public class v_sensors
    {
        public string battery { get; set; }

    }

}