using GreyNoise.Results;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace GreyNoise
{

    public class GreyNoise
    {

        private static string endpoint = "https://api.greynoise.io/v2/";
        private string key;

        public GreyNoise(string _key)
        {
            this.key = _key;
        }

        public ContextResult Context(string ip)
        {
            HttpResult httpResult = this.Query("noise/context/" + ip);

            return JsonConvert.DeserializeObject<ContextResult>(httpResult.Data);
        }

        public QuickCheckResult QuickCheck(string ip)
        {
            HttpResult httpResult = this.Query("noise/quick/" + ip);

            return JsonConvert.DeserializeObject<QuickCheckResult>(httpResult.Data);
        }

        public List<QuickCheckResult> MultiQuickCheck(string ip)
        {
            HttpResult httpResult = this.Query("noise/multi/quick?ips=" + ip);

            return JsonConvert.DeserializeObject<List<QuickCheckResult>>(httpResult.Data);
        }

        private HttpResult Query(string path)
        {
            WebRequest request = WebRequest.Create(endpoint + path);

            request.Headers.Add("key", key);
            request.ContentType = "application/json; charset=utf-8";

            WebResponse response = request.GetResponse();
            HttpWebResponse httpResponse = (HttpWebResponse) response;
            Stream dataStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(dataStream, Encoding.UTF8);

            return new HttpResult((int)httpResponse.StatusCode, readStream.ReadToEnd());
        }

    }
}
