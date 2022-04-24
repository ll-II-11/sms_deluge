using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SmsDeluge.WinForm.Extensions
{
    public static class UriExtension
    {
        public static async Task<string> SendHttpRequestAsync(this Uri uri, HttpMethod httpMethod, Dictionary<string, string> headers = null, string content = null)
        {
            if (headers == null)
            {
                headers = new Dictionary<string, string>();
                headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.85 Safari/537.36");
                headers.Add("Content-Type", "application/x-www-form-urlencoded");
            }
            if (!headers.ContainsKey("User-Agent"))
            {
                headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.85 Safari/537.36");
            }
            if (!headers.ContainsKey("Content-Type"))
            {
                headers.Add("Content-Type", "application/x-www-form-urlencoded");
            }
            using (var httpClient = new HttpClient())
            {
                httpClient.Timeout = new TimeSpan(TimeSpan.TicksPerSecond * 3);
                using (var httpRequestMessage = new HttpRequestMessage())
                {
                    httpRequestMessage.RequestUri = uri;
                    httpRequestMessage.Method = httpMethod;
                    if (httpMethod == HttpMethod.Post && !string.IsNullOrWhiteSpace(content))
                    {
                        headers.TryGetValue("Content-Type", out string contentType);
                        headers.Remove("Content-Type");
                        try
                        {
                            httpRequestMessage.Content = new StringContent(content, Encoding.UTF8, contentType.Split(',')[0]);
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                    }
                    foreach (var header in headers)
                    {
                        httpRequestMessage.Headers.TryAddWithoutValidation(header.Key, header.Value);
                    }
                    try
                    {
                        using (var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage))
                        {
                            var responseContent = await httpResponseMessage.Content.ReadAsStringAsync();
                            return responseContent.Replace("\r\n", "").Replace("\r", "").Replace("\n", "").Replace(" ", "").Replace("\"", "'");
                        }
                    }
                    catch (Exception ex)
                    {
                        return ex.Message;
                    }
                }
            }
        }
    }
}
