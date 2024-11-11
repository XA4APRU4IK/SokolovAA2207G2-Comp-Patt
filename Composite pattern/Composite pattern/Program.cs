using System;
using System.Collections.Generic;
using Composite_pattern;
public interface IDocumentComponent
{
    void Add(IDocumentComponent component);
    void Remove(IDocumentComponent component);
    void Display(int indent);
}
class Program
{
    static void Main(string[] args)
    {
        Document document = new Document();

        Section section1 = new Section("Introduction");
        section1.Add(new Paragraph("This is the introduction paragraph."));
        section1.Add(new Paragraph("This section provides an overview."));

        Section section2 = new Section("Main Content");
        section2.Add(new Paragraph("This is the first paragraph of the main content."));

        Section subsection = new Section("Subsection");
        subsection.Add(new Paragraph("This is a paragraph in the subsection."));

        section2.Add(subsection);

        document.Add(section1);
        document.Add(section2);

        // Отображение документа
        document.Display(0);
    }
}
