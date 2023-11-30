using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsEditorPattern
{
    internal interface IDocument
    {
        
            string Name { get; set; }
            string Format { get; }
        

        string GetFormat();
    }
}
