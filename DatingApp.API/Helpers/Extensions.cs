using System;
using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("ApplicationError", message);
            response.Headers.Add("Access-Control-Expose-Headers", "ApplicationError");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }

        public static int CalculateAge(this DateTime theDateTime)
        {
            DateTime today = DateTime.Today;
            
            var age = today.Year - theDateTime.Year;
            if (theDateTime.AddYears(age) > today)
            {
                age--;
            }

            return age;
        }
    }
}