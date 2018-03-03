using System;

namespace MyClassLibrary
{
    public class clsCustomer
    {

        public clsCustomer()
        {
        }

        public string Date { get; set; }
        public string PostCode { get; set; }

        public string Valid(string userName, string password, string foreName, string surname, string dateOfBirth, string gender, string contactNumber, string eMail, string flatNo, string houseNo, string postCode)
        {
            return "";
        }

        //public string Valid(string password, Action username, string contactNo, string customerID, Action email, string flatNo, string forename, Action gender, string surname, string postCode, string v, string dateT)
        //{
        //    DateTime DateTemp;
        //    string OK = "";
        //    if (postCode.Length < 0)
        //    {
        //        OK = OK + "fhfhf";
        //    }
        //    else
        //    {
        //        OK = OK + "fhfhf";
        //    }
        //    DateTemp = Convert.ToDateTime(dateT);
        //    if (DateTemp > DateTime.Now.Date)
        //    {

        //        OK = OK + "fhfhf";
        //    }
        //    return OK;
        //}

        //public string Valid(string postCode, string date)
        //{
        //    throw new NotImplementedException();
        //}

        //public string Valid(string postCode, string surname, string dateT)
        //{
        //    throw new NotImplementedException();
        //}

        //public string Valid(string forename, Action gender, string surname, string postCode, string v, string dateT)
        //{
        //    throw new NotImplementedException();
        //}

        //public string Valid(string email, string flatNo, string forename, Action gender, string surname, string postCode, string v, string dateT)
        //{
        //    throw new NotImplementedException();
        //}

        //public string Valid(string username, string contactNo, string customerID, Action email, string flatNo, string forename, Action gender, string surname, string postCode, string v, string dateT)
        //{
        //    throw new NotImplementedException();
        //}

        //public string Valid(string contactNo, string customerID, Action email, string flatNo, string forename, Action gender, string surname, string postCode, string v, string dateT)
        //{
        //    throw new NotImplementedException();
        //}

        //public string Valid(string flatNo, string forename, Action gender, string surname, string postCode, string v, string dateT)
        //{
        //    throw new NotImplementedException();
        //}

        //public string Valid(bool gender, string surname, string postCode, string v, string dateT)
        //{
        //    throw new NotImplementedException();
        //}

        //public string Valid(string surname, string postCode, string v, string dateT)
        //{
        //    throw new NotImplementedException();
        //}

        //public string Valid(string customerID, Action email, string flatNo, string forename, Action gender, string surname, string postCode, string v, string dateT)
        //{
        //    throw new NotImplementedException();
        //}

        //public string Valid(string gender, string surname, string postCode, string v, string dateT)
        //{
        //    throw new NotImplementedException();
        //}

        //public string Valid(string flatNo, string forename, string gender, string surname, string postCode, string v, string dateT)
        //{
        //    throw new NotImplementedException();
        //}

        //public string Valid(string email, string flatNo, string forename, string gender, string surname, string postCode, string v, string dateT)
        //{
        //    throw new NotImplementedException();
        //}

        //public string Valid(string contactNo, string customerID, Action email, string flatNo, string forename, string gender, string surname, string postCode, string v, string dateT)
        //{
        //    throw new NotImplementedException();
        //}

        //public string Valid(string username, string contactNo, string customerID, Action email, string flatNo, string forename, string gender, string surname, string postCode, string v, string dateT)
        //{
        //    throw new NotImplementedException();
        //}

        //public string Valid(string forename, string gender, string surname, string postCode, string v, string dateT)
        //{
        //    throw new NotImplementedException();
        //}

        //public string Valid(string password, Action username, string contactNo, string customerID, Action email, string flatNo, string forename, string gender, string surname, string postCode, string v, string dateT)
        //{
        //    throw new NotImplementedException();
        //}

        //public string Valid(string customerID, Action email, string flatNo, string forename, string gender, string surname, string postCode, string v, string dateT)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool Valid(string postCode, string date)
        //{
        //    DateTime DateTemp;
        //    Boolean OK = false;
        //    if (postCode.Length < 0)
        //    {
        //        OK = false;
        //    }
        //    else
        //    {
        //        OK = true;
        //    }
        //    DateTemp = Convert.ToDateTime(date);
        //    if (DateTemp > DateTime.Now.Date)
        //    {

        //        OK = false;
        //    }
        //    return OK;

        //}
    }
}