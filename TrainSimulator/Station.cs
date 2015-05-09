using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrainSimulator
{
    public class Station : Operable
    {

        private Place stationName;
        private Boolean terminal;
        private int quantityPassengers;

        public Station(Place name, int quantityPassengers, Boolean terminal) : base()
        {
            this.stationName = name;
            this.quantityPassengers = quantityPassengers;
            this.terminal = terminal;
            createPassengers();
        }

        private void createPassengers() {

            Random destinyRand = new Random();
            Random passTypeRand = new Random();
            Place destiny;
            PassengerType type;
            int destinyId;
            int passTypeId;

            for (int i = 0; i < quantityPassengers; i++)
            {
                passTypeId = passTypeRand.Next(1, 6);
               
                do{
                    destinyId = destinyRand.Next(1, 7);   
                    destiny = generateDestiny(destinyId);
                }while(destiny == stationName);
                type = generatePassengerType(passTypeId);
                Passenger p = new Passenger(type, destiny);
                this.getIn(p);
            }
        }
               
        public List<Passenger> ticketToRide() {
            return this.getAllOut();
        }

        private Place generateDestiny(int id) {
            switch (id)
            {
                case 1: return Place.DEVOTO;
                case 2: return Place.URQUIZA;
                case 3: return Place.LACROZE; 
                case 4: return Place.RETIRO; 
                default: return Place.CONSTITUCION;
            }
        }

        private PassengerType generatePassengerType(int id)
        {
            switch (id)
            {
                case 1: return new Employee();
                case 2: return new Officer();
                case 3: return new Retired();
                case 4: return new Student();
                case 5: return new Disabled();
                default: return new Student();
            }
        }

        public Place StationName
        {
            get { return stationName; }
            set { stationName = value; }
        }

        public Boolean Terminal
        {
            get { return terminal; }
            set { terminal = value; }
        }
       
    }
}
