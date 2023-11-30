using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsEditorPattern
{
    internal class PowerPoint : IDocument
    {
        public string Name { get; set; }
        public string Format => "PPTX";

        public PowerPoint(string name)
        {
            Name = name;
        }
        public string GetFormat() => Format;

    }
}
