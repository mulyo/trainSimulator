﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrainSimulator
{
   public class Employee : PassengerType
    {

       public Employee() : base(PassengerTypeEnum.EMPLOYEE, Properties.Resources.employee) {
           this.speed = 20;
           this.gender = GenderEnum.FEMALE;
           this.minYearThreshold = 1990;
           this.maxYearThreshold = 1975;
       }

       public override String showTypeText() {
           return "Empleado";
       }
    }
}
