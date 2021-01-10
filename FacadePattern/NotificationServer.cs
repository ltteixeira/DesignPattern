using System;

namespace FacadePattern
{
    public class NotificationServer
    {
        public Connection connect(string ipAddress)
        {
            return new Connection();
        }

        public AuthToken authenticate(string appId, string key)
        {
            return new AuthToken();
        }

        public void send(AuthToken authToken, Menssage menssage, string target)
        {
            Console.WriteLine("Sending a message");
        }
    }
}
