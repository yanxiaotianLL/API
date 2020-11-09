﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PdfiumViewer
{
    public class PdfMatch
    {
        public PointF Location { get; private set; }
        public SizeF Size { get; private set; }
        public string Text { get; private set; }

        public int Page { get; private set; }

        internal PdfMatch(PointF location, SizeF sz,string text, int page)
        {
            Location = location;
            Text = text;
            Page = page;
            Size = sz;
        }
    }
}
