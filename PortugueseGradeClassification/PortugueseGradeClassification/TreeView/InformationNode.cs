using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortugueseGradeClassification.TreeView
{
    public class InformationNode
    {
        private string data;

        public InformationNode(string data)
        {
            this.data = data;
        }

        public SizeF GetSize(Graphics graph, Font font)
        {
            return graph.MeasureString(this.data, font) + new SizeF(10, 10);
        }

        public void Draw(float x, float y, Graphics graph, Pen pen, Brush background, Brush textBrush, Font font)
        {
            SizeF size = this.GetSize(graph, font);

            Rectangle rect = new Rectangle((int)(x - size.Width / 2)+1, (int)(y - size.Height / 2)+1, (int)size.Width, (int)size.Height);

            graph.FillRectangle(background, rect);
            graph.DrawRectangle(pen, rect);

            using (StringFormat string_format = new StringFormat())
            {
                string_format.Alignment = StringAlignment.Center;
                string_format.LineAlignment = StringAlignment.Center;
                graph.DrawString(this.data, font, textBrush, x, y, string_format);
            }
        }
    }
}
