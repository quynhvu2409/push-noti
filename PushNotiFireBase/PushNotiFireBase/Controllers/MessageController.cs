using FirebaseAdmin.Messaging;
using Microsoft.AspNetCore.Mvc;

namespace PushNotiFireBase.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        [Route("SendNotificationAsync")]
        [HttpPost]
        public async Task SendNotificationAsync(string DeviceToken, string title, string body)
        {
            var message = new Message()
            {
                Notification = new Notification
                {
                    Title = "456",
                    Body = "123"
                },
                Token = "dD6PCBENRkuUEzWTHZNLo_:APA91bHQ6aUGXHqjmQJzNh5qebDrwUR7mrTG7fSygpWmA_ZI9YNt2OptO_ua9zWuR7kkS8L7zProiEZjmXYVdRdSc6q_ykNfY_RoLaUnRa8oNPBnWuqnx3QsI5UUyqvaH84_iMiuqn5e",
            };
            var messaging = FirebaseMessaging.DefaultInstance;
            var result = await messaging.SendAsync(message);
        }
    }
}
