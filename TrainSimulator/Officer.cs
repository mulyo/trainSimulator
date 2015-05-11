using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrainSimulator
{
    public class Officer : PassengerType
    {
        public Officer() : base(PassengerTypeEnum.OFFICER, Properties.Resources.officer) {
            this.speed = 7;
        }

       
    }
}
