using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentOfDatabase.Repository;
namespace AssignmentOfDatabase.BLL
{

    public class OrderManager
    {
        OrderRepository _orderRepository = new OrderRepository();
        public bool AddOrder(string name, string price, string quantity) 
        {
          return  _orderRepository.AddOrder(name, price, quantity);
        }
        public DataTable ShowAllInformation() 
        {
            return  _orderRepository.ShowAllInformation();
        }

        public bool DeleteData(string id) 
        {
            return _orderRepository.DeleteData(id);
        }
        public DataTable SearchInformation(string name) 
        {
            return _orderRepository.SearchInformation(name);
        }
        public bool UpdateInformation(string name, string price, string quantity, string id)
        {
            return _orderRepository.UpdateInformation(name, price, quantity, id);
        }
    }
}
