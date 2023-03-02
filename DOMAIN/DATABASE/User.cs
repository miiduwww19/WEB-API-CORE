using System;
using System.Collections.Generic;

namespace DOMAIN.DATABASE
{
    public partial class User
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Gender { get; set; }
    }
}
