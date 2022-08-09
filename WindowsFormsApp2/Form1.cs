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
            string _YaziParse = "{\"idDeviceData\": 0,\"deviceUid\": \"\",\"gsmNetwork\": \"\",\"gsmNetworkQuality\": 0.0,\"wifiNetworkState\": true/false,\"wifiSignalQuality\": 0.0,\"ethernetState\": true/false,\"onPower\": true/false,\"batteryVoltage\": 0.0,\"batteryPercent\": 0,\"batteryLife\": 0,\"fridgeTemprature\": 0.0,\"internalModuleTemprature\": 0.0,\"externalModuleTemprature\": 0.0,\"doorOpen\": true/false,\"lightLevel\": 0.0,\"alarmCode\": \"\",\"alarmDescription\": \"\",\"faultCode\": \"\",\"faultDescription\": \"\",\"workingCounter\": 0L,\"restartCounter\": 0L,\"dataSize\": 0.0,\"reportDate\": \"TIMESTAMP\",\"fridgeName\": \"\",\"reportDateEpoch\": 0L}";

           


        }
    }
}
