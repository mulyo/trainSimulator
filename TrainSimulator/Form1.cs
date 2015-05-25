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
        private List<Stretch> stretches;
        private int passengersCounter = 0;
        private int maxStationPassengers = 0;
        private Control[] pbFromStationToTrain;
        private FormStatistics statsForm;
        
        
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.mostrarEstadisticasToolStripMenuItem.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.avanzarTrenBtn.Enabled = false;
            this.simulator = new Simulator();
            this.stations = new List<Drawable>();
            this.stretches = new List<Stretch>();
            this.prbEstado.Minimum = 0;
            this.prbEstado.Minimum = 30;


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

                
                if (stationPassengers.Count > 0)
                {
                    StationDrawing drawStation = findStationDrawing(currentStation);
                    this.trainPictureBox.SendToBack();
                    this.stationsPictureBox.SendToBack();

                    passengersCounter = 0;
                    foreach (Passenger passenger in stationPassengers)
                    {

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
                        pb.Tag = passenger;
                        setEventHandler(pb);
                        this.Controls.Add(pb);

                        this.prbEstado.Value += 1;

                    }

                    // hacer animacion grafica de pasajeros subiendo al tren
                    Control[] ctr = this.Controls.Find("passengerToTrain", true);
                    this.pbFromStationToTrain = ctr;
                    fromStationToTrainTimer.Start();
                }
                else
                {
                  this.avanzarTrenBtn.Enabled = true;
                }
                
                if (trainPassengers.Count > 0)
                {
                    // hacer animacion grafica de pasajeros bajando del tren
                    //this.prbEstado.Value -=1;
                }
               
                this.simulator.UnloadingFinished = true;
            }
        }

        private static void setEventHandler(PictureBox pb)
        {
            pb.Click += (s, e) => {
                Carnet carnet = new Carnet((Passenger)pb.Tag);
                carnet.Show();
            };
        }

        private void avanzarTrenBtn_Click(object sender, EventArgs e)
        {
            if (this.simulator.UnloadingFinished && this.simulator.LoadingFinished)
            {
                this.avanzarTrenBtn.Enabled = false;
                this.simulator.movePassengers();
                this.simulator.moveOn();
                this.trainTimer.Start();
                Station currentStation = this.simulator.getCurrentStationOfTrain();
                if (currentStation.Terminal)
                {
                    this.mostrarEstadisticasToolStripMenuItem.Enabled = true;
                    statsForm = new FormStatistics(this);
                }
                else {
                    this.stretches.Add(new Stretch(PlaceToString.showText(currentStation.StationName) + " - " + PlaceToString.showText(this.simulator.findNextStation().StationName), this.simulator.Train.Passengers.Count));
                }
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
           this.trainPictureBox.Location = new Point(location.X + 20, location.Y);
           Station station = this.simulator.getCurrentStationOfTrain();
           StationDrawing nextStationDrawing = null;
           if (!station.Terminal)
           {
               prbTrain.Value += this.simulator.Train.Speed;
               Station nextStation = this.simulator.findNextStation();
               nextStationDrawing = findNextStationDrawing(nextStation);
               if (this.trainPictureBox.Location.X >= nextStationDrawing.X)
               {
                   trainTimer.Stop();
                   this.simulator.Train.stop();
                   this.simulator.setCurrentStationToTrain(this.simulator.findNextStation(nextStationDrawing.StationName));
                   this.operarGenteBtn.Enabled = true;
               }
           }
        }

        private StationDrawing findNextStationDrawing(Station station)
        {
            for (int i = 0; i < this.stations.Count; i++)
            {
                if (((StationDrawing)this.stations[i]).StationName == station.StationName)
                {
                    return (StationDrawing)this.stations[i];
                }
            }
            return null;
        }

        private void mostrarEstadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statsForm.ShowDialog(this);
        }

        public Simulator Simulator
        {
            get { return simulator; }
        }

        public List<Stretch> Stretches
        {
            get { return stretches; }
            set { stretches = value; }
        }
    }
}
