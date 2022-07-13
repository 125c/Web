using _06webAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace _06webAPI.Controllers
{
    public class Covid19APIController : ApiController
    {
        public async Task<IEnumerable<Covid19>> Get()
        {
            string url = "https://covid-19.nchc.org.tw/api/covid19?CK=covid-19@nchc.org.tw&querydata=5002";
            HttpClient client = new HttpClient();
            client.MaxResponseContentBufferSize = Int32.MaxValue;
            var resp = await client.GetStringAsync(url);
            var collection = JsonConvert.DeserializeObject<IEnumerable<Covid19>>(resp);
            return collection;
        }
    }
}
