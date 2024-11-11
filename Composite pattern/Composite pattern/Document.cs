using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Composite_pattern
{
    public class Document : IDocumentComponent
    {
        private List<IDocumentComponent> _sections = new List<IDocumentComponent>();
        public void Add(IDocumentComponent component)
        {
            _sections.Add(component);
        }
        public void Remove(IDocumentComponent component)
        {
            _sections.Remove(component);
        }
        public void Display(int indent)
        {
            Console.WriteLine("Document:");
            foreach (var section in _sections)
            {
                section.Display(indent + 2);
            }
        }
    }
}
