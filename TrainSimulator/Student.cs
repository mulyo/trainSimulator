using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrainSimulator
{
    public class Student : PassengerType
    {
        public Student() : base(PassengerTypeEnum.STUDENT, Properties.Resources.student) {
            this.speed = 20;
            this.gender = GenderEnum.MALE;
        }

        public override String showTypeText()
        {
            return "Estudiante";
        }
    }
}
