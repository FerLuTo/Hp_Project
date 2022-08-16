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
    public class StudentController : Controller
    {
        // GET: Student
        string Baseurl = "http://hp-api.herokuapp.com/";
       
        public async Task<ActionResult> Index()
        {
            List<Student> student = new List<Student>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/characters/students ");
                if (Res.IsSuccessStatusCode)
                {
                    var StudResponse = Res.Content.ReadAsStringAsync().Result;
                    student = JsonConvert.DeserializeObject<List<Student>>(StudResponse);
                }

                return View(student);
            }



        }
    }
}