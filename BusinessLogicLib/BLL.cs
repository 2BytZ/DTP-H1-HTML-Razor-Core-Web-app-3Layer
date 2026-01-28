using System.Text.Json;

namespace BusinessLogicLib
{
    // behandler data
    public class BLL
    {
        public List<Course> ProcessData()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(),"DataAccessLib", "Data", "courses.json");
            var jsonData = JsonSerializer.Deserialize<List<Course>>(File.ReadAllText(path)); //how to get access to Course model?
            return jsonData;
        }
    }
}
