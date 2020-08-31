﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZamjenaDomova.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.User, Model.User>();
            CreateMap<Model.Requests.UserUpsertRequest, Database.User>();
            CreateMap<Database.AmenitiesCategory, Model.AmenitiesCategory>();
            CreateMap<Database.Amenity, Model.Amenity>();
            CreateMap<Model.Requests.AmenityUpsertRequest, Database.Amenity>();
        }
    }
}