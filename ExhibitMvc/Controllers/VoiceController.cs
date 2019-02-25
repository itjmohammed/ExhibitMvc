using System.Web.Mvc;
using System.Web.Hosting;
using Nexmo.Api;
using Nexmo.Api.Voice;

namespace ExhibitMvc.Controllers
{
    public class VoiceController : Controller
    {
        public Client Client { get; set; }

        public VoiceController()
        {
            Client = new Client(creds: new Nexmo.Api.Request.Credentials
            {
                ApiKey = "7825fda6",
                ApiSecret = "n0IbvACFT1eSzF4l",
                ApplicationId = "97bed2fe-3eb9-4678-bb68-c63ebcb5d45d",
                ApplicationKey = System.IO.File.ReadAllText(HostingEnvironment.MapPath(@"~/App_Data/private.key"))
            });
        }

        // GET: Voice
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult MakeCall()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MakeCall(string to)
        {
            var TO_NUMBER = to;
            var NEXMO_NUMBER = "447520632469";
            
            var results = Client.Call.Do(new Call.CallCommand
            {
                to = new[]
                {
                    new Call.Endpoint {
                        type = "phone",
                        number = TO_NUMBER
                    }
                },
                from = new Call.Endpoint
                {
                    type = "phone",
                    number = NEXMO_NUMBER
                },
                answer_url = new[]
                {
                    "https://gist.githubusercontent.com/tjabitta/064e2642e5a96d8f18b63f6bd0ff27b7/raw/67cc24076e7e19a1c15bff3215c111165bc37cb7/demogist.json"
                }
            });

            Session["UUID"] = results.uuid;
            
            return RedirectToAction("MakeCall"); ;
        }
    }
}