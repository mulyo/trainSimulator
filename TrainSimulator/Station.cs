using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;

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
            if (!this.terminal)
            {
                createPassengers();
            }
        }

        private void createPassengers() {

            Random destinyRand = new Random();
            Random passTypeRand = new Random();
            Place destiny;
            PassengerType type;
            String firstName, lastName;
            int destinyId, ordinal;
            int passTypeId;
           
            for (int i = 0; i < quantityPassengers; i++)
            {
                passTypeId = passTypeRand.Next(1, 6);
               
                do{
                    Thread.Sleep(200);
                    destinyId = destinyRand.Next(1, 7);   
                    destiny = generateDestiny(destinyId);
                    ordinal = (int) destiny;
                } while (destiny == stationName || ordinal < (int) stationName);
                Thread.Sleep(200);
                type = generatePassengerType(passTypeId);
                firstName = findFirstNameFor(type.Gender);
                Thread.Sleep(200);
                lastName = findLastName();
                Passenger p = new Passenger(firstName, lastName, type, this.stationName, destiny);
                this.getIn(p);
            }
        }

        private String findLastName() {
            Random rand = new Random();
            int index = rand.Next(0, 51);
            return readLine(index, Properties.Resources.Lastnames);
        }

        private String findFirstNameFor(GenderEnum gender) {
            Random rand = new Random();
            int index = 0;
            
            if (gender == GenderEnum.MALE) {
                index = rand.Next(0, 59);
                return readLine(index, Properties.Resources.MaleNames);
            }
            index = rand.Next(0,66);
            return readLine(index, Properties.Resources.FemaleNames);
        }

        private String readLine(int index, String path) {
            String[] array = Regex.Split(path, "\r\n");
            return array[index];
        }
               
        public List<Passenger> ticketToRide() {
            List<Passenger> passengersToTrain = this.getAllOut(stationName);
            foreach (Passenger passenger in passengersToTrain) {
                this.Passengers.Remove(passenger);
            }
            return passengersToTrain;
        }

        private Place generateDestiny(int id) {
            Thread.Sleep(200);
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

        public override string ToString()
        {
            return stationName.ToString();
        }
        /*
        public override bool Equals(object obj)
        {
            Station station = (Station) obj;
            return station.stationName == this.stationName;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            return (hash * 7) + stationName.GetHashCode();
        }
        */
    }
}
