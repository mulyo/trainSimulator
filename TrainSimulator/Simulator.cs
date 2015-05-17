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
            this.stations.Add(new Station(Place.DEVOTO, 2, false));
            this.stations.Add(new Station(Place.URQUIZA, 2, false));
            this.stations.Add(new Station(Place.LACROZE, 2, false));
            this.stations.Add(new Station(Place.RETIRO, 2, false));
            this.stations.Add(new Station(Place.CONSTITUCION, 2, true));
        }

        public void moveOn() {
            this.train.start();
        }

        public void setCurrentStationToTrain(Station station){
            this.train.CurrentStation = station;
        }

        public Station getCurrentStationOfTrain() {

            foreach (Station station in this.stations) {
                if(station.StationName == this.train.CurrentStation.StationName){
                    return station;
                }
            }
            return null;
        }

        public Station findNextStation(Place stationName) {
            foreach (Station station in stations) {
                if (stationName == station.StationName) {
                    return station;
                }
            }
            return null;
        }

        public Station findNextStation()
        {
            Station currentStation = this.getCurrentStationOfTrain();
            for (int i = 0; i < this.stations.Count; i++)
            {
                if (currentStation == this.stations[i])
                {
                    return this.stations[i + 1];
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
           
            List<Passenger> passengersFromTrain = this.train.leavePassengersOnStation();
            if (passengersFromTrain.Count > 0)
            {
                populateStation(getCurrentStationOfTrain(), passengersFromTrain);
            }
            List<Passenger> passengersFromStation = getCurrentStationOfTrain().ticketToRide();
            this.train.getPassengersOnBoard(passengersFromStation);
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
