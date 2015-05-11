using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrainSimulator
{
    public abstract class PassengerType
    {
        private PassengerTypeEnum type;
        private Bitmap image;
        protected int speed;

        public PassengerType(PassengerTypeEnum type, Bitmap image) {
            this.type = type;
            this.image = image;
        }

        public PassengerTypeEnum Type
        {
            get { return type; }
            set { type = value; }
        }

        public Bitmap Image
        {
            get { return image; }
            set { image = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }
}
