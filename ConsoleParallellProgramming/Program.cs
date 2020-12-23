using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleParallellProgramming
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Data
    {
        public string id { get; set; }
        public string name { get; set; }
        public string nameShortDisplay { get; set; }
        public string status { get; set; }
        public string statusDisplay { get; set; }
        public string createDate { get; set; }
        public string updateDate { get; set; }
        public string isInBusiness { get; set; }
        public string isVerified { get; set; }
    }

    public class BeerInfo
    {
        public string message { get; set; }
        public Data data { get; set; }
        public string status { get; set; }
    }
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<BeerInfo> beers = new List<BeerInfo>();
            HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://api.brewerydb.com/v2/");

            var stopwatch = Stopwatch.StartNew();

            var content1 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content1));

            var content2 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content2));

            var content3 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content3));

            var content4 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content4));

            var content5 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content5));

            var content6 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content6));

            var content7 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content7));

            var content8 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content8));

            var content9 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content9));

            var content10 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content10));

            var content11 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content11));

            var content12 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content12));

            var content13 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content13));

            var content14 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content14));

            var content15 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content15));

            var content16 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content16));

            var content17 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content17));

            var content18 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content18));

            var content19 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content19));

            var content20 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content20));

            var content21 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content21));

            var content22 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content22));

            var content23 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content23));

            var content24 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content24));

            var content25 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content25));

            var content26 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content26));

            var content27 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content27));

            var content28 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content28));

            var content29 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content29));

            var content30 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content30));

            var content31 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content31));

            var content32 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
            beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content32));


            var time = stopwatch.Elapsed;
            Console.WriteLine("Non parallel call time {0}", time.TotalSeconds);

            Console.ReadLine();


            var stopwatch1 = Stopwatch.StartNew();

            //Below approach is not recommended while making I/O blocking call - rather go for Task.WhenAll in these cases

            Parallel.Invoke(
                async () =>
                {

                    var content33 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
                    beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content33));

                },
                async () =>
                {

                    var content34 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
                    beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content34));

                },
                async () =>
                {

                    var content35 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
                    beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content35));

                },
                async () =>
                {

                    var content36 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
                    beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content36));

                },
                async () =>
                {

                    var content37 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
                    beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content37));

                },
                async () =>
                {

                    var content38 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
                    beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content38));

                },
                async () =>
                {

                    var content39 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
                    beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content39));

                },
                async () =>
                {

                    var content40 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
                    beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content40));

                },
                async () =>
                {

                    var content41 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
                    beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content41));

                },
                async () =>
                {

                    var content42 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
                    beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content42));

                },
                async () =>
                {

                    var content43 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
                    beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content43));

                },
                async () =>
                {

                    var content44 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
                    beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content44));

                },
                async () =>
                {

                    var content45 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
                    beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content45));

                },
                async () =>
                {

                    var content46 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
                    beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content46));

                },
                async () =>
                {

                    var content47 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
                    beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content47));

                },
                async () =>
                {

                    var content48 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
                    beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content48));

                },
                async () =>
                {

                    var content49 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
                    beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content49));

                },
                async () =>
                {

                    var content50 = await client.GetStringAsync("http://api.brewerydb.com/v2/brewery/random/?key=5135f30dee191bc81e6d6a654cc29262");
                    beers.Add(JsonConvert.DeserializeObject<BeerInfo>(content50));

                }
                );

            var time1 = stopwatch1.Elapsed;

            Console.WriteLine("added 27 elements in {0}", time1.TotalSeconds);

            Console.ReadLine();

        }
    }
}
