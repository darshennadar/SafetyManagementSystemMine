namespace SafetyManagementSystem.Models
{
    public class Mine
    {
        public int MineID { get; set; }

        public string MineName { get; set; } = string.Empty;

        public string MineLocation { get; set; } = string.Empty;

        public string MineType { get; set; } = string.Empty;

        public string MineSite { get; set; } = string.Empty;

        public string MineStatus { get; set; } = string.Empty;
    }
}