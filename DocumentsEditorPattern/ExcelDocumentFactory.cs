using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsEditorPattern
{
    internal class ExcelDocumentFactory : IDocumentFactory
{
        public override IDocument CreateDocument(string name)
        {
            Console.WriteLine("Excel document was created");
            return new Excel(name);
        }
        public override void OpenDocument()
        {
            Console.WriteLine("Opening Excel document");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Saving Excel document ");
        }

        public override void SaveDocumentAs(string newFileName)
        {
            Console.WriteLine($"document was saved as {newFileName}");
        }

        public override void PrintDocument()
        {
            Console.WriteLine("Excel document is being printed"); 
        }
        public override void CloseDocument()
        {
            Console.WriteLine("Closing Excel document");
        }
        public override IDocument GetDoc() => document;

    }
}

