using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTesting
{
    [TestClass]
    public class tstFlights
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of the class we want to create
            clsFlights AnFlight = new clsFlights();
            //test to see if it exists
            Assert.IsNotNull(AnFlight);
        }

        [TestMethod]
        public void FlightNoOK()
        {
            //create instance of class we want to create
            clsFlights AnFlight = new clsFlights();
            //create some test data to assign to the property
            string TestData = "AI 114";
            //assign the data to the property
            AnFlight.FlightNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.FlightNo, TestData);
        }

        [TestMethod]
        public void AirlineID()
        {
            //create instance of class we want to create
            clsFlights AnFlight = new clsFlights();
            //create some test data to assign to the property
            string TestData = "Air India";
            //assign the data to the property
            AnFlight.Airline = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.Airline, TestData);

        }

        [TestMethod]
        public void ArrivalOK()
        {
            //create a new instance of the class we want to create
            clsFlights AFlight = new clsFlights();
            //create some test data
            DateTime ArrivalDate = DateTime.Now.Date;
            AFlight.ArrivalDate = ArrivalDate;
            //test to see if it exists
            Assert.AreEqual(AFlight.ArrivalDate, ArrivalDate);
        }

        [TestMethod]
        public void DepartureOK()
        {
            //create a new instance of the class we want to create
            clsFlights AFlight = new clsFlights();
            //create some test data
            DateTime DepartureDate = DateTime.Now.Date;
            AFlight.DepartureDate = DepartureDate;
            //test to see if it exists
            Assert.AreEqual(AFlight.DepartureDate, DepartureDate);
        }

        [TestMethod]
        public void FlightValidExist()
        {
            //create a new instance of the class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AI11";
            string Airline = "Air India";
            string ArrivalAirport = "Birmingham Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists 
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoMinMinus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoBoundaryMin()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "A";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoMinPlus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AA";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoMaxMinus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAa";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoBoundaryMax()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAaa";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoMaxPlus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAaaa";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoMid()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AA";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoExtermeMax()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(20, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void AirlineMinMinus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AA";
            string Airline = "";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");



        }

        [TestMethod]
        public void AirlineBoundaryMin()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "A";
            string Airline = "B";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void AirlineMinPlus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AA";
            string Airline = "AI";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void AirlineMaxMinus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAa";
            string Airline = "";
            Airline = Airline.PadRight(9, 'a');
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void AirlineBoundaryMax()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAaa";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void AirlineMaxPlus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAaaa";
            string Airline = "";
            Airline = Airline.PadRight(11, 'a');
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void AirlineMid()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AA";
            string Airline = "AAAAA";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void AirlineExtermeMax()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            string Airline = "";
            Airline = Airline.PadRight(20, 'a');
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void DestinationMinMinus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");

        }

        [TestMethod]
        public void DestinationBoundaryMin()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "A";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "D";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DestinationMinPlus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AA";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Birmingham Airport";
            string Destination = "Du";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }
    }
}
