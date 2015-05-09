using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSimulator
{
    public class Simulator
    {

        private Train train;
        private List<Station> stations;

        public Simulator() {
            this.train = new Train();
            this.stations = new List<Station>();
            createStations();
        }

        private void createStations()
        {
            this.stations.Add(new Station(Place.DEVOTO, 5, true));
            this.stations.Add(new Station(Place.URQUIZA, 4, false));
            this.stations.Add(new Station(Place.LACROZE, 8, false));
            this.stations.Add(new Station(Place.RETIRO, 10, false));
            this.stations.Add(new Station(Place.CONSTITUCION, 10, true));
        }

        public void moveOn() {
            this.train.start();
        }

        public void setCurrentStationToTrain(Place station){
            this.train.CurrentStation = station;
        }

        public void stopOn() {
            this.train.stop();
            Station station = findCurrentStation(this.train.CurrentStation);
            List<Passenger> passengersFromStation = this.train.leavePassengersOnStation();
            if (passengersFromStation.Count > 0)
            {
                // add passengers to station list
                populateStation(station, passengersFromStation);
            }
            List<Passenger> passengersToTrain = station.ticketToRide();
            this.train.getPassengersOnBoard(passengersToTrain);
        }

        private static void populateStation(Station station, List<Passenger> passengersFromStation)
        {
            foreach (Passenger passenger in passengersFromStation)
            {
                station.getIn(passenger);
            }
        }

        private Station findCurrentStation(Place place)
        {
            foreach (Station station in stations) {
                if (station.StationName == place) {
                    return station;
                }
            }
            return null;
        }

        public Train Train
        {
            get { return train; }
            set { train = value; }
        }

        public List<Station> Stations
        {
            get { return stations; }
            set { stations = value; }
        }
    }
}
