using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrainSimulator
{
   public class Retired : PassengerType
    {

       public Retired() : base(PassengerTypeEnum.RETIRED, Properties.Resources.retired) {
           this.speed = 20;
           this.gender = GenderEnum.FEMALE;
           this.minYearThreshold = 1960;
           this.maxYearThreshold = 1940;
       }

       public override String showTypeText()
       {
           return "Jubilado";
       }
    }
}
