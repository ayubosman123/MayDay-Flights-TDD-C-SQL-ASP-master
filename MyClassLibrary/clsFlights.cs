using System;

namespace MyClassLibrary
{
    public class clsFlights
    {
        public clsFlights()
        {
        }

        public string Airline { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public string FlightNo { get; set; }

        public string Valid(string flightNo, string airline, string destination, string arrival, string arrivalAirport, string departure, string departureAirport)
        {
            string OK = "";
           if (flightNo.Length == 0)
            {
                return OK = OK + "Flight no is blank";
            }
           if(flightNo.Length>4)
            {
                return OK = OK + "Flight no must be less than 4 characters";
            }
            if (airline.Length == 0)
            {
                return OK = OK + "Airline is blank";
            }
            if (airline.Length > 20)
            {
                return OK = OK + "Flight no must be less than 20 characters";
            }
            return OK;
        }
    }
}