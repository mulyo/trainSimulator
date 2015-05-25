using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSimulator
{
    public class Stretch
    {

        private String name;
        private int passengers;

        public Stretch(String name, int passengers) {
            this.name = name;
            this.passengers = passengers;
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public int Passengers
        {
            get { return passengers; }
            set { passengers = value; }
        }



    }
}
