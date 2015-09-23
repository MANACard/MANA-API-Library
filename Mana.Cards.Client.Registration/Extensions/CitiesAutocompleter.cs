using Mana.Cards.API.Helpers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Mana.Cards.Client.Registration.Extensions
{
    public class CitiesAutocompleter
    {
        public TaggedAutoCompleteStringCollection SearchCities(string term)
        {

            var collection = new TaggedAutoCompleteStringCollection();

            var url = String.Format(Config.CitiesSearchURL, term);

            var request = System.Net.WebRequest.Create(url) as System.Net.HttpWebRequest;
            request.KeepAlive = true;

            request.Method = "GET";
            request.ContentLength = 0;

            request.ContentType = "application/json";
            try
            {
                string responseContent = null;
                using (var response = request.GetResponse() as System.Net.HttpWebResponse)
                {
                    using (var reader = new System.IO.StreamReader(response.GetResponseStream()))
                    {
                        responseContent = reader.ReadToEnd();
                    }

                    var results = JArray.Parse(responseContent);
                    foreach (var item in results)
                    {
                        collection.Add(item["name"].ToString(), item["id"]);
                    }
                }
            }
            catch (WebException ex)
            {
            }
            catch (Exception)
            {
            }

            return collection;

        }
    }
}
