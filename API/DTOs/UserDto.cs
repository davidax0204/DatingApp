using System;

namespace API.DTOs
{
    public class UserDto
    {
        public string UserName { get; set; }
        public string Token { get; set; }
        public string KnownAs { get; set; }
        public string Gender { get; set; }
    }
}
