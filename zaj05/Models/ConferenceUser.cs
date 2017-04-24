using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace zaj05.Models
{
    public enum CT
    {
        W,
        P
    }
    public class ConferenceUser
    {
        
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public CT ConferenceType { get; set; }

        public byte[] Avatar { get; set; }

    }
}