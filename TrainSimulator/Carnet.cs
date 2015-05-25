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
    public partial class Carnet : Form
    {

        private Passenger passenger;

        public Carnet(Passenger passenger)
        {
            InitializeComponent();
            this.passenger = passenger;
            fillCarnet();
        }

        private void fillCarnet() {
            tbCarnetNombre.Text = passenger.FirstName;
            tbCarnetApellido.Text = passenger.LastName;
            tbCarnetTipo.Text = passenger.Type.showTypeText();
            tbCarnetOrigen.Text = PlaceToString.showText(passenger.Origin);
            tbCarnetDestino.Text = PlaceToString.showText(passenger.Destiny);
            tbCarnetEdad.Text = (DateTime.Today.Year - passenger.Birth.Year).ToString() + " años";
            monthCalendar.SetDate(passenger.Birth);
        }
    }
}
