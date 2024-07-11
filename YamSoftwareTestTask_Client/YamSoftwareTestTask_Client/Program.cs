using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YamSoftwareTestTask_Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Enter your username:");
            var username = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            var password = Console.ReadLine();

            var loginSuccess = await AuthenticateUser(username, password);
            if (loginSuccess)
            {
                Console.WriteLine("Login successful!");
                await TriggerNotification();
            }
            else
            {
                Console.WriteLine("Login failed. Please check your credentials.");
            }
        }

        static async Task<bool> AuthenticateUser(string username, string password)
        {
            using (var client = new HttpClient())
            {
                var request = new { Username = username, Password = password };
                var json = JsonConvert.SerializeObject(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://localhost:7099/api/auth/login", content);
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var user = JsonConvert.DeserializeObject<User>(responseContent);
                    Console.WriteLine($"Welcome {user.Name}!");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        static async Task TriggerNotification()
        {
            // Mock notification
            await Task.Delay(500); // Simulate some async work
            Console.WriteLine("Notification: You have successfully logged in.");
        }
    }

    public class User
    {
        public string Name { get; set; }
    }
}
