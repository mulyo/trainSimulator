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
        private Boolean loadingFinished;
        private Boolean unloadingFinished;

        public Simulator() {
            this.train = new Train();
            this.stations = new List<Station>();
            this.loadingFinished = false;
            this.unloadingFinished = false;
            createStations();
            this.train.CurrentStation = this.stations[0];
        }

        private void createStations()
        {
            this.stations.Add(new Station(Place.DEVOTO, 5, false));
            this.stations.Add(new Station(Place.URQUIZA, 4, false));
            this.stations.Add(new Station(Place.LACROZE, 8, false));
            this.stations.Add(new Station(Place.RETIRO, 10, false));
            this.stations.Add(new Station(Place.CONSTITUCION, 10, true));
        }

        public void moveOn() {
            this.train.start();
           // this.loadingFinished = false;
           // this.unloadingFinished = false;
        }

        public void setCurrentStationToTrain(Station station){
            this.train.CurrentStation = station;
        }

        public Station getCurrentStationOfTrain() {
            return this.train.CurrentStation;
        }

        public Station findNextStation(Place stationName) {
            foreach (Station station in stations) {
                if (stationName == station.StationName) {
                    return station;
                }
            }
            return null;
        }

        public void stopOn() {
            this.train.stop();
            this.loadingFinished = false;
            this.unloadingFinished = false;
        }

        public void movePassengers()
        {
           
            List<Passenger> passengersFromStation = this.train.leavePassengersOnStation();
            if (passengersFromStation.Count > 0)
            {
                // add passengers to station
                populateStation(this.train.CurrentStation, passengersFromStation);
            }
            List<Passenger> passengersToTrain = this.train.CurrentStation.ticketToRide();
            this.train.getPassengersOnBoard(passengersToTrain);
            this.loadingFinished = true;
            this.unloadingFinished = true;
        }

        private static void populateStation(Station station, List<Passenger> passengersFromStation)
        {
            foreach (Passenger passenger in passengersFromStation)
            {
                station.getIn(passenger);
            }
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

        public Boolean LoadingFinished
        {
            get { return loadingFinished; }
            set { loadingFinished = value; }
        }

        public Boolean UnloadingFinished
        {
            get { return unloadingFinished; }
            set { unloadingFinished = value; }
        }
    }
}
