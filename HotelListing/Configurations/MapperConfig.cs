﻿using AutoMapper;
using HotelListing.Data;
using HotelListing.Models.Country;
using HotelListing.Models.Hotels;
using HotelListing.Models.Users;

namespace HotelListing.Configurations
{
    public class MapperConfig :Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();

            CreateMap<Hotel, HotelDto>().ReverseMap();
            CreateMap<Hotel, CreateHotelDto>().ReverseMap();

            CreateMap<ApiUser, ApiUserDto>().ReverseMap();
        }
    }
}
