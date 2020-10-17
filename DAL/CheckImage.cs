using BL.BE;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CheckImage
    {
        public void GetDescriptions(ImageContent CurrentImage)
        {
            string apiKey = "acc_6a6cfeacde2f0c3";
            //  string apiSecret = "0c39d96f639ed5afd2643b4ee0784fa0";
            string apiSecret = "2ca2e9cbbef0c9c1f52886d772b715e6";
            string image = CurrentImage.ImagePath;

            string basicAuthValue = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(String.Format("{0}:{1}", apiKey, apiSecret)));

            var client = new RestClient("https://api.imagga.com/v2/tags");
            client.Timeout = -1;

            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", String.Format("Basic {0}", basicAuthValue));
            request.AddFile("image", image);
            IRestResponse response = client.Execute(request);
            Root DetailsTree = JsonConvert.DeserializeObject<Root>(response.Content);
            Console.WriteLine(response.Content);
            foreach (var item in DetailsTree.result.tags)
            {
                CurrentImage.ImageDetails.Add(item.tag.en, item.confidence);
            }
        }
    }
}