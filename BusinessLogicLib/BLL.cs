using DataAccessLib;
using System.Text.Json;

namespace BusinessLogicLib
{
    // behandler data
    public class BLL
    {
        public List<Course> GetCourseData()
        {
            DAL database = new DAL();
            string json = database.GetData();
            List<Course> courses = JsonSerializer.Deserialize<List<Course>>(json);
            return courses;
        }
        public Course GetCourseData(int id)
        {
            DAL database = new DAL();
            string json = database.GetData();
            List<Course> courses = JsonSerializer.Deserialize<List<Course>>(json);
            return courses.FirstOrDefault(course => course.Id == id);
        }
    }
}
