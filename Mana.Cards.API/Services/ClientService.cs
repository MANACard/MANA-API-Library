using Mana.Cards.API.Domain;
using Mana.Cards.API.Exceptions;
using Mana.Cards.API.Helpers;
using Mana.Cards.API.ServiceInterfaces;
using Mana.Cards.API.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace Mana.Cards.API.Services
{
    public class ClientService : IClientService
    {
        public void CreateClient(Domain.Client c, string card)
        {
            var url = String.Format("{0}", Config.ClientsEndpointURL);

            var request = System.Net.WebRequest.Create(url) as System.Net.HttpWebRequest;
            request.KeepAlive = true;

            request.Method = "POST";

            request.ContentType = "application/x-www-form-urlencoded";
            APIHeadersHelper.InjectAPIHeaders(request.Headers);

            var fields = new string[] { 

                string.Format("{0}={1}", "client[first_name]", c.Firstname),
                string.Format("{0}={1}", "client[last_name]", c.Lastname),
                string.Format("{0}={1}", "client[phone]", c.Phone),
                string.Format("{0}={1}", "client[email]", c.Email),
                string.Format("{0}={1}", "client[gender]", c.Gender),
                string.Format("{0}={1}", "client[city_id]", c.City),
                string.Format("{0}={1}", "client[address]", c.Address),
                string.Format("{0}={1}", "client[birth_date]", c.Birthdate.HasValue ? c.Birthdate.Value.Date.ToString("yyyy-MM-dd") : string.Empty),
                string.Format("{0}={1}", "client[terms_of_service]", "1"),
                string.Format("{0}={1}", "barcode", card)

            };


            var queryString = String.Join("&", fields);

            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(queryString);

            request.ContentLength = byteArray.Length;
            using (var writer = request.GetRequestStream()) { writer.Write(byteArray, 0, byteArray.Length); }

            string responseContent = null;
            try
            {
                using (var response = request.GetResponse() as System.Net.HttpWebResponse)
                {
                    using (var reader = new System.IO.StreamReader(response.GetResponseStream()))
                    {
                        responseContent = reader.ReadToEnd();
                    }

                    if (response.StatusCode == System.Net.HttpStatusCode.Created)
                    {

                    }
                }
            }
            catch (WebException e)
            {
                using (WebResponse response = e.Response)
                {
                    HttpWebResponse httpResponse = (HttpWebResponse)response;

                    if (httpResponse != null)
                    {
                        if ((int)httpResponse.StatusCode == 422)
                        {
                            using (Stream data = response.GetResponseStream())
                            {
                                using (var reader = new StreamReader(data))
                                {
                                    responseContent = reader.ReadToEnd();
                                }

                                var arra = JArray.Parse(responseContent);
                                string strErrors = "";
                                try
                                {

                                    foreach (var item in arra)
                                    {
                                        strErrors += item.ToString();
                                    }
                                }
                                catch (Exception)
                                {
                                    throw;
                                }

                                throw new Exception(strErrors);
                            }
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
        public void UpdateClient(Client c, string card)
        {
            var url = String.Format("{0}/{1}", Config.ClientsEndpointURL, c.Id);

            var request = System.Net.WebRequest.Create(url) as System.Net.HttpWebRequest;
            request.KeepAlive = true;

            request.Method = "PUT";

            request.ContentType = "application/x-www-form-urlencoded";

            APIHeadersHelper.InjectAPIHeaders(request.Headers);

            var fields = new string[] { 

                string.Format("{0}={1}", "client[id]", c.Id),
                string.Format("{0}={1}", "barcode", card)

            };


            var queryString = String.Join("&", fields);

            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(queryString);

            request.ContentLength = byteArray.Length;
            using (var writer = request.GetRequestStream()) { writer.Write(byteArray, 0, byteArray.Length); }

            string responseContent = null;
            try
            {
                using (var response = request.GetResponse() as System.Net.HttpWebResponse)
                {
                    using (var reader = new System.IO.StreamReader(response.GetResponseStream()))
                    {
                        responseContent = reader.ReadToEnd();
                    }

                    if (response.StatusCode == System.Net.HttpStatusCode.Created)
                    {

                    }
                }
            }
            catch (WebException e)
            {
                using (WebResponse response = e.Response)
                {
                    HttpWebResponse httpResponse = (HttpWebResponse)response;

                    if (httpResponse != null)
                    {
                        if ((int)httpResponse.StatusCode == 422)
                        {
                            using (Stream data = response.GetResponseStream())
                            {
                                using (var reader = new StreamReader(data))
                                {
                                    responseContent = reader.ReadToEnd();
                                }

                                var arra = JArray.Parse(responseContent);
                                string strErrors = "";
                                try
                                {

                                    foreach (var item in arra)
                                    {
                                        strErrors += item.ToString();
                                    }
                                }
                                catch (Exception)
                                {
                                    throw;
                                }

                                throw new Exception(strErrors);
                            }
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

        public IEnumerable<ViewModels.ClientViewModel> Search(string firstname, string lastname, string email, string phone)
        {
            var url = String.Format("{0}", Config.ClientsSearchEndpointURL);
            var fields = new string[] { 

                string.Format("{0}={1}", "q[first_name_eq]", firstname),
                string.Format("{0}={1}", "q[last_name_eq]", lastname),
                string.Format("{0}={1}", "q[phone_eq]", phone),
                string.Format("{0}={1}", "q[email_eq]", email)

            };


            var queryString = String.Join("&", fields);

            var request = System.Net.WebRequest.Create(String.Format("{0}?{1}", url, queryString)) as System.Net.HttpWebRequest;
            request.KeepAlive = true;


            request.Method = "GET";

            APIHeadersHelper.InjectAPIHeaders(request.Headers);


            string responseContent = null;
            try
            {
                using (var response = request.GetResponse() as System.Net.HttpWebResponse)
                {
                    using (var reader = new System.IO.StreamReader(response.GetResponseStream()))
                    {
                        responseContent = reader.ReadToEnd();
                    }

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var clients = JsonConvert.DeserializeObject<IEnumerable<ClientViewModel>>(responseContent);
                        return clients;
                    }
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
