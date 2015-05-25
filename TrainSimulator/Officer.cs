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
            this.speed = 20;
            this.gender = GenderEnum.MALE;
            this.minYearThreshold = 1980;
            this.maxYearThreshold = 1960;
        }

        public override String showTypeText()
        {
            return "Policia";
        }
    }
}
