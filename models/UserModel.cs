namespace SafetyManagementSystem.Models
{
    public class UserModel
    {
        public Guid UserID { get; set; }

        public string UserName { get; set; } = string.Empty;

        public string UserEmail { get; set; } = string.Empty;

        public string SystemRole { get; set; } = string.Empty;
    }
}