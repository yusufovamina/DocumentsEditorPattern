using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsEditorPattern
{
    internal class PowerPointDocumentFactory: IDocumentFactory
    {
       
        public override IDocument CreateDocument(string name)
        {
            Console.WriteLine("PowerPoint document was created");
            return new PowerPoint(name);
        }
        public override void OpenDocument()
        {
            Console.WriteLine("Opening PowerPoint document");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Saving PowerPoint document ");
        }

        public override void SaveDocumentAs(string newFileName)
        {
            Console.WriteLine($"Saving PowerPoint document as {newFileName}");
        }

        public override void PrintDocument()
        {
            Console.WriteLine("PowerPoint document is being printed");
        }
        public override void CloseDocument()
        {
            Console.WriteLine("Closing PowerPoint document");
        }
        public override IDocument GetDoc() => document;
    }
}
