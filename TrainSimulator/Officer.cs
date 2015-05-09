using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSimulator
{
    public class Officer : PassengerType
    {

        public Officer() : base(PassengerTypeEnum.OFFICER) { }
    }
}
