using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsEditorPattern
{
    internal class GraphicDocument : IGraphicDocument
        {
            public string Name { get; set; }
            public string Format { get; }

            public GraphicDocument(string name, string format)
            {
                Name = name;
                Format = format;
            }

            public void Draw()
            {
                Console.WriteLine($"Drawing on {Format} document {Name}");
            }
        public string GetFormat() => Format;
        }

    
}
