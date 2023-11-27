using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsEditorPattern.Model
{
    internal class PowerPoint : IDocument
    {
        private readonly string _name;
 
        private readonly string _format;

        public PowerPoint(string name )
        {
            _name = name;
          
        }
        public string Name => _name;
        public string Description { get; set; }

        public string GetFormat() => _format;
        
    }
}
