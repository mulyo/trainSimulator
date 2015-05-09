using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSimulator
{
    public abstract class PassengerType
    {
        private PassengerTypeEnum type;

        public PassengerType(PassengerTypeEnum type) {
            this.type = type;
        }

        public PassengerTypeEnum Type
        {
            get { return type; }
            set { type = value; }
        }


    }
}
