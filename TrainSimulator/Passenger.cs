using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSimulator
{
    public class Passenger
    {
        private PassengerType type;
        private Place destiny;

        public Passenger(PassengerType type, Place destiny)
        {
            this.type = type;
            this.destiny = destiny;
        }

        public PassengerType Type
        {
            get { return type; }
            set { type = value; }
        }

        public Place Destiny
        {
            get { return destiny; }
            set { destiny = value; }
        }
    }
}
