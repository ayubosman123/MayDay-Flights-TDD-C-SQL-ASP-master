using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTesting
{
    [TestClass]
    public class tstEmployee
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //test to see if it exists
            Assert.IsNotNull(AnEmployee);
        }

        [TestMethod]
        public void EmployeeAddressOK()
        {
            //create instance of class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            string TestData = "Some Address";
            //assign the data to the property
            AnEmployee.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.Address, TestData);
        }

        [TestMethod]
        public void EmployeeContactNumberOK()
        {
            //create instance of class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            string TestData = "07777777777";
            //assign the data to the property
            AnEmployee.EmployeeContactNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.EmployeeContactNumber, TestData);
        }


        [TestMethod]
        public void EmployeeEmail()
        {
            //create instance of class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            string TestData = "ddddd@hotmail.com";
            //assign the data to the property
            AnEmployee.EmployeeEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.EmployeeEmail, TestData);
        }

        [TestMethod]
        public void EmployeeName()
        {
            //create instance of class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            string TestData = "Vinay";
            //assign the data to the property
            AnEmployee.EmployeeName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.EmployeeName, TestData);


        }

        [TestMethod]
        public void EmployeeRole()
        {
            //create instance of class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            string TestData = "Accountant";
            //assign the data to the property
            AnEmployee.EmployeeRole = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.EmployeeRole, TestData);
        }

        [TestMethod]
        public void EmployeeDOB()
        {
            //create instance of class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnEmployee.EmployeeDOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.EmployeeDOB, TestData);
        }

        [TestMethod]
        public void EmployeeJoinDate()
        {
            //create instance of class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnEmployee.EmployeeJoinDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.EmployeeJoinDate, TestData);
        }

        [TestMethod]
        public void EmployeeSalary()
        {
            //create instance of class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            string TestData = "18000";
            //assign the data to the property
            AnEmployee.EmployeeSalary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.EmployeeSalary, TestData);
        }

        [TestMethod]
        public void ValidExist()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "Some Address";
            string EmployeeContactNumber = "07666666666";
            string EmployeeDOB = DateTime.Now.Date.ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "";
            string EmployeeContactNumber = "07666666666";
            string EmployeeDOB = DateTime.Now.Date.ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void AddressMinBoundary()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "f";
            string EmployeeContactNumber = "07666666666";
            string EmployeeDOB = DateTime.Now.Date.ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");

        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "ff";
            string EmployeeContactNumber = "07666666666";
            string EmployeeDOB = DateTime.Now.Date.ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");

        }

        [TestMethod]
        public void AddressMaxMinusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "";
            EmployeeAddress = EmployeeAddress.PadRight(29, 'a');
            string EmployeeContactNumber = "07666666666";
            string EmployeeDOB = DateTime.Now.Date.ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");

        }

        [TestMethod]
        public void AddressMaxBoundary()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "";
            EmployeeAddress = EmployeeAddress.PadRight(30, 'a');
            string EmployeeContactNumber = "07666666666";
            string EmployeeDOB = DateTime.Now.Date.ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");

        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "";
            EmployeeAddress = EmployeeAddress.PadRight(31, 'a');
            string EmployeeContactNumber = "07666666666";
            string EmployeeDOB = DateTime.Now.Date.ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "";
            EmployeeAddress = EmployeeAddress.PadRight(15, 'a');
            string EmployeeContactNumber = "07666666666";
            string EmployeeDOB = DateTime.Now.Date.ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "";
            EmployeeAddress = EmployeeAddress.PadRight(90, 'a');
            string EmployeeContactNumber = "07666666666";
            string EmployeeDOB = DateTime.Now.Date.ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void ContactNumberExtremeMin()
        {
            //create a new instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string EmployeeAddress = "dddd";
            string EmployeeContactNumber = "";
            string EmployeeDOB = DateTime.Now.Date.ToString();
            string EmployeeEmail = "ddddd@hotmail.com";
            string EmployeeJoinDate = DateTime.Now.Date.ToString();
            string EmployeeName = "Vinay";
            string EmployeeRole = "Accountant";
            string EmployeeSalary = "1800";
            //invoke method
            OK = AnEmployee.Valid(EmployeeAddress, EmployeeContactNumber, EmployeeDOB, EmployeeEmail, EmployeeJoinDate, EmployeeName, EmployeeRole, EmployeeSalary);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }
    }

}

