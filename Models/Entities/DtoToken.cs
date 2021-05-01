using Models.Enums;
using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public class DtoToken
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string grant_type { get; set; }
    }
}
