using System;

namespace MediatorPattern
{
    public class ChatRoom
    {
        public static void showMessage(User user, string message)
        {
            Console.WriteLine(new DateTime().ToString() + " [" + user.getName() + "] : " + message);
        }
    }
}
