using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsEditorPattern
{
    internal abstract class ITextFactory : IDocumentFactory
        {
        abstract public void EditContent(string newContent);
        }
}

