using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;
using System.Windows.Forms;
using Versiyon_01.Class;
using Versiyon_01.Important;

namespace Versiyon_01
{
    public partial class Form1 : Form
    {
        private readonly string _HostName = "telemetry1ats.saglik.gov.tr";
        //private readonly string _HostNameIceri = "172.16.252.140";
        private readonly string _UserName = "telemetry_111";
        private readonly string _Password = "rabitmq@telemetri";
        private readonly int _Port = 2815;


        string _queueName = "INSERT";
          Publisher _publisher;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fn_Yolla();
        }

        private void fn_Yolla()
        {

            try
            {
                cVeri _Deger = new cVeri();
                _Deger.alarm = 0;
                _Deger.dbm = -45;
                _Deger.kalibrasyonDegeri = 0;
                _Deger.kayitZamani = DateTime.Now;
                _Deger.olcumZamani = DateTime.Now;
                _Deger.onbellek = 0;
                _Deger.pil = 255;
                _Deger.readerId = 19000;
                _Deger.rssi = 54;
                _Deger.sensorId = 40000;
                _Deger.sicaklik = 5.1;
                _Deger.yonelim = 1;

                string _Parametre = JsonConvert.SerializeObject(_Deger);


                 _publisher = new Publisher(_queueName, _Parametre);

                MessageBox.Show("Bitti");
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.ToString();
                MessageBox.Show("HATA");
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                var factory = new ConnectionFactory()
                {
                    HostName = _HostName,
                   //Port = _Port,
                    UserName = _UserName,
                    Password = _Password
                };

                using (IConnection connection = factory.CreateConnection())
                {

                }

                    MessageBox.Show("OLDU");

            }
            catch (Exception ex)
            {
                textBox1.Text = ex.ToString();
                MessageBox.Show("HATA");
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fn_IceridenBaglan();
        }

        private void fn_IceridenBaglan()
        {

            cVeri _Deger = new cVeri();
            _Deger.alarm = 0;
            _Deger.dbm = -45;
            _Deger.kalibrasyonDegeri = 0;
            _Deger.kayitZamani = DateTime.Now;
            _Deger.olcumZamani = DateTime.Now;
            _Deger.onbellek = 0;
            _Deger.pil = 255;
            _Deger.readerId = 19000;
            _Deger.rssi = 54;
            _Deger.sensorId = 40000;
            _Deger.sicaklik = 5.1;
            _Deger.yonelim = 1;

            try
            {               

                var factory = new ConnectionFactory()
                {

                    HostName = "172.16.252.140",
                    Port = 5672,
                    UserName = "telemetry",
                    Password = "rabitmq@telemetri",
                    VirtualHost = "/telemetry"
                };

                using (var connection = factory.CreateConnection())
                { 
                using (var channel = connection.CreateModel())
                {
                   

                }

                }



                //using (IConnection connection = factory.CreateConnection())
                //{

                //}

                MessageBox.Show("OLDU");

            }
            catch (Exception ex)
            {
                textBox1.Text = ex.ToString();
                MessageBox.Show("HATA");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var factory = new ConnectionFactory() {
                    HostName = "172.16.252.140",
                    Port=5672,
                    UserName= "telemetry",
                    Password= "rabitmq@telemetri",
                    VirtualHost= "/telemetry"
                };

                
                using (IConnection connection = factory.CreateConnection())
                {

                }

                MessageBox.Show("OLDU");

            }
            catch (Exception ex)
            {
                textBox1.Text = ex.ToString();
                MessageBox.Show("HATA");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fn_Versiyon_05();
        }

        private void fn_Versiyon_05()
        {
            cVeri _Deger = new cVeri();
            _Deger.alarm = 0;
            _Deger.dbm = -45;
            _Deger.kalibrasyonDegeri = 0;
            _Deger.kayitZamani = DateTime.Now;
            _Deger.olcumZamani = DateTime.Now;
            _Deger.onbellek = 0;
            _Deger.pil = 255;
            _Deger.readerId = 19000;
            _Deger.rssi = 54;
            _Deger.sensorId = 40000;
            _Deger.sicaklik = 5.1;
            _Deger.yonelim = 1;


            try
            {
                var factory = new ConnectionFactory()
                {
                    HostName = "172.16.252.140",
                    Port = 5672,
                    UserName = "telemetry",
                    Password = "rabitmq@telemetri",
                    VirtualHost = "/telemetry"
                };


                var connection = factory.CreateConnection();

                using (var channel = connection.CreateModel())
                {
                    var json = JsonConvert.SerializeObject(_Deger);
                    var body = Encoding.UTF8.GetBytes(json);
                   
                }


                    MessageBox.Show("OLDU");
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.ToString();
                MessageBox.Show("HATA");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fn_Versiyon_06
        }


        private void fn_Versiyon_06()
        {
            cVeri _Deger = new cVeri();
            _Deger.alarm = 0;
            _Deger.dbm = -45;
            _Deger.kalibrasyonDegeri = 0;
            _Deger.kayitZamani = DateTime.Now;
            _Deger.olcumZamani = DateTime.Now;
            _Deger.onbellek = 0;
            _Deger.pil = 255;
            _Deger.readerId = 19000;
            _Deger.rssi = 54;
            _Deger.sensorId = 40000;
            _Deger.sicaklik = 5.1;
            _Deger.yonelim = 1;


            try
            {
                var factory = new ConnectionFactory()
                {
                    HostName = "172.16.252.140",
                    Port = 5672,
                    UserName = "telemetry",
                    Password = "rabitmq@telemetri",
                    VirtualHost = "/telemetry"
                };


                var connection = factory.CreateConnection();

                using (var channel = connection.CreateModel())
                {
                    var json = JsonConvert.SerializeObject(_Deger);
                    var body = Encoding.UTF8.GetBytes(json);

                }


                MessageBox.Show("OLDU");
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.ToString();
                MessageBox.Show("HATA");
            }
        }
    }
}
