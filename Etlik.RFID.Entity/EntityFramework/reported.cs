using DevExpress.Xpo;
using Etlik.RFID.Entity.Important;

namespace Etlik.RFID.Entity.EntityFramework
{
    [Persistent("reported")]
    public class reported : TabloObject
    {
        public reported(Session session) : base(session) { }

        string _reporterid = "";
        [Persistent("reporterid")]
        [Size(500)]
        public string reporterid
        {
            get { return _reporterid; }
            set { SetPropertyValue<string>("reporterid", ref _reporterid, value); }
        }


        string _model = "";
        [Persistent("model")]
        [Size(500)]
        public string model
        {
            get { return _model; }
            set { SetPropertyValue<string>("model", ref _model, value); }
        }

        string _localname = "";
        [Persistent("localname")]
        [Size(500)]
        public string localname
        {
            get { return _localname; }
            set { SetPropertyValue<string>("localname", ref _localname, value); }
        }

        string _mac = "";
        [Persistent("mac")]
        [Size(500)]
        public string mac
        {
            get { return _mac; }
            set { SetPropertyValue<string>("mac", ref _mac, value); }
        }

        int _stats_frame_cnt = -1;
        [Persistent("stats_frame_cnt")]
        [Size(500)]
        public int stats_frame_cnt
        {
            get { return _stats_frame_cnt; }
            set { SetPropertyValue<int>("stats_frame_cnt", ref _stats_frame_cnt, value); }
        }

        int _stats_uptime = -1;
        [Persistent("stats_uptime")]
        [Size(500)]
        public int stats_uptime
        {
            get { return _stats_uptime; }
            set { SetPropertyValue<int>("stats_uptime", ref _stats_uptime, value); }
        }


        int _rssi_smooth = -1;
        [Persistent("rssi_smooth")]
        [Size(500)]
        public int rssi_smooth
        {
            get { return _rssi_smooth; }
            set { SetPropertyValue<int>("rssi_smooth", ref _rssi_smooth, value); }
        }

        string _firmware_banka = "";
        [Persistent("firmware_banka")]
        [Size(500)]
        public string firmware_banka
        {
            get { return _firmware_banka; }
            set { SetPropertyValue<string>("firmware_banka", ref _firmware_banka, value); }
        }

        string _firmware_bankb = "";
        [Persistent("firmware_bankb")]
        [Size(500)]
        public string firmware_bankb
        {
            get { return _firmware_bankb; }
            set { SetPropertyValue<string>("firmware_bankb", ref _firmware_bankb, value); }
        }

        string _sensors_battery = "";
        [Persistent("sensors_battery")]
        [Size(500)]
        public string sensors_battery
        {
            get { return _sensors_battery; }
            set { SetPropertyValue<string>("sensors_battery", ref _sensors_battery, value); }
        }

        int _txpower = -1;
        [Persistent("txpower")]
        [Size(500)]
        public int txpower
        {
            get { return _txpower; }
            set { SetPropertyValue<int>("txpower", ref _txpower, value); }
        }

        int _lastSeen = -1;
        [Persistent("lastSeen")]
        [Size(500)]
        public int lastSeen
        {
            get { return _lastSeen; }
            set { SetPropertyValue<int>("lastSeen", ref _lastSeen, value); }
        }

        //public List<string> deviceClass { get; set; }

        //public List<beacons> beacons { get; set; }       

    }
}
