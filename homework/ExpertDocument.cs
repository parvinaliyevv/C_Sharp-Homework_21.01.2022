﻿using System;

namespace homework
{
    internal class ExpertDocument: ProDocumentProgram
    {
        public override void SaveDocument() => Console.WriteLine("Document Saved in pdf format!");
    }
}
