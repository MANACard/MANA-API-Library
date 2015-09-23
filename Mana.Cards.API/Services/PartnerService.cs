using Mana.Cards.API.Exceptions;
using Mana.Cards.API.Helpers;
using Mana.Cards.API.ServiceInterfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Mana.Cards.API.Services
{
    public class PartnerService : IPartnerService
    {
        public string GetMyName()
        {
            var url = String.Format("{0}/{1}", Config.APIUrl, "current");

            var request = System.Net.WebRequest.Create(url) as System.Net.HttpWebRequest;
            request.KeepAlive = true;

            request.Method = "GET";
            request.ContentLength = 0;


            request.ContentType = "application/json";

            APIHeadersHelper.InjectAPIHeaders(request.Headers);

            try
            {
                string responseContent = null;
                using (var response = request.GetResponse() as System.Net.HttpWebResponse)
                {
                    using (var reader = new System.IO.StreamReader(response.GetResponseStream()))
                    {
                        responseContent = reader.ReadToEnd();
                    }
                    var obj = JObject.Parse(responseContent);

                    return obj["name"].ToString();
                }
            }
            catch (WebException e)
            {

                using (WebResponse response = e.Response)
                {
                    HttpWebResponse httpResponse = (HttpWebResponse)response;

                    if (httpResponse != null)
                    {
                        if (httpResponse.StatusCode == HttpStatusCode.Unauthorized)
                        {
                            throw new AuthenticationFailedException();
                        }
                    }
                }
                throw;
            }
            catch (Exception e)
            {
                throw;
            }

            return null;
        }
    }
}
