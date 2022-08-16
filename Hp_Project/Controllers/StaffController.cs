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
    public class StaffController : Controller
    {
        string Baseurl = "http://hp-api.herokuapp.com/";
        // GET: Staff
        public async Task<ActionResult> Index()
        {
            List<Staff> staff = new List<Staff>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/characters/staff");
                if (Res.IsSuccessStatusCode)
                {
                    var StaffResponse = Res.Content.ReadAsStringAsync().Result;
                    staff = JsonConvert.DeserializeObject<List<Staff>>(StaffResponse);
                }

                return View(staff);
            }



        }
    }
}