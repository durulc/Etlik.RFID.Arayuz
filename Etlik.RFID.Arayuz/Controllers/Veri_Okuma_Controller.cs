using Etlik.RFID.Arayuz.Manager;
using System.Web.Http;

namespace Etlik.RFID.Arayuz.Controllers
{
    public class Veri_Okuma_Controller : ApiController
    {
        [HttpPost,HttpGet]
        [Route("api/classes/RTLS")]
        public void RTLS(object v_gelen)
        {
             new Veri_Okuma_Manager().fn_RTLS(v_gelen);
        }

        [HttpPost, HttpGet]
        [Route("api/VeriTabaniOlustur")]
        public void VeriTabaniOlustur()
        {
            new Veri_Okuma_Manager().fn_VeriTabaniOlustur();
        }
    }
}
