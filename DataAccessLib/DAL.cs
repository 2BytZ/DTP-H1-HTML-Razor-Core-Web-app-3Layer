using System.Reflection;
using System.Text.Json;

namespace DataAccessLib
{
    // holder data
    public class DAL
    {
        public string GetData()
        {
            var builtDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string path = Path.Combine(builtDir, "Data", "courses.json");
            return File.ReadAllText(path);
        }
    }
}
