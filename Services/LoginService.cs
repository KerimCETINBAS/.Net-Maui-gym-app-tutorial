
using GYM_APP.Entities;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace GYM_APP.Services
{


    public class LoginService
    {

        
        public static async Task<string> Login(LoginData loginData)
        {
            using HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("http://127.0.0.1:3000")
            };

            string jsonString = JsonSerializer.Serialize(loginData);
            StringContent stringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("auth/login", stringContent);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();

            }

            return null;


        }
    }
}
