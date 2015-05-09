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
        private Bitmap stationsDrawArea;
        private Graphics graphics;

        public Form1()
        {
            InitializeComponent();
           
            //pictureBox1.Width = this.Size.Width;
            //pictureBox1.Height = this.Size.Height;
            //stationsDrawArea = new Bitmap(stationsPictureBox.Width, stationsPictureBox.Height);
          
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.simulator = new Simulator();
        }
       
        private void drawStations(Graphics g)
        {
            for (int i = 0, x = 0; i < 5; i++, x += 200) {
                g.DrawImage(Properties.Resources.station1, x, 20, 150, 100);
            }
        }

        private void drawRailway(Graphics g)
        {
            for (int i = 0, x = 0; i < 10; i++, x += 100)
            {
                g.DrawImage(Properties.Resources.rail, x, 100, 100, 90);
            }
        }

        private void drawTrain(Graphics g)
        {
            g.DrawImage(Properties.Resources.train, 0, 260, 100, 50);
        }

        private void avanzarEstacion_Click(object sender, EventArgs e)
        {
            if (!this.simulator.Train.isEmpty()) {
            
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stationsPictureBox_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            drawStations(graphics);
            
        }

        private void railwayPictureBox_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            drawRailway(graphics);
        }

        private void trainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            drawTrain(graphics);
        }
    }
}
