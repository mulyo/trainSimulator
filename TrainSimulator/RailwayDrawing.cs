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
            this.Y = -45;
            this.width = 100;
            this.height = 90;
        }

        public override void draw(Graphics graphics, int x)
        {
            this.X = x;
            graphics.DrawImage(Properties.Resources.rail, this.X, this.Y, this.width, this.height);
        }
    }
}
