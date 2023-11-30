using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsEditorPattern
{
    internal abstract class IGraphicDocumentEditor: IDocumentFactory
        {
           public abstract void DrawShape(string shape);
           public abstract void SelectTool(string tool);
            
    }
}
