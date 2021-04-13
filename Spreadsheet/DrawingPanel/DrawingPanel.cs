using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingPanel
{
    class DrawingPanel
    {
        public void DisplayRectangle(PaintEventArgs e)
        {
            Pen bluePen = new Pen(Color.Blue, 3);

            Rectangle rect = new Rectangle(0, 0, 200, 200);

            e.Graphics.DrawRectangle(bluePen, rect);

        }
    }
}
