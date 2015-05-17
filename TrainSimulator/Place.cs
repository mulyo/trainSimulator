using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSimulator
{
    public enum Place
    {
      DEVOTO, URQUIZA, LACROZE, RETIRO, CONSTITUCION,
      
    }

    public static class PlaceToString
    {
        public static String showText(Place place) {
            switch (place)
            {
                case Place.DEVOTO:
                    return "Devoto";
                case Place.URQUIZA:
                    return "Urquiza";
                case Place.LACROZE:
                    return "Lacroze";
                case Place.RETIRO:
                    return "Retiro";
                default: return "Constitucion";
            }
        }
    }
}
