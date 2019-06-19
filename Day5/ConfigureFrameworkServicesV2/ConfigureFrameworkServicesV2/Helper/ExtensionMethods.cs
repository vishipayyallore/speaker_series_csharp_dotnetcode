using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigureFrameworkServicesV2.Helper
{
    public static class ExtensionMethods
    {

        public static string GetHeaderValue(this HttpRequest headers, string key)
        {
            var value = string.Empty;

            if (headers.Headers.Keys.Contains(key))
            {
                value = headers.Headers[key];
            }

            return value;
        }

    }
}
