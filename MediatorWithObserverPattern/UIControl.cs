using System.Collections.Generic;

namespace MediatorWithObserverPattern
{
    public abstract class UIControl
    {
        //private List<IEventHandler> eventHandlers { get; set; } = new List<IEventHandler>();

        //public void attach(IEventHandler eventHandler) => eventHandlers.Add(eventHandler);

        //protected void notifyEventHandlers()
        //{
        //    foreach (var eventHandler in eventHandlers)
        //        eventHandler.handle();
        //}



        // Without Interface

        public delegate void handle();

        private List<handle> eventHandlers { get; set; } = new List<handle>();

        public void attach(handle eventHandler) => eventHandlers.Add(eventHandler);

        protected void notifyEventHandlers()
        {
            foreach (var eventHandler in eventHandlers)
                eventHandler();
        }
    }
}
