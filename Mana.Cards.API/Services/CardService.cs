using Mana.Cards.API.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Mana.Cards.API.Domain;
using System.Net;
using Mana.Cards.API.Exceptions;

namespace Mana.Cards.API.Services
{
    public class CardService : ICardService
    {
        public CardInfo GetCardInfo(string barcode)
        {
            var url = String.Format("{0}/{1}", Config.CardsEndpointURL, barcode);

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

                    var card = JsonConvert.DeserializeObject<CardInfo>(responseContent);

                    return card;
                }
            }
            catch (WebException e)
            {

                using (WebResponse response = e.Response)
                {
                    HttpWebResponse httpResponse = (HttpWebResponse)response;

                    if (httpResponse != null)
                    {
                        if (httpResponse.StatusCode == HttpStatusCode.NotFound)
                        {
                            throw new CardNotFoundException();
                        }
                        else if (httpResponse.StatusCode == HttpStatusCode.Unauthorized)
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

        }

        public RedeemRule GetRedeemRule()
        {
            var url = String.Format("{0}/{1}", Config.CardsEndpointURL, "redeem_rules");

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

                    var rule = JsonConvert.DeserializeObject<RedeemRule>(responseContent);

                    return rule;
                }
            }
            catch (WebException e)
            {

                using (WebResponse response = e.Response)
                {
                    HttpWebResponse httpResponse = (HttpWebResponse)response;

                    if (httpResponse != null)
                    {
                        if (httpResponse.StatusCode == HttpStatusCode.NotFound)
                        {
                            throw new CardNotFoundException();
                        }
                        else if (httpResponse.StatusCode == HttpStatusCode.Unauthorized)
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
        }

        public CardInfo Resolve(DateTime birthdate, string phone)
        {
            var url = String.Format("{0}?birth_date={1}&phone={2}", Config.ClientsCardResolveURL, birthdate.ToString("yyyy-MM-dd"), phone);

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

                    var card = JsonConvert.DeserializeObject<CardInfo>(responseContent);

                    return card;
                }
            }
            catch (WebException e)
            {

                using (WebResponse response = e.Response)
                {
                    HttpWebResponse httpResponse = (HttpWebResponse)response;

                    if (httpResponse != null)
                    {
                        if (httpResponse.StatusCode == HttpStatusCode.NotFound)
                        {
                            throw new CardNotFoundException();
                        }
                        else if (httpResponse.StatusCode == HttpStatusCode.Unauthorized)
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
