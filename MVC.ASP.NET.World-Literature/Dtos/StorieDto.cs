using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.ASP.NET.World_Literature.Models;

namespace MVC.ASP.NET.World_Literature.Dtos
{
    public class StorieDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }    
        public DateTime PublishDate { get; set; }
    }
}