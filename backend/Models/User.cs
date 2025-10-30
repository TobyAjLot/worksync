namespace backend.Models
{
    public class User
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}