using Microsoft.AspNetCore.Mvc;
using Mom2.Models;
using Newtonsoft.Json;

namespace moment2.Controllers
{
    public class TildaController : Controller
    {
        private readonly ILogger<TildaController> _logger;

        public TildaController(ILogger<TildaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //sessionsvariable
            string s2 = HttpContext.Session.GetString("test");
            ViewBag.text = s2;

            return View();
        }

        //about-page
        [HttpGet("/about")]
        public IActionResult About()
        {

            //sessionvariable
            string s = "This is a text from a session.";
            HttpContext.Session.SetString("test", s);

            return View();
            
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(SongModel model)
        {
            if (ModelState.IsValid)
            {
                //lagra
                var JsonStr = System.IO.File.ReadAllText("songs.json");
                var JsonObj = JsonConvert.DeserializeObject<List<SongModel>>(JsonStr);

                if (JsonObj != null)
                {
                    JsonObj.Add(model);
                }
                //convert to json-string and save
                System.IO.File.WriteAllText("songs.json", JsonConvert.SerializeObject(JsonObj, Formatting.Indented));
                ModelState.Clear();
            }
            return View();
        }

        //songs-page
        [HttpGet("/songs")]
        public IActionResult Songs()
        {
            var JsonStr = System.IO.File.ReadAllText("songs.json");
            var JsonObj = JsonConvert.DeserializeObject<List<SongModel>>(JsonStr);

            ViewBag.Description = "Songs!";
            return View(JsonObj);
        }
    }



    }

   
