namespace ChainOfResponsibillity
{
    public abstract class Handler
    {
        private Handler next { get; set; }  
        
        public Handler(Handler next)
        {
            this.next = next;
        }

        public void handle(HttpRequest request)
        {
            if (doHandle(request)) return;

            if (next != null)
                next.handle(request);
        }

        public abstract bool doHandle(HttpRequest request);
    }
}
