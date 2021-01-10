using System.Collections.Generic;

namespace VisitorPattern
{
    public class HtmlDocument
    {
        private List<IHtmlNode> nodes = new List<IHtmlNode>();

        public void add(IHtmlNode node)
        {
            nodes.Add(node);
        }

        public void execute(IOperation operation)
        {
            foreach (var node in nodes)
                node.execute(operation);
        }
    }
}
