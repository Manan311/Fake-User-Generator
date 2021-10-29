using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Assignment2.Model;

namespace Assignment2.Service
{
    public class NetworkManager
    {
        readonly string url = "https://randomuser.me/api/";
        HttpClient client = new HttpClient();

        public async Task<ServiceUser> GetServiceUser(string serviceName, FilterData data)
        {
            // Creates a password that has upper, lower, special and number characters of size 16
            var response = await client.GetAsync(url + "?password=special,upper,lower,number,16-16");
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
            else
            {
                var stringResponse = await response.Content.ReadAsStringAsync();
                var dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(stringResponse);
                var result = dictionary.ElementAt(0).Value;
                var endResult = result.ToString();
                var resultObjects = JsonConvert.DeserializeObject<List<ResultObject>>(endResult);
                if (resultObjects.Count != 0)
                {
                    return new ServiceUser(serviceName, resultObjects.ElementAt(0), data);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
