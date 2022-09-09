using RabbitMQ.Client;

namespace Versiyon_01.Important
{
    public class RabbitMQService
    {
        // localhost üzerinde kurulu olduğu için host adresi olarak bunu kullanıyorum.
        //private readonly string _hostName = "localhost";
        private readonly string _HostName = "172.16.252.140";
        private readonly string _UserName = "telemetry";
        private readonly string _Password = "rabitmq@telemetri";
        private readonly string _VirtualHost = "/telemetry";
        private readonly int _Port = 5672;

        public IConnection GetRabbitMQConnection()
        {
            ConnectionFactory connectionFactory = new ConnectionFactory()
            {
                // RabbitMQ'nun bağlantı kuracağı host'u tanımlıyoruz. Herhangi bir güvenlik önlemi koymak istersek, Management ekranından password adımlarını tanımlayıp factory içerisindeki "UserName" ve "Password" property'lerini set etmemiz yeterlidir.
                HostName = _HostName,
                Port = _Port,
                UserName = _UserName,
                Password = _Password,
                VirtualHost = _VirtualHost,
                
            };

            IConnection _Yanit= connectionFactory.CreateConnection();

            return _Yanit;
        }
    }
}
