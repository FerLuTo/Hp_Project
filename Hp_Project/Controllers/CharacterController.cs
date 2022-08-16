using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Hp_Project.Models;
using System.Threading.Tasks;

namespace Hp_Project.Controllers
{
    public class CharacterController : Controller
    {
        string Baseurl = "http://hp-api.herokuapp.com/";
        // GET: Character
        public async Task<ActionResult> Index()
        {
            List<Character> character = new List<Character>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/characters");
                if (Res.IsSuccessStatusCode)
                {
                   var CharacResponse = Res.Content.ReadAsStringAsync().Result;
                   character = JsonConvert.DeserializeObject<List<Character>>(CharacResponse);
                }
               
                return View(character);
            }

                 
            
        }
    }
}