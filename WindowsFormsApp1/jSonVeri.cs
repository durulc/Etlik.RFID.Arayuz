namespace WindowsFormsApp1
{
    public class jSonVeri
    {
        public v_meta meta { get; set; }
        public v_reporter reporter { get; set; }
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
    }
}
