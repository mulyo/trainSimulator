using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrainSimulator
{
    public class RailwayDrawing : Drawable
    {

        public RailwayDrawing()
        {
            this.y = -45;
            this.width = 100;
            this.height = 90;
        }

        public override void draw(Graphics graphics, int x)
        {
            this.x = x;
            graphics.DrawImage(Properties.Resources.rail, this.x, this.y, this.width, this.height);
        }
    }
}
