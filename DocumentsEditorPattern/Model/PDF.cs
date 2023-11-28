using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsEditorPattern.Model
{
    internal class PDF : IDocument
    {
        private  string _name;

        

        public PDF(string name)
        {
            _name = name;

        }
        public string Name => _name;

        public string Format = "PDF";
        public string GetFormat() => Format;

    }
}
