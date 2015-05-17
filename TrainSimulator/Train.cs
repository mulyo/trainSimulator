using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrainSimulator
{
    public class Train : Operable
    {

        private const int capacity = 30;
        private TrainState state;
        private Station currentStation;

        public TrainState State
        {
            get { return state; }
            set { state = value; }
        }

        public Train() : base(){
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
            return this.Passengers.Count == 0;
        }

        public Boolean isStopped() {
            return this.state == TrainState.STOP;
        }

        public void getPassengersOnBoard(List<Passenger> passengersFromStation) {
           // if (this.state == TrainState.STOP)
           // {
                for (int i = 0; i < capacity && i < passengersFromStation.Count; i++) {
                    this.getIn(passengersFromStation[i]);
                }
                start();
           // }
            
        }

        public List<Passenger> leavePassengersOnStation() {
            
            List<Passenger> whoLeave = new List<Passenger>();
            if (this.state == TrainState.STOP && this.Passengers.Count > 0)
            {
                foreach (Passenger p in this.Passengers)
                {
                    if (p.Destiny == this.currentStation.StationName)
                    {
                        whoLeave.Add(p);
                    }
                }

                foreach (Passenger p in whoLeave) {
                    this.getOut(p);
                }
                start(); //podria estar generando problemas este start
            }
            return whoLeave;
        }

        public Station CurrentStation
        {
            get { return currentStation; }
            set { currentStation = value; }
        }

        
    }
}
