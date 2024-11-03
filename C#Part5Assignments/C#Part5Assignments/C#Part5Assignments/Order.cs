using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Part5Assignments
{
    //enumerations
    public enum OrderStatus
    {
        Pending,
        Shipped,
        Delivered
    }
    public class Order
    {
        //properties
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public OrderStatus Status { get; set; } //Calling OrderStatus enum

        //constructor
        public Order(int orderId, string productName)
        {
            OrderId = orderId;
            ProductName = productName;
            Status = OrderStatus.Pending;//Default status initialzed as Pending
        }

        //method to update order status
        public void UpdateStatus(OrderStatus newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"Order {OrderId} status updated to {Status}");
        }

        //method to dispaly order
        public void DisplayOrderInfo()
        {
            Console.WriteLine($"Order ID : {OrderId}, Product: {ProductName}, Status: {Status}");
        }
    }
}
