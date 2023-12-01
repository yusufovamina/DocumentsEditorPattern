using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsEditorPattern
{
    internal abstract class IDocumentFactory
    {
            protected IDocument document;

            public abstract IDocument CreateDocument(string name);
            public abstract void OpenDocument();
            public abstract void SaveDocument();
            public abstract void SaveDocumentAs(string newFileName);
            public abstract void PrintDocument();
            public abstract void CloseDocument();
            public abstract IDocument GetDoc();


    }
}
