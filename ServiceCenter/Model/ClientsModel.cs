using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ServiceCenterLibrary;

namespace ServiceCenter.Model
{
     public class ClientsModel
    {
        List<Client> listOfClients;
      
        public ClientsModel()
        {
            listOfClients = new List<Client>(); 
        }
        public List<Client> GetAll()
        {
            return listOfClients;
        }

        public Client GetClientById(int id)
        {
            IEnumerable<Client> qwery = from client in listOfClients where client.Id == id select client;  //выбрали всех клиентов с указанным ид
            IEnumerator<Client> ie = qwery.GetEnumerator(); //получили перечислитель
            ie.MoveNext();//т.к. перечислитель изначачльно располагается ПЕРЕД первым элементом, роэтому передвигаем его
            return ie.Current; 
        }

        public void AddClient(Client newClient)
        {
            //если клиенты будут удалятся предусмотреть поиск максимального Id среди всех клиентов
            int count = listOfClients.Count();
            newClient.Id = count;
            listOfClients.Add(newClient);
        }

        public void RemoveClient(int id)
        {
            listOfClients.Remove(GetClientById(id));
        }

        public void ModifyClient(Client client)
        { 
            listOfClients.RemoveAt(client.Id);
            listOfClients.Insert(client.Id,client);
        }

        public void ReplaceCatalog(List<Client> clients)
        {
            listOfClients.Clear();
            //насколько корректно это?
            listOfClients = clients;

        }
    }
}
