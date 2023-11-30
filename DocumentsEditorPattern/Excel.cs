using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsEditorPattern
{
    internal class Excel: IDocument
        {
            public string Name { get; set; }
            public string Format => "XLSX";

            public Excel(string name)
            {
                Name = name;
            }

        public string GetFormat() => Format;
             
    }
    }

