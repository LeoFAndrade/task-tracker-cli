using System.Text.Json;
using TaskTracker.Models;

namespace TaskTracker.Services
{
    public class TaskRepository
    {
        /*Save serializes over a received list and creates a file 
         saving the serialized list of the variable*/  
        public void Save(List<TaskItem> tasks)
        {
            string json = JsonSerializer.Serialize(tasks);
            File.WriteAllText("tasks.json", json);
        }

        /*Load is an method that uses access the JSON file a*/
        public List<TaskItem> Load()
        {
            String filePath = "tasks.json";

            if (!File.Exists(filePath))
                return new List<TaskItem>();

            String json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<TaskItem>>(json) ?? new List<TaskItem>();
        }
    }
}