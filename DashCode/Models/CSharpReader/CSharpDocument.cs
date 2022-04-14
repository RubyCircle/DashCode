﻿using DashCode.Models.DocumentReaders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DashCode.Models.CSharpReader
{
    public class CSharpDocument : EditorDocument
    {
        public CSharpDocument(string rawDocument, IDocumentReader reader) : base(rawDocument, reader)
        {
        }
    }
}