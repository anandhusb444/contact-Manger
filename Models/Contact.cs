namespace contact_Manger.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? DOB { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string? Remark { get; set; } 
        public int? UserId { get; set; }
        public Users user { get; set; }

    }
}
