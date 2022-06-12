﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Övning_5.FunctionsBase
{
    //Denna används ej, sattes upp som test för funktionen
    public static class EntityExtensions
    {
        public static T? Copy<T>(this T itemToCopy) where T : IEntity
        {
            var json = JsonSerializer.Serialize<T>(itemToCopy);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
