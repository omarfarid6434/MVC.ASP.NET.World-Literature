using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MVC.ASP.NET.World_Literature.Models;

namespace MVC.ASP.NET.World_Literature.Models
{
    public class Storie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        
        public string Description { get; set; }

        [Display(Name = "Pulish Date")]
        public DateTime PublishDate { get; set; }
    }
}