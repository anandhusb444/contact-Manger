﻿namespace contact_Manger.Models
{
    public class Contanct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int UserId { get; set; }
        public Users user { get; set; }

    }
}
