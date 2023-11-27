using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsEditorPattern.Model
{
    internal interface IDocument
    {
         string Name { get;  }
         string Description { get; set; }
         string GetFormat();
    }
}
