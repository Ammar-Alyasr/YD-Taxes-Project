using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Task t = new Task(DownloadPageAsync);
            t.Start();
            Console.WriteLine("Downloading page...");

            // Create web client.
            WebClient client = new WebClient();

            // Download string.
            string value = client.DownloadString("http://localhost:55555/Home/Login");

            // Write values.
            Console.WriteLine("--- WebClient result ---");
            Console.WriteLine(value.Length);
            Console.WriteLine(value);

            Console.ReadLine();
        }

        static async void DownloadPageAsync()
        {
    
            string page = "http://localhost:55555/Home/Login";
                
            // ... Use HttpClient.
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(page))
            using (HttpContent content = response.Content)
            {

                string result = await content.ReadAsStringAsync();

               // Console.WriteLine(result);

            }
        }
    }
}
