using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nexmo.Api;

namespace ExhibitMvc.Authentication
{
  public class FullAuth
  {
    public FullAuth()
    {
      var client = new Client(creds: new Nexmo.Api.Request.Credentials
      {
        ApiKey = "NEXMO_API_KEY",
        ApiSecret = "NEXMO_API_SECRET",
        ApplicationId = "NEXMO_APPLICATION_ID",
        ApplicationKey = "NEXMO_APPLICATION_PRIVATE_KEY"
      });
    }
  }
}