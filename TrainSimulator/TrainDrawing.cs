using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrainSimulator
{
    public class TrainDrawing : Drawable
    {

        public TrainDrawing()
        {
            this.y = 150;
            this.width = 100;
            this.height = 50;
        }

        public override void draw(Graphics graphics, int x)
        {
            this.x = x;
            graphics.DrawImage(Properties.Resources.train, this.x, this.y, this.width, this.height);
        }
    }
}
