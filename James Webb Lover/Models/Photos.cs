using System.ComponentModel.DataAnnotations;

namespace James_Webb_Lover.Models
{
    public class Photos
    {
        public string Path { get; set; }

        public string Description { get; set; }

        public Photos(string path, string description)
        {
            Path = path;
            Description = description;
        }
    }
}
