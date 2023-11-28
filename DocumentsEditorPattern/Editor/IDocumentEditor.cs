using DocumentsEditorPattern.Factories;
using DocumentsEditorPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsEditorPattern.Editor
{
    internal interface IDocumentEditor
    {
       
       
        //void Create(IDocument document,string fileName);
        void Open();
        void Save();
        void SaveAs(string newFileName);
        void Print();
        void Close();
       
}
}
