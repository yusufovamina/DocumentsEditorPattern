using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsEditorPattern
{
    internal class PDFDocumentFactory : IDocumentFactory
    {
            public PDFDocumentFactory() { }

            public override IDocument CreateDocument(string name)
            {
            Console.WriteLine("PDF document was created");
            return new PDF(name);
        }
        public override void OpenDocument()
        {
            Console.WriteLine("Opening PDF document ");
        }
        public override void SaveDocument()
            {
            Console.WriteLine("Saving PDF document ");
        }

        public override void SaveDocumentAs(string newFileName)
            {
            Console.WriteLine($"Saving PDF document as {newFileName}");
        }

        public override void CloseDocument()
        {
            Console.WriteLine("Closing PDF document");
        }
        public override void PrintDocument()
        {
            Console.WriteLine("PDF document is being printed");
        }

        public override IDocument GetDoc() => document;

    }

    }
