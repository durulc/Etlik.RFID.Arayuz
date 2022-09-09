using System;

namespace Versiyon_01.Class
{
    public class cVeri
    {
        public int readerId { get; set; }
        public int sensorId { get; set; }
        public int pil { get; set; }
        public int rssi { get; set; }
        public int dbm { get; set; }
        public int yonelim { get; set; }
        public int onbellek { get; set; }
        public int alarm { get; set; }
        public double sicaklik { get; set; }
        public double kalibrasyonDegeri { get; set; }
        public DateTime olcumZamani { get; set; }
        public DateTime kayitZamani { get; set; }
    }
}
