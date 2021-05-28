using System.Collections.Generic;
using System.IO;

using Newtonsoft.Json;

namespace Todo.Data
{
    public class TodoItemService
    {
        private static List<TodoItem> _data = new List<TodoItem>()
        {
        };

        private readonly string _file = "Data\\todo.js";

        public List<TodoItem> GetData()
        {
            if (File.Exists(_file))
            {
                using var file = File.OpenText(_file);
                var serializer = new JsonSerializer();
                _data = serializer.Deserialize(file, typeof(List<TodoItem>)) as List<TodoItem>;
            }
            return _data;
        }

        public void SaveChanges()
        {
            using var file = File.CreateText(_file);
            var serializer = new JsonSerializer();
            serializer.Serialize(file, _data);
        }
    }
}
