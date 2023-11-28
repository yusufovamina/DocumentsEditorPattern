using DocumentsEditorPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsEditorPattern.Factories
{
    internal abstract class IDocumentFactory
    {       
        public abstract IDocument GetDoc();
      
       
    }
}
