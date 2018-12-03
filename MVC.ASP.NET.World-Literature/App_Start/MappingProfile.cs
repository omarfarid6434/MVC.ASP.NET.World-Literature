using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MVC.ASP.NET.World_Literature.Models;
using MVC.ASP.NET.World_Literature.Dtos;


namespace MVC.ASP.NET.World_Literature.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Storie, StorieDto>();
            Mapper.CreateMap<StorieDto, Storie>();
        }
    }
}