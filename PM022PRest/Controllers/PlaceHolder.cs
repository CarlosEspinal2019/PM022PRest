using System;
using Newtonsoft;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PM022PRest.Models;

namespace PM022PRest.Controllers
{
    public static class PlaceHolder
    {
        public async static Task<List<Models.Posts>> GetPosts();
        {
            List<Models.Posts> posts = new List<Models.Posts>();
            using(HttpClient client = new HttpClient())
        {
           var response = await ClientCertificateOption.GetAsync("https://jsonplaceholder.typicode.com/posts"); 
            
            if (reponse.IsSuccessStatusCode)     
        {
            posts = JsonConvert.DeserializedObjet<List<Models.Posts>>(reponse.)
        }
        
        }
        return posts;
        }
    }
}
