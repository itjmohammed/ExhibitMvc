using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nexmo.Api;

namespace ExhibitMvc.Authentication
{
  public class BasicAuth
  {
    public BasicAuth()
    {
      var client = new Client(creds: new Nexmo.Api.Request.Credentials
      {
        ApiKey = "NEXMO_API_KEY",
        ApiSecret = "NEXMO_API_SECRET"
      });
    }
  }
}