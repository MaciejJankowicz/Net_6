using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zaj05.Models
{
    public class ConferenceUserDisplayViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CT ConferenceType { get; set; }
        public byte[] Avatar { get; set; }
    }
}