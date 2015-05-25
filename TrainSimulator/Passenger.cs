using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSimulator
{
    public class Passenger
    {
        private PassengerType type;
        private Place origin;
        private Place destiny;
        private String firstName;
        private String lastName;
        private DateTime birth;

        public Passenger(String firstName, String lastName, PassengerType type, Place origin, Place destiny)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.type = type;
            this.origin = origin;
            this.destiny = destiny;
            this.birth = type.randomBirth();
        }

        public PassengerType Type
        {
            get { return type; }
            set { type = value; }
        }

        public Place Destiny
        {
            get { return destiny; }
            set { destiny = value; }
        }

        public Place Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }

        public override bool Equals(object obj)
        {
            Passenger pass = obj as Passenger;

            return pass.firstName.Equals(this.firstName) && pass.lastName.Equals(this.lastName) && pass.type == this.type;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            return (hash * 7) + firstName.GetHashCode() + lastName.GetHashCode() + type.GetHashCode();
        }

        public DateTime Birth
        {
            get { return birth; }
            set { birth = value; }
        }
    }
}
