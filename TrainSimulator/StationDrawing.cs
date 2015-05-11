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

        private Place stationName;

        public StationDrawing(Place stationName) {
            this.Y = 20;
            this.width = 150;
            this.height = 100;
            this.stationName = stationName;
        }

        public override void draw(Graphics graphics, int x)
        {
            this.X = x;
            graphics.DrawImage(Properties.Resources.station1, this.X, this.Y, this.width, this.height);
        }

        public Place StationName
        {
            get { return stationName; }
            set { stationName = value; }
        }
    }
}
