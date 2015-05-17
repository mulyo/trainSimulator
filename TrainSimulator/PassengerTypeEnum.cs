using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSimulator
{
    public enum PassengerTypeEnum
    {

        EMPLOYEE, STUDENT, OFFICER, RETIRED, DISABLED,
    }

    public static class Type {

        public static PassengerTypeEnum getType(String type)
        {
            switch (type)
            {
                case "Student":
                    return PassengerTypeEnum.STUDENT;
                case "Employee":
                    return PassengerTypeEnum.EMPLOYEE;
                case "Officer":
                    return PassengerTypeEnum.OFFICER;
                case "Retired":
                    return PassengerTypeEnum.RETIRED;
                default: return PassengerTypeEnum.DISABLED;
            }
        }
    }
}
