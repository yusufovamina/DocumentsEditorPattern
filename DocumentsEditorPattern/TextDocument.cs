using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsEditorPattern
{
    internal class TextDocument: ITextDocument
        {
            public string Name { get; }
            public string Format => "TXT";
            public string Content { get; set; }

            public TextDocument(string name)
            {
                Name = name;
                Content = string.Empty;
            }
        }
    }

