using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsEditorPattern
{
    internal abstract class ITextDocument: IDocument
        {
        public string Name { get; set; }

        public string Format { get; set; }

      public   string Content { get; set; }

        public string GetFormat() => Format;
        
    }

    }

