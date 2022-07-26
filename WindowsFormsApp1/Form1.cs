using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        string _Yazi = @"{
    ""meta"": {
        ""version"": 1
    },
    ""reporter"": {
        ""name"": ""a8:5b:f7:c2:ff:b2"",
        ""mac"": ""A8:5B:F7:C2:FF:B2"",
        ""ipv4"": ""192.168.118.9"",
        ""ipv6"": ""fe80::aa5b:f7ff:fec2:ffb2"",
        ""hwType"": ""AP-505"",
        ""swVersion"": ""8.7.1.9"",
        ""swBuild"": ""83631"",
        ""time"": 1658764026
    },
    ""reported"": [
        {
            ""deviceClass"": [""iBeacon"", ""arubaBeacon""],
            ""model"": ""BT-AP500"",
            ""vendorName"": ""Aruba"",
            ""mac"": ""28:DE:65:5F:D6:00"",
            ""stats"": {
                ""frame_cnt"": 3,
                ""uptime"": 70140
            },
            ""beacons"": [
                {
                    ""ibeacon"": {
                        ""uuid"": ""4152554E-F99B-4A3B-86D0-947070693A78"",
                        ""major"": 0,
                        ""minor"": 470,
                        ""power"": -56
                    }
                }
            ],
            ""rssi"": {
                ""smooth"": -92
            },
            ""BeaconEvent"": {
                ""event"": ""update""
            },
            ""txpower"": 14,
            ""lastSeen"": 1658763984,
            ""firmware"": {
                ""bankB"": ""1.3-71"",
                ""bankA"": ""0.0-0""
            },
            ""sensors"": {
                ""battery"": 100
            }
        },
        {
            ""deviceClass"": [""iBeacon"", ""arubaBeacon""],
            ""model"": ""BT-AP500"",
            ""vendorName"": ""Aruba"",
            ""mac"": ""28:DE:65:5F:D6:0E"",
            ""stats"": {
                ""frame_cnt"": 112,
                ""uptime"": 70260
            },
            ""beacons"": [
                {
                    ""ibeacon"": {
                        ""uuid"": ""4152554E-F99B-4A3B-86D0-947070693A78"",
                        ""major"": 0,
                        ""minor"": 468,
                        ""power"": -56
                    }
                }
            ],
            ""rssi"": {
                ""smooth"": -80
            },
            ""BeaconEvent"": {
                ""event"": ""update""
            },
            ""txpower"": 14,
            ""lastSeen"": 1658764026,
            ""firmware"": {
                ""bankB"": ""1.3-71"",
                ""bankA"": ""0.0-0""
            },
            ""sensors"": {
                ""battery"": 100
            }
        },
        {
            ""deviceClass"": [""iBeacon"", ""arubaBeacon""],
            ""model"": ""BT-AP500"",
            ""vendorName"": ""Aruba"",
            ""mac"": ""28:DE:65:5F:D6:12"",
            ""stats"": {
                ""frame_cnt"": 134,
                ""uptime"": 71130
            },
            ""beacons"": [
                {
                    ""ibeacon"": {
                        ""uuid"": ""4152554E-F99B-4A3B-86D0-947070693A78"",
                        ""major"": 0,
                        ""minor"": 1112,
                        ""power"": -56
                    }
                }
            ],
            ""rssi"": {
                ""smooth"": -75
            },
            ""BeaconEvent"": {
                ""event"": ""update""
            },
            ""txpower"": 14,
            ""lastSeen"": 1658764026,
            ""firmware"": {
                ""bankB"": ""1.3-71"",
                ""bankA"": ""0.0-0""
            },
            ""sensors"": {
                ""battery"": 100
            }
        }
    ]
}
";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jSonVeri _Details = JsonConvert.DeserializeObject<jSonVeri>(_Yazi);

            int sayi = 1;
        }
    }
}
