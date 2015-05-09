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
        protected int x;
        protected int y;
        protected int width;
        protected int height;

        public abstract void draw(Graphics graphics, int x);
    }
}
