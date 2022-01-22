using System;

namespace homework
{
    internal class DocumentProgram
    {
        public Action DocDelegate { get; }

        public DocumentProgram()
        {
            DocDelegate = new Action(OpenDocument);
            DocDelegate += EditDocument;
            DocDelegate += SaveDocument;
        }

        public void OpenDocument() => Console.WriteLine("Document Opened!");

        public virtual void EditDocument() => Console.WriteLine("Can Edit in Pro and Expert versions!");

        public virtual void SaveDocument() => Console.WriteLine("Can Save in Pro and Expert versions!");
    }
}
