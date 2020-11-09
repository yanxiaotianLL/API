using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;

namespace PdfiumViewer
{
    public class PdfHighlight
    {
        private Color _color;
        public PointF Location { get; private set; }
        public SizeF Size { get; private set; }
        public string Text { get; private set; }

        public int Page { get; private set; }

        public Color Color
        {
            get { return _color; }
            set
            {
                if (_color != value)
                {
                    _color = value;
                    if (Brush != null)
                        Brush.Dispose();
                    Brush = new SolidBrush(_color);
                }
            }
        }

        internal Brush Brush { get; private set; }

        internal PdfHighlight(PointF location, SizeF sz, string text, int page,Color co)
        {
            Location = location;
            Text = text;
            Page = page;
            Size = sz;
            Color = co;
        }
        internal PdfHighlight( PdfMatch match)
        {
            Location = match.Location;
            Text = match.Text;
            Page = match.Page;
            Size = match.Size;
        }
    }
}
