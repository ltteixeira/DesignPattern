namespace FacadePattern
{
    public class NotificationService
    {
        public void send(string message, string target)
        {
            var server = new NotificationServer();
            var connection = server.connect("Ip");
            var authToken = server.authenticate("appId", "key");
            server.send(authToken, new Menssage(message), target);
            connection.disconnect();
        }
    }
}
