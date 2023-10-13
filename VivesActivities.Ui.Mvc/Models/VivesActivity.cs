namespace VivesActivities.Ui.Mvc.Models
{
    public class VivesActivity
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public required string Location { get; set; }
    }
}
