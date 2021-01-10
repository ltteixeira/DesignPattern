namespace ChainOfResponsibillity
{
    public class HttpRequest
    {
        public string userName { get; set; }
        public string password { get; set; }

        public HttpRequest(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }        
    }
}
