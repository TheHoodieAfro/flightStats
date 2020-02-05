using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public class Flight
    {
        private String date;
        private String origin;
        private String destination;
        private String departureDelay;
        private String arriveDelay;
        private String flightId;
        private String airlineId;

        public Flight(string date, string origin, string destination, string departureDelay, string arriveDelay, string flightId, string airlineId)
        {
            this.Date = date;
            this.Origin = origin;
            this.Destination = destination;
            this.DepartureDelay = departureDelay;
            this.ArriveDelay = arriveDelay;
            this.FlightId = flightId;
            this.AirlineId = airlineId;
        }

        public string Date { get => date; set => date = value; }
        public string Origin { get => origin; set => origin = value; }
        public string Destination { get => destination; set => destination = value; }
        public string DepartureDelay { get => DepartureDelay1; set => DepartureDelay1 = value; }
        public string DepartureDelay1 { get => departureDelay; set => departureDelay = value; }
        public string ArriveDelay { get => arriveDelay; set => arriveDelay = value; }
        public string FlightId { get => flightId; set => flightId = value; }
        public string AirlineId { get => airlineId; set => airlineId = value; }
    }
}
