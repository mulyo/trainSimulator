using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrainSimulator
{
    public class StationDrawing : Drawable
    {

        public StationDrawing() {
            this.y = 20;
            this.width = 150;
            this.height = 100;
        }

        public override void draw(Graphics graphics, int x)
        {
            this.x = x;
            graphics.DrawImage(Properties.Resources.station1, this.x, this.y, this.width, this.height);
        }
    }
}
