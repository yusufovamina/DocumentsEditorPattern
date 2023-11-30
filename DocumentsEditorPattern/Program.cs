using DocumentsEditorPattern;

 IDocumentFactory getEditor(string documentType)
{
    if (documentType == "1")
    {

        return new PDFDocumentFactory();
    }
    else if (documentType == "2")
    {
        return new PowerPointDocumentFactory();
    }
    else if (documentType == "3")
    {
        return new ExcelDocumentFactory();
    }
    else if (documentType == "4")
    { ITextDocument a=new TextDocument("");
        TextDocumentFactory textDocumentFactory = new TextDocumentFactory(a);
       
        return textDocumentFactory;
    }
    else if (documentType == "5")
    {
        IGraphicDocument a = new GraphicDocument("","svg");
        GraphicDocumentEditor svg = new GraphicDocumentEditor(a);
        return  svg;
    }
    else if (documentType == "6")
    {
        IGraphicDocument a = new GraphicDocument("", "png");
        GraphicDocumentEditor png = new GraphicDocumentEditor(a);
        return png;
    }
    else if (documentType == "7")
    {
        IGraphicDocument a = new GraphicDocument("", "jpeg");
        GraphicDocumentEditor jpeg = new GraphicDocumentEditor(a);
        return jpeg;
    }
    return null;
}



Console.WriteLine("Welcome to Document Editor");
Console.WriteLine("Choose the document type that you want to edit: ");
Console.WriteLine("1-PDF\n2-PowerPoint\n3-Excel\n4-Text\n5-Svg\n6-Png\n7-Jpeg");
string documentType = Console.ReadLine();

IDocumentFactory documentEditor = getEditor(documentType);
string name;
Console.WriteLine("Enter document's name: "); name= Console.ReadLine();

if (documentEditor != null)
{
    documentEditor.CreateDocument(name);
    documentEditor.OpenDocument();
    documentEditor.SaveDocument();
    documentEditor.SaveDocumentAs("NewDocument");
    documentEditor.PrintDocument();
    documentEditor.CloseDocument();
    if (documentEditor is TextDocumentFactory)
    {
        Console.WriteLine("Change the content of text file to: ");
        string content = Console.ReadLine();
       ( (TextDocumentFactory)documentEditor).EditContent(content);
    }
    else if(documentEditor is GraphicDocumentEditor)
    {
        ((GraphicDocumentEditor)documentEditor).DrawShape("circle");
        ((GraphicDocumentEditor)documentEditor).SelectTool("Brush");
    }
}
else
{
    Console.WriteLine("Invalid document type");
}