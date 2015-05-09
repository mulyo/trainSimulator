using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSimulator
{
    public class Train : Operable
    {

        private const int capacity = 30;
        private TrainState state;
        private Place currentStation;

        public TrainState State
        {
            get { return state; }
            set { state = value; }
        }

        public Train() : base(){
            this.currentStation = Place.DEVOTO;
            stop();
        }

        public void start()
        {
            this.state = TrainState.MOVE;
        }

        public void stop()
        {
            this.state = TrainState.STOP;
        }

        public Boolean isEmpty() {
            return this.passengers.Count == 0;
        }

        public void getPassengersOnBoard(List<Passenger> passengersFromStation) {
            if (this.state == TrainState.STOP)
            {
                for (int i = 0; i < capacity && i < passengersFromStation.Count; i++) {
                    this.getIn(passengersFromStation[i]);
                }
                start();
            }
            
        }

        public List<Passenger> leavePassengersOnStation() {
            
            List<Passenger> whoLeave = new List<Passenger>();
            if (this.state == TrainState.STOP && this.passengers.Count > 0)
            {
                foreach (Passenger p in this.passengers)
                {
                    if (p.Destiny == this.currentStation)
                    {
                        whoLeave.Add(p);
                        this.getOut(p);
                    }
                }
                start();
            }
            return whoLeave;
        }

        public Place CurrentStation
        {
            get { return currentStation; }
            set { currentStation = value; }
        }
    }
}
