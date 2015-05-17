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
    public partial class FormStatistics : Form
    {

        private List<Station> stations;

        public FormStatistics(Form1 parent)
        {
            InitializeComponent();
            this.stations = parent.Simulator.Stations;
            cbStations.Items.AddRange(stations.ToArray());
            tbStatistics.TabPages[0].Text = "Principal";
            tbStatistics.TabPages[1].Text = "Datos";
            setStationMostConcurred();
            setStationLessConcurred();

        }

        private void cbStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgPassengers.Visible = false;
            int selectedIndex = cbStations.SelectedIndex;
            ComboBox.ObjectCollection items = cbStations.Items;
            Station station = (Station) items[selectedIndex];
            lbPassengers.Items.Clear();
            lbPassengers.Tag = station.Passengers;
            if (station.Passengers.Count > 0)
            {
                foreach (Passenger passenger in station.Passengers) {
                    lbPassengers.Items.Add(passenger.ToString());
                }
            }
            else
            {
                lbPassengers.Items.Add("Ninguno");
            }
        }

        private void lbPassengers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(lbPassengers.SelectedItem.Equals("Ninguno")){
                return;
            }

            int indexPassenger = lbPassengers.SelectedIndex;
            List<Passenger> passengers = (List<Passenger>) lbPassengers.Tag;
            Passenger passenger = passengers[indexPassenger];
            dgPassengers.Rows.Clear();
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgPassengers, new String[] { passenger.FirstName, passenger.LastName, passenger.Type.showTypeText(), PlaceToString.showText(passenger.Origin), PlaceToString.showText(passenger.Destiny) });
            dgPassengers.Rows.Add(row);
            dgPassengers.Visible = true;
        }

        private void setStationMostConcurred() {
           
            Station result = null;
            double maxPass = 0, totalPassengers = 0;
            foreach (Station station in stations) {
                if (station.Passengers.Count > maxPass) {
                    maxPass = station.Passengers.Count;
                    result = station;
                }
                totalPassengers += station.Passengers.Count;
            }
            double percentage = (maxPass / totalPassengers) * 100;
            lblPassCount.Text = maxPass + " pasajeros";
            lblPercentage.Text = "(" + percentage + "%)";
            tbEstacionMasConc.Text = PlaceToString.showText(result.StationName);
        }

        private void setStationLessConcurred() {

            Station result = null;
            int minPass = 1;
            foreach (Station station in stations)
            {
                if (station.StationName != Place.DEVOTO && station.Passengers.Count <= minPass)
                {
                    minPass = station.Passengers.Count;
                    result = station;
                }
            }
            tbEstacionMenosConc.Text = PlaceToString.showText(result.StationName);
            lblPerLess.Text = minPass + " pasajeros";
        
        }

        private void chkActivateTypeStats_CheckedChanged(object sender, EventArgs e)
        {
            if (!panelStats.Visible)
            {
                panelStats.Visible = true;
            }
            else
            {
                panelStats.Visible = false;
            }
        }

        private void type_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            PassengerTypeEnum typeEnum = Type.getType(rb.Name);
            int counter = 0;
            foreach (Station station in stations) {
                foreach (Passenger passenger in station.Passengers) {
                    if (passenger.Type.Type == typeEnum) {
                        counter++;
                    }
                }
            }
            tbTypeSum.Text = counter.ToString();
        }
    }
}
