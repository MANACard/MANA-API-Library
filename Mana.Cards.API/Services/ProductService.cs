using Mana.Cards.API.Domain;
using Mana.Cards.API.Exceptions;
using Mana.Cards.API.Helpers;
using Mana.Cards.API.ServiceInterfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Mana.Cards.API.Services
{
    public class ProductService : IProductService
    {
        public ProductsViewModel GetProducts(int page = 1, int per_page = 25, string searchText = "")
        {
            var url = String.Format("{0}{1}?page={2}&per_page={3}", Config.APIUrl, "/products", page, per_page);

            if (!string.IsNullOrEmpty(searchText)) {
                url = String.Format("{0}&terms={1}", url, searchText);
            }


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

                    var products = JsonConvert.DeserializeObject<ProductsViewModel>(responseContent);

                    return products;
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
    }
}
