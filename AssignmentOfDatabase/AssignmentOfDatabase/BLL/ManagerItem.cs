using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentOfDatabase.Repository;

namespace AssignmentOfDatabase.BLL
{
    public class ManagerItem
    {
        ItemRepository _itemRepository = new ItemRepository();

        public bool AddItem(string name, double price) 
        {
          return _itemRepository.AddItem(name, price);
        }

        public bool IsNameExist(string name) 
        {
            return _itemRepository.IsNameExist(name);
        }

        public bool DeleteData(string id) 
        {
            return _itemRepository.DeleteData(id);
        }

        public DataTable ShowAllInformation() 
        {
            return _itemRepository.ShowAllInformation();
        }
        public bool UpdateInformation(string name, string price, string id) 
        {
            return _itemRepository.UpdateInformation(name, price, id);
        }

        public DataTable SeachInformation(string name) 
        {
            return _itemRepository.SeachInformation(name);
        }
    }
}
