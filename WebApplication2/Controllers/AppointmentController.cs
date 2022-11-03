using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class AppointmentController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //    string today = DateTime.Now.ToShortDateString();
        //    return Ok(today);
        //}
        public IActionResult Index(int id)
        {
            return Ok("No appointment for user" + id);
        }
        public IActionResult Getname([FromQuery(Name = "name")] string name)
        {
            return Ok("Hi" + name);
        }
        public IActionResult GetZokiName([FromQuery(Name = "name")] string name)
        {
            return Ok("Hi " + name + "You are Stupid");
        }
    }
}
