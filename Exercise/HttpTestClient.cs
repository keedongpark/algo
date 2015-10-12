using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Exercise
{
    public class HttpTestClient
    {
        public static async void DownloadPageAsync()
        {
            string page = "url to the target document";

            try
            {
                using (HttpClient client = new HttpClient())
                using (HttpResponseMessage response = await client.GetAsync(page))
                using (HttpContent content = response.Content)
                {
                    Console.WriteLine(response);

                    string result = await content.ReadAsStringAsync();

                    if (result != null && result.Length >= 50)
                    {
                        Console.WriteLine(result.Substring(0, 50) + "...");
                    }
                }
            }
            catch ( Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
