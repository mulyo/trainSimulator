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
            this.speed = 20;
            this.gender = GenderEnum.MALE;
            this.minYearThreshold = 1980;
            this.maxYearThreshold = 1970;
        }

        public override String showTypeText()
        {
            return "Discapacitado";
        }
    }
}
