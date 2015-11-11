using Mana.Cards.API.Domain;
using Mana.Cards.API.Exceptions;
using Mana.Cards.API.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Mana.Cards.API.Services
{
    public class SaleService : ISaleService
    {
        public Domain.SaleInfo SubmitSale(Domain.Sale sale, string transactionId)
        {
            var url = String.Format("{0}", Config.SalesEndpointURL);

            var request = System.Net.WebRequest.Create(url) as System.Net.HttpWebRequest;
            request.KeepAlive = true;

            request.Method = "POST";

            request.ContentType = "application/json";

            APIHeadersHelper.InjectAPIHeaders(request.Headers);

            request.Headers.Add("MANA-Transaction-Id", transactionId);

            string saleObj = JsonConvert.SerializeObject(sale);

            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(saleObj);

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

                        var saleInfo = JsonConvert.DeserializeObject<SaleInfo>(responseContent);

                        return saleInfo;
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

                                var obj = JObject.Parse(responseContent);

                                int code = 0;
                                string strCode = "";
                                try
                                {
                                    strCode = obj["errors"][0]["code"].ToString();
                                }
                                catch (Exception)
                                {

                                }

                                Int32.TryParse(strCode, out code);

                                if (code == 440)
                                {
                                    throw new NotEnoughPointsAvailableException();
                                }
                                else if (code == 441)
                                {
                                    throw new MorePointsRequiredException();
                                }
                                else if (code == 442)
                                {
                                    throw new CardNotActiveException();
                                }
                                else if (code == 443)
                                {
                                    throw new SaleAlreadySubmittedException();
                                }
                                else if (code == 445)
                                {
                                    throw new UnauthorizedCancellationException();
                                }
                                else if (code == 446)
                                {
                                    throw new SaleAlreadyCanceledException();
                                }
                                else
                                {
                                    throw new Exception("Validation exception");
                                }

                            }
                        }
                        else if (httpResponse.StatusCode == HttpStatusCode.NotFound)
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


        public IEnumerable<RecentSaleModel> GetRecentSales(string cardBarcode, int limit)
        {

            var url = String.Format("{0}?barcode={1}&limit={2}", Config.SalesEndpointURL, cardBarcode, limit);

            var request = System.Net.WebRequest.Create(url) as System.Net.HttpWebRequest;
            request.KeepAlive = true;

            request.Method = "GET";

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

                    var sales = JsonConvert.DeserializeObject<IEnumerable<RecentSaleModel>>(responseContent);

                    return sales;
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
        }

        public bool CancelSale(UInt64 id)
        {
            var url = String.Format("{0}/{1}/cancel", Config.SalesEndpointURL, id);

            var request = System.Net.WebRequest.Create(url) as System.Net.HttpWebRequest;
            request.KeepAlive = true;

            request.Method = "POST";

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

                    return true;
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
                            throw new UnauthorizedCancellationException();
                        }
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
 
        public bool CancelSale(int id, string cardBarcode, string phone)
        {
            var url = String.Format("{0}/{1}?card_barcode={2}&phone={3}", Config.SalesEndpointURL, id, cardBarcode, phone);

            var request = System.Net.WebRequest.Create(url) as System.Net.HttpWebRequest;
            request.KeepAlive = true;

            request.Method = "DELETE";

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

                    return true;
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
                            throw new UnauthorizedCancellationException();
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
    }
}
