using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication11.Models
{
    public interface IOrder
    {
        Order AddOrder(Order order);
        
        List<Order> GetAllOrders();
        void OrderStatus(string status, int OrderId);
        int GetOrderPrice(Order order);
    }
}
