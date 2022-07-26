namespace Etlik.RFID.Arayuz.cIslem
{
    public class jSonVeri
    {
        public meta v_meta { get; set; }
        public reporter v_reporter { get; set; }
    }


    public class meta {
        public string version { get; set; }
    }

    public class reporter {
        public string name { get; set; }
        public string mac { get; set; }
        public string ipv4 { get; set; }
        public string hwType { get; set; }
    }

}