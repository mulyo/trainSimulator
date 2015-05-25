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
        protected GenderEnum gender;
        protected int minYearThreshold;
        protected int maxYearThreshold;

        public PassengerType(PassengerTypeEnum type, Bitmap image) {
            this.type = type;
            this.image = image;
        }

        public DateTime randomBirth()
        {
            DateTime end = new DateTime(minYearThreshold, 1, 1);
            DateTime start = new DateTime(maxYearThreshold, 1, 1);
            Random gen = new Random();

            int range = (end - start).Days;
            return start.AddDays(gen.Next(range));
        }

        public abstract String showTypeText();

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

        public GenderEnum Gender
        {
            get { return gender; }
            set { gender = value; }
        }
    }
}
