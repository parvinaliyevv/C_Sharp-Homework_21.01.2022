using System;

namespace homework
{
    internal class ProDocumentProgram : DocumentProgram
    {
        sealed public override void EditDocument() => Console.WriteLine("Document Edited!");

        public override void SaveDocument() => Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet!");
    }
}
