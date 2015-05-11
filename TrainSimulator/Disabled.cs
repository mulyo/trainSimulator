using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TrainSimulator
{
    public class Disabled : PassengerType
    {
        
        public Disabled() : base(PassengerTypeEnum.DISABLED, Properties.Resources.disabled) {
            this.speed = 4;
        }
    }
}
