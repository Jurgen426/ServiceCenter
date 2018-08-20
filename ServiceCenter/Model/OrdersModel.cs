using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ServiceCenterLibrary;

namespace ServiceCenter.Model
{
    public class OrdersModel
    {
        List<Order> listOfOrders;
        public event Action ModelChanged;

        public OrdersModel()
        {
            listOfOrders = new List<Order>();   
        }

        public void AddClientToOrder(int orderId, Client client)
        {
            listOfOrders[orderId].MyClient = client;
        }

        public void AddNewOrder(Order order)
        {
            listOfOrders.Add(order);
            GenerateEvent();
        }

        public int GetOrdersCount()
        {
            return listOfOrders.Count;
        }

        public int GetNewOrderCount()
        {
            int count = 0;
            foreach (Order order in listOfOrders)
            {
                if (order.MyStatus == OrderStatus.New)
                {
                    count++;
                }
            }
            return count;
        }

        public List<Order> GetAll()
        {
            return listOfOrders;
        }

        public Order GetOrderById(int id)
        {
            IEnumerable<Order> qwery = from order in listOfOrders where order.Id == id select order;  //выбрали всех клиентов с указанным ид
            IEnumerator<Order> ie = qwery.GetEnumerator(); //получили перечислитель
            ie.MoveNext();//т.к. перечислитель изначачльно располагается ПЕРЕД первым элементом, роэтому передвигаем его

            return ie.Current;
        }

        public void ModifyOrder(Order order)
        {

            listOfOrders.RemoveAt(order.Id);
            listOfOrders.Insert(order.Id, order);
            GenerateEvent();
        }

        public void ReplaceCatalog(List<Order> orders)
        {
            listOfOrders.Clear();
            //насколько корректно это?
            listOfOrders = orders;
        }

        private void GenerateEvent()
        {
            if (ModelChanged != null)
            {
                ModelChanged();
            }
        }


    }
}
