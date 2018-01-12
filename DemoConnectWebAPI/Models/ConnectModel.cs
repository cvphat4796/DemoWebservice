using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.Models
{
    public static class ConnectModel
    {
        private static HttpClient client = new HttpClient() {
            BaseAddress = new Uri("http://localhost:52223")
        };

        //public static T GetModel<T>(this string requestURL)
        //{
        //    client.BaseAddress = new Uri("http://localhost:52223");
        //    client.DefaultRequestHeaders.Accept.Clear();
        //    client.DefaultRequestHeaders.Accept.Add(
        //        new MediaTypeWithQualityHeaderValue("application/json"));
            
        //    HttpResponseMessage response = client.GetAsync(requestURL).Result;
        //    if (response.IsSuccessStatusCode)
        //    {
        //        return response.Content.ReadAsAsync<T>().Result;
        //    }
        //    else
        //    {
        //        return "b";
        //    }
        //}

        public static async  Task<List<T>> GetListModel<T>(this string requestURL)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            List<T> ListModel = null;
            HttpResponseMessage response = await client.GetAsync(requestURL).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                ListModel = await response.Content.ReadAsAsync<List<T>>();
            }
            return await Task.Run(() => ListModel);
        }

        public static async Task<bool> Insert<T>(this T sinhVien, string request)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.PostAsJsonAsync(
                request, sinhVien).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            return response.IsSuccessStatusCode;
        }

        public static async Task<bool> Update<T>(this T sinhVien, string request)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.PutAsJsonAsync(
                request, sinhVien).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            return response.IsSuccessStatusCode;
        }

        public static async Task<bool> Delete(this string txtID, string request)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.DeleteAsync(
                request+"/"+txtID).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            return response.IsSuccessStatusCode;
        }
    }
}
