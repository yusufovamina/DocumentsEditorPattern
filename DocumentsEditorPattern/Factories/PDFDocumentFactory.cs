using DocumentsEditorPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsEditorPattern.Factories
{
    internal class PDFDocumentFactory : IDocumentFactory
    {
        private  string _name;
        private readonly string _format;
        public override IDocument GetDoc()
        { 
            PDF pdf = new(_name)
            {
                Format = _format
            };
            return pdf;
        }
        
}
