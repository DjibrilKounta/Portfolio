using Microsoft.AspNetCore.Mvc;
using Portfolio.Models.Models;
using System.Text.Json;

namespace Portfolio.Controllers
{
    public class ProjectController : Controller
    {
        public async Task<IActionResult> IndexAsync()
        {
            // Get the path to the JSON file
            var jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Models", "Datas", "projects.json");
            // Read the JSON file
            // Deserialize the JSON data into a list of Project objects
            var json = await System.IO.File.ReadAllTextAsync(jsonFilePath);

            // Pass the list of projects to the view

            var projects = JsonSerializer.Deserialize<List<Project>>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
            ) ?? new List<Project>();
            return View(projects);
        }
    }
}
