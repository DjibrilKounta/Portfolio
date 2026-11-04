using System.Text.Json;

namespace Portfolio.Models.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Category { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public List<string> Technologies { get; set; } = [];

        public List<string> Features { get; set; } = [];

        public string GithubUrl { get; set; } = string.Empty;

        public string DemoUrl { get; set; } = string.Empty;
    }


}
