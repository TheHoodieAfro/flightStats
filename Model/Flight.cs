using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public class Flight
    {
        private String date;
        private String destination;
        private String origin;
        private String DepartureDelay;
        private String ArriveDelay;
        private String AirlineId;

        public Flight(string date, string destination, string origin, string departureDelay, string arriveDelay, string airlineId)
        {
            this.Date = date;
            this.destination = destination;
            this.Origin = origin;
            DepartureDelay1 = departureDelay;
            ArriveDelay1 = arriveDelay;
            AirlineId1 = airlineId;
        }

        public string Date { get => date; set => date = value; }
        public string Destination { get => destination; set => destination = value; }
        public string Origin { get => origin; set => origin = value; }
        public string DepartureDelay1 { get => DepartureDelay; set => DepartureDelay = value; }
        public string ArriveDelay1 { get => ArriveDelay; set => ArriveDelay = value; }
        public string AirlineId1 { get => AirlineId; set => AirlineId = value; }
    }
}
