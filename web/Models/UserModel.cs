using System; 

namespace SafetyManagementSystem.Web.Models
{
    public class UserModel
    {
        public Guid userID {get; set;}
        public string userName {get; set;} = string.Empty;
        public string userEmail {get; set;} = string.Empty;
        public string systemRole {get; set;} = string.Empty;
    }
}