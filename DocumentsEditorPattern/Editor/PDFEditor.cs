using DocumentsEditorPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsEditorPattern.Editor
{
    internal class PDFEditor : IDocumentEditor
    {

        private PDF pdf;
    
         public PDF Create(string fileName)
        {
             pdf = new PDF(fileName);
            Console.WriteLine($"Creating PDF file with <<{pdf.Name}>> name.");
            return pdf;
            // Логика создания PDF документа
        }

        public void Open()
        {
            Console.WriteLine($"Opening <<{pdf.Name}>> file.");
        }

        public void Save()
        {
            Console.WriteLine($"Saving PDF file <<{pdf.Name}>>");
          
        }

        public void SaveAs(string newFileName)
        {
           // pdf.Name = newFileName;
            Console.WriteLine($"Сохранение PDF документа под именем {newFileName}");
            
        }

        public void Print()
        {
            Console.WriteLine($"Printing <<{pdf.Name}>> PDF file");
        }

        public void Close()
        {
            Console.WriteLine("Closing PDF ");
        }
    }
}
