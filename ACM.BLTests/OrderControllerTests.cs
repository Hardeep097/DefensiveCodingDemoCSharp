using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Tests
{
    [TestClass()]
    public class OrderControllerTests
    {
        [TestMethod()]
        public void PlaceOrderTest()
        {
            //Arrange 
            var orderController = new OrderController();
            var customer = new Customer() { Email =  "hargvdgdhbd@outlook.com"};
            var order = new Order();
            var payment = new Payment() { };

        
            //Act

            //Assert
        }
    }
}