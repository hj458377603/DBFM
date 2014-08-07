using DouBanFM.Services.Common.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DouBanFM.Services.Common
{
    public class HttpHelper
    {
        public async Task<string> HttpGetRequest(string url)
        {
            string result = string.Empty;
            try
            {
                result = await new HttpClient().GetStringAsync(url);
                return result;
            }
            catch
            {
                throw new HttpResponseErrorException();
            }
        }

        public async Task<string> HttpPostRequest(string url, string contentStr)
        {
            string result = string.Empty;
            try
            {
                byte[] buffer = UTF8Encoding.UTF8.GetBytes(contentStr);
                Stream stream = new MemoryStream(buffer);
                HttpContent content = new StreamContent(stream);

                HttpResponseMessage responseMsg = await new HttpClient().PostAsync(url, content);

                if (responseMsg != null && responseMsg.Content != null)
                {
                    result = await responseMsg.Content.ReadAsStringAsync();
                }
                return result;
            }
            catch
            {
                throw new HttpResponseErrorException();
            }
        }

        /// <summary>
        /// Http以Get方式请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task<T> HttpGetRequest<T>(string url) where T : class
        {
            string result = await HttpGetRequest(url);

            if (!string.IsNullOrEmpty(result))
            {
                return JsonConvert.DeserializeObject<T>(result);
            }
            return null;
        }

        /// <summary>
        /// Http以Post方式请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task<T> HttpPostRequest<T>(string url, string content) where T : class
        {
            string result = await HttpPostRequest(url, content);

            if (!string.IsNullOrEmpty(result))
            {
                    return JsonConvert.DeserializeObject<T>(result);
            }
            return null;
        }
    }
}
