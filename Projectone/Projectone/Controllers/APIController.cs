using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Data;

namespace Api
{
    public class ApiController : Controller
    {
        [HttpGet("/reviewAll")]
        public ContentResult GetAllStudents()
        {
            // you will always need this to return a response
            ContentResult response = new ContentResult();

            // connect to your database
            SQLRepository dbConn = new SQLRepository();
            // run the database function that gets all students
            List<Student> allStudents = dbConn.GetAllStudents();

            // content MUST be serialized (turned into) JSON in order to be sent back to your console
            string jsonContent = JsonSerializer.Serialize(allStudents);
            response = new ContentResult()
            {
                StatusCode = 200,
                ContentType = "application/json",
                Content = jsonContent
            };

            // this will return the list of students you have in your database
            return response;
        }
    }

    internal class SQLRepository
    {
        internal List<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }
    }
}
