using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsEditorPattern
{
    internal class GraphicDocumentEditor : IGraphicDocumentEditor
        {
            private IGraphicDocument document;

            public  GraphicDocumentEditor(IGraphicDocument document)
            {
                this.document = document;
            }

            public override IDocument CreateDocument(string name)
            {
            document.Name = name;
                Console.WriteLine($"Creating a new {document.Format} document named {name}");
            return document;
            }

            public override void SaveDocument()
            {
                Console.WriteLine($"Saving {document.Format} document {document.Name}");
                // Логика сохранения графического документа
            }

            public override void SaveDocumentAs(string newFileName)
            {
                Console.WriteLine($"Saving {document.Format} document {document.Name} as {newFileName}");
                document.Name = newFileName;
                // Логика сохранения графического документа под новым именем
            }

            public override void PrintDocument()
            {
                Console.WriteLine($"Printing {document.Format} document {document.Name}");
                // Логика печати графического документа
            }

            public override void DrawShape(string shape)
            {
                Console.WriteLine($"Drawing {shape} on {document.Format} document {document.Name}");
                // Логика рисования формы на графическом документе
            }

            public override void SelectTool(string tool)
            {
                Console.WriteLine($"Selecting {tool} tool for {document.Format} document {document.Name}");
                // Логика выбора инструмента на графическом документе
            }

        public override void OpenDocument()
        {
            Console.WriteLine("Opening document");
        }

        public override void CloseDocument()
        {
            Console.WriteLine("Closing document");
        }

        public override IDocument GetDoc() => document;
    }

    
}
