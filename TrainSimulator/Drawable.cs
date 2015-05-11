using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrainSimulator
{
    public abstract class Drawable
    {
        private int x;
        protected int y;
        protected int width;
        protected int height;

        public abstract void draw(Graphics graphics, int x);

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
    }
}
