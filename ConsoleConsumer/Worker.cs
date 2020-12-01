using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ModelLib.model;
using Newtonsoft.Json;

namespace ConsoleConsumer
{
    class Worker
    {
        private static string URI = "http://fanapi.azurewebsites.net/api/fan";
        public async void Start()
        {
            List<FanOutput> fanlist = new List<FanOutput>();
            fanlist = (List<FanOutput>)await GetAllItemsAsync();
            foreach (var fans in fanlist)
            {
                Console.WriteLine(fans.ToString());
            }
        }

        public static async Task<IList<FanOutput>> GetAllItemsAsync()
        {
            Console.WriteLine("++ Get All Items ++\n");
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync(URI);
                IList<FanOutput> cList = JsonConvert.DeserializeObject<IList<FanOutput>>(content);
                return cList;

            }
        }
    }
}
