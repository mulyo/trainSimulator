using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainSimulator
{
    public partial class Form1 : Form
    {

        private Simulator simulator;
        private Graphics graphics;
        private Drawable drawable;
        private List<Drawable> stations;
        private int stationOrder = 0;
        private int passengersCounter = 0;
        private int maxStationPassengers = 0;
        private Control[] pbFromStationToTrain;
        
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.simulator = new Simulator();
            this.stations = new List<Drawable>();
        }
        
        private void trainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            this.drawable = new TrainDrawing();
            this.drawable.draw(graphics, 5);
        }

        private void railwayPictureBox_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            this.drawable = new RailwayDrawing();
            for (int i = 0, x = 0; i < 10; i++, x += 100)
            {
                this.drawable.draw(graphics, x);
            }
        }

        private void stationsPictureBox_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            
            for (int i = 0, x = 0; i < this.simulator.Stations.Count; i++, x += 200)
            {
                this.drawable = new StationDrawing(this.simulator.Stations[i].StationName);
                this.drawable.draw(graphics, x);
                this.stations.Add(this.drawable);
            }
        }

        private void operarGenteBtn_Click(object sender, EventArgs e)
        {
            if (this.simulator.Train.isStopped())
            {
                this.operarGenteBtn.Enabled = false;
                Station currentStation = this.simulator.getCurrentStationOfTrain();
                List<Passenger> stationPassengers = currentStation.Passengers;
                this.maxStationPassengers = stationPassengers.Count;
                List<Passenger> trainPassengers = this.simulator.Train.Passengers;

                if (trainPassengers.Count > 0)
                {
                    // hacer animacion grafica de pasajeros bajando del tren
                }
               
                this.simulator.UnloadingFinished = true;

                if (stationPassengers.Count > 0)
                {
                    StationDrawing drawStation = findStationDrawing(currentStation);
                    this.trainPictureBox.SendToBack();
                    this.stationsPictureBox.SendToBack();

                    passengersCounter = 0;
                    foreach (Passenger passenger in stationPassengers) {
                        
                        PassengerType passengerType = passenger.Type;
                        Image image = passengerType.Image;
                        PictureBox pb = new PictureBox();
                        pb.Image = image;
                        pb.Location = new Point(drawStation.X + 73, drawStation.Y + 220);
                        pb.BringToFront();
                        pb.Name = "passengerToTrain";
                        pb.Height = image.Height;
                        pb.Width = image.Width;
                        pb.Visible = false;
                        this.Controls.Add(pb);
                    }
                    
                    // hacer animacion grafica de pasajeros subiendo al tren
                    fromStationToTrainTimer.Start();
                    Control[] ctr = this.Controls.Find("passengerToTrain", true);
                    this.pbFromStationToTrain = ctr;
                }
            }
        }

        private void avanzarTrenBtn_Click(object sender, EventArgs e)
        {
            if (this.simulator.UnloadingFinished && this.simulator.LoadingFinished)
            {
                this.avanzarTrenBtn.Enabled = false;
                this.simulator.movePassengers();
                this.simulator.moveOn();
                this.trainTimer.Start();
            }

        }

        private StationDrawing findStationDrawing(Station station) {
            
            foreach(StationDrawing sd in this.stations){
                if (sd.StationName == station.StationName) {
                    return sd;
                }
            }
            return null;
        }

        private void fromStationToTrain_Tick(object sender, EventArgs e)
        {

            PictureBox pb = (PictureBox)pbFromStationToTrain[passengersCounter];
            Station station = this.simulator.getCurrentStationOfTrain();
            Passenger passenger = station.Passengers[passengersCounter];
                
            pb.Visible = true;
            pb.BringToFront();
            pb.Location = new Point(pb.Location.X, pb.Location.Y + passenger.Type.Speed);
            Boolean hasReached = checkIfPassengerReachedTrain(pb);

            if (hasReached)
            {
                passengersCounter++;
                pb.Visible = false;
                if (maxStationPassengers == passengersCounter)
                {
                    this.fromStationToTrainTimer.Stop();
                    this.simulator.LoadingFinished = true;
                    this.avanzarTrenBtn.Enabled = true;
                    foreach(Control ctr in pbFromStationToTrain){
                        ctr.Dispose();
                    }
                }
            }
            
        }

        private bool checkIfPassengerReachedTrain(PictureBox pb)
        {
            return pb.Location.Y >= trainPictureBox.Location.Y + 100;
        }

        private void train_Tick(object sender, EventArgs e)
        {
           Point location = this.trainPictureBox.Location;
           this.trainPictureBox.Location = new Point(location.X + 2, location.Y);
           Station station = this.simulator.getCurrentStationOfTrain();
           StationDrawing next = null;
           if (!station.Terminal)
           {
               next = (StationDrawing)stations[stationOrder + 1];
               if (this.trainPictureBox.Location.X >= next.X)
               {
                   trainTimer.Stop();
                   this.simulator.Train.stop();
                   this.simulator.setCurrentStationToTrain(this.simulator.findNextStation(next.StationName));
                   this.stationOrder++;                   
                   this.operarGenteBtn.Enabled = true;
               }
           }
           else {
               stationOrder = 0;
           }
        }
        
    }
}
