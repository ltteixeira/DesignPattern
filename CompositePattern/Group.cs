using System.Collections.Generic;

namespace CompositePattern
{
    public class Group : IComponent
    {
        private List<IComponent> components = new List<IComponent>();

        public void add(IComponent component)
        {
            components.Add(component);
        }

        public void render()
        {
            foreach (var component in components)
                component.render();
        }


        public void move()
        {
            foreach (var component in components)
                component.move();
        }
    }
}
