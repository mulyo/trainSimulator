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
        private Drawable drawable;

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
              
        private void avanzarEstacion_Click(object sender, EventArgs e)
        {
            if (!this.simulator.Train.isEmpty()) {
            
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
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
            this.drawable = new StationDrawing();
            for (int i = 0, x = 0; i < this.simulator.Stations.Count; i++, x += 200)
            {
                this.drawable.draw(graphics, x);
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Control[] ctr = this.Controls.Find("trainPictureBox", true);

            foreach (Control cr in ctr)
            {
                PictureBox pb = ((PictureBox)cr);
                pb.Location = new Point(pb.Location.X + 5, pb.Location.Y);
            }
        }
    }
}
