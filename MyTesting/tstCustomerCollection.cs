using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;
using Class_Library;

namespace MyTesting
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AnCustomer = new clsCustomerCollection();
            Assert.IsNotNull(AnCustomer);
        }
    }
}
    
