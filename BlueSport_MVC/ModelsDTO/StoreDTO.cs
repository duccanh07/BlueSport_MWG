﻿using BlueSport_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueSport_MVC.ModelsDTO
{
    public class StoreDTO
    {
        public string name { get; set; }
        public string address { get; set; }
        public string webAddress { get; set; }
    }
    public static class StoreDTOExt
    {
        public static StoreModel ToGetStore(this StoreDTO storeDto)
        {
            return new StoreModel()
            {
                NameStore = storeDto.name,
                Address = storeDto.GetAddress(),
            };
        }

        public static string GetAddress(this StoreDTO storeDto)
        {
            return string.IsNullOrEmpty(storeDto.webAddress) ? storeDto.address : storeDto.webAddress;
        }
    }
}
