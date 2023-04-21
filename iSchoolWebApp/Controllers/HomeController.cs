using iSchoolWebApp.Models;
using iSchoolWebApp.Service;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace iSchoolWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        // every one of these needs the Task<T>
        public async Task<IActionResult> About()
        {
            // things to do...
            /* create a model
             * go get data and feed it to the model
             * send that data model to the view
             */
            // build the model - go to https://json2csharp.com/ and put in the api result that you want (about)
            // get data
            DataRetrieval dataR = new DataRetrieval();
            // load in the instance data
            var loadedAbout = await dataR.GetData("about/");
            // loadedAbout is a string - cast it to AboutRootModel
            var rtnResult = JsonConvert.DeserializeObject<AboutRootModel>(loadedAbout);
            // send to view
            return View(rtnResult);
        }

        public async Task<IActionResult> Degrees()
        {
            // get data
            DataRetrieval dataR = new DataRetrieval();
            // load in the instance data
            var loadedDegrees = await dataR.GetData("degrees/");
            // loadedDegrees is a string - cast it to DegreesRootModel
            var rtnResult = JsonConvert.DeserializeObject<DegreesRootModel>(loadedDegrees);
            // send to view
            return View(rtnResult);
        }

        public async Task<IActionResult> Minors()
        {
            // get data
            DataRetrieval dataR = new DataRetrieval();
            // load in the instance data
            var loadedMinors = await dataR.GetData("minors/");
            // loadedMinors is a string - cast it to MinorsRootModel
            var rtnResult = JsonConvert.DeserializeObject<MinorsRootModel>(loadedMinors);
            // send to view
            return View(rtnResult);
        }

        public async Task<IActionResult> Employment()
        {
            // get data
            DataRetrieval dataR = new DataRetrieval();
            // load in the instance data
            var loadedEmployment = await dataR.GetData("employment/");
            // loadedEmployment is a string - cast it to EmploymentRootModel
            var rtnResult = JsonConvert.DeserializeObject<EmploymentRootModel>(loadedEmployment);
            // send to view
            return View(rtnResult);
        }

        public async Task<IActionResult> People()
        {
            // get data
            DataRetrieval dataR = new DataRetrieval();
            // load in the instance data
            var loadedPeople = await dataR.GetData("people/");
            // loadedPeople is a string - cast it to PeopleRootModel
            var rtnResult = JsonConvert.DeserializeObject<PeopleRootModel>(loadedPeople);
            // send to view
            return View(rtnResult);
        }

        /*Courses on Demand*/
        public async Task<IActionResult> Course(String course)
        {
            // get data
            DataRetrieval dataR = new DataRetrieval();
            // load in the instance data for a particular course
            var loadedCourse = await dataR.GetData("course/courseID=" + course);
            // loadedCourse is a string - cast it to CourseRootModel
            var rtnResult = JsonConvert.DeserializeObject<CourseRootModel>(loadedCourse);
            // send to view
            return View(rtnResult);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}