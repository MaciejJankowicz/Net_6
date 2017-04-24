using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace zaj05.Models
{
    public class ConferenceUserViewModel
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public int? ConferenceType { get; set; }
        public SelectList ConferenceTypes { get; set; }
        public HttpPostedFileBase Avatar { get; set; }

        public ConferenceUserViewModel()
        {
            ConferenceTypes = new SelectList(new List<SelectListItem>
            {
                new SelectListItem {
                Text = "war",
                Value = "0" },
                 new SelectListItem {
                Text = "pre",
                Value = "1" }
            }, "Value", "Text");
        }


        
    }
}