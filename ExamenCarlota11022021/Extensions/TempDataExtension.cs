﻿using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenCarlota11022021.Extensions
{

    public static class TempDataExtension
    {
        public static void SetObject(this ITempDataDictionary tempdata, string key, Object value)
        {
            tempdata[key] = JsonConvert.SerializeObject(value);
        }
        public static T GetObject<T>(this ITempDataDictionary tempdata, String key)
        {
            if (tempdata[key] == null)
            {
                return default(T);
            }
            String data = tempdata[key].ToString();
            return JsonConvert.DeserializeObject<T>(data);
        }
    }
}
