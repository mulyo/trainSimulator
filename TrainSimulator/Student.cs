using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSimulator
{
    public class Student : PassengerType
    {
        public Student() : base(PassengerTypeEnum.STUDENT) { }
    }
}
