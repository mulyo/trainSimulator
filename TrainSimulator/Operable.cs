using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSimulator
{
    public abstract class Operable
    {
        private List<Passenger> passengers;

        public List<Passenger> Passengers
        {
            get { return passengers; }
            set { passengers = value; }
        }

        public Operable(List<Passenger> passengers) {

            this.passengers = passengers;
        }

        public Operable()
        {
            this.passengers = new List<Passenger>();
        }

        public void getIn(Passenger passenger)
        {
            this.passengers.Add(passenger);
        }

        public List<Passenger> getAllOut(Place destiny)
        {
            // se deberia evitar que los pasajeros que acaban de descender del tren a la estacion actual no sean tenidos en cuenta aca. El bug hace que los que descendieron del tren inmediatamente vuelvan a subir al tren!!!
            List<Passenger> aux = new List<Passenger>();
            foreach(Passenger passenger in this.passengers){
                if(passenger.Destiny != destiny){
                    aux.Add(passenger);
                }
            }


            //aux.AddRange(this.passengers);
            //this.passengers.Clear();
            return aux;
        }

        public void getOut(Passenger passenger) {
            if (passenger != null) {
                this.passengers.Remove(passenger);
            }
        }

        // could be deprecated
        public List<Passenger> getOut(int count)
        {

            List<Passenger> aux = new List<Passenger>();

            if (count > 0 && this.passengers.Count >= count)
            {
                for (int i = 0; i < count; i++)
                {
                    aux.Add(passengers[i]);
                    this.passengers.Remove(passengers[i]);
                }
            }

            return aux;
        }

    }
}
