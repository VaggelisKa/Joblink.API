using System;
using System.Collections.Generic;
using API.Entities;

namespace API.DTOs
{
    public class MemberDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PhotoUrl { get; set; }
        public int Age { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Gender { get; set; }
        public string Bio { get; set; }
        public string LookingFor { get; set; }
        public string Skills { get; set; }
        public string City { get; set; }
        public ICollection<PhotoDto> Photos { get; set; }
    }
}