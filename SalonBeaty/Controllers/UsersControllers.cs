using Newtonsoft.Json;
using SalonBeaty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SalonBeaty.Controllers
{
    class UsersControllers
    {
        /// <summary>
        /// Авторизация
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns>
        /// Статус ответа
        /// </returns>
        public static bool Auth(string login, string password)
        {
            using(HttpClient client= new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync($"{Manager.RootUrl}Users/{login}/{password}").Result;
                return response.IsSuccessStatusCode;

            }
        }
        /// <summary>
        /// Регистрация
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns>
        /// Статус ответа
        /// </returns>
        public static bool AddUser(Users user)
        {
            string jsonStr = JsonConvert.SerializeObject(user);
            var buffer = System.Text.Encoding.UTF8.GetBytes(jsonStr);
            var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            using (HttpClient client= new HttpClient())
            {
                HttpResponseMessage response = client.PostAsync($"{Manager.RootUrl}Users", byteContent).Result;
                return response.IsSuccessStatusCode;
            }
        }
    }
}
