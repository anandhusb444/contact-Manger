﻿namespace contact_Manger.Models
{
    public class Users
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public ICollection<Contanct>? contacts { get; set; }


    }
}
