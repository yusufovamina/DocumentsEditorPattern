using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static DocumentsEditorPattern.TextDocumentFactory;

namespace DocumentsEditorPattern
{
    internal class TextDocumentFactory : ITextFactory
        {
            private ITextDocument document;

            public TextDocumentFactory(ITextDocument document)
            {
                this.document = document;
            }

            public  override IDocument CreateDocument(string name)
            {
                Console.WriteLine($"Creating a new {document.Format} document named {name}");
            document.Name = name;
            return document;
        }

            public override void SaveDocument()
            {
                Console.WriteLine($"Saving {document.Format} document {document.Name}");
            }

            public override void SaveDocumentAs(string newFileName)
            {
                Console.WriteLine($"Saving {document.Format} document {document.Name} as {newFileName}");
                document.Name = newFileName;
            }

            public override void PrintDocument()
            {
                Console.WriteLine($"Printing {document.Format} document {document.Name}");
            }

            public override void EditContent(string newContent)
            {
                document.Content = newContent;
                Console.WriteLine($"Content of {document.Format} document {document.Name} has been updated");
            }

       

        public override void OpenDocument()
        {
            Console.WriteLine("Opening text document");
        }

        public override void CloseDocument()
        {
            Console.WriteLine("Closing text document") ;
        }

        public override IDocument GetDoc() => document;
    }

    
}
