using Etlik.RFID.Arayuz.Manager;
using Etlik.RFID.Arayuz.Request;
using Etlik.RFID.Arayuz.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Etlik.RFID.Arayuz.Controllers
{
    public class Veri_Okuma_Controller : ApiController
    {
        [HttpPost]
        [Route("api/classes/RTLS")]
        public void RTLS(RequestRTLS v_gelen)
        {
            new Veri_Okuma_Manager().fn_RTLS();
        }
    }
}
