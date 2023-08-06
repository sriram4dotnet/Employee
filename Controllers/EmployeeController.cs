using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Employee.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetEmployeeDetails")]
        public EmployeeObject Get()
        {
            // Specify the path to the JSON file
            string filePath = "./employeeData.json";

            // Read the JSON content from the file
            string json = System.IO.File.ReadAllText(filePath);

            EmployeeObject employee = JsonConvert.DeserializeObject<EmployeeObject>(json);

            return employee;
        }
    }
}