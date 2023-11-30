using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsEditorPattern
{
    internal class PDF : IDocument
    {
        public string Name { get; set; }
        public string Format => "PDF";

        public PDF(string name)
        {
            Name = name;
        }
        public string GetFormat() => Format;

    }
}
