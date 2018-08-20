using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceCenter.View;
using ServiceCenter.Model;
using ServiceCenterLibrary;
using ServiceCenter.DataStorage;


namespace ServiceCenter.Controller
{
    public class ClientController
    {
        public Clients ClientsView { get; private set; }
        public ClientsModel ClientsModel { get; private set; }
        // private Clients clientsView;
        private ClientParametesView clientParametersView;
        FileStorage fileStorage;

        public ClientController()
        {
            fileStorage = new FileStorage();
            ClientsModel = new ClientsModel();
            ClientsView = new Clients(ClientsModel.GetAll());
            clientParametersView = new ClientParametesView();
            LoadClientsModel();//загрузка даннных в модель
            ClientsView.RefreshList(ClientsModel.GetAll());
            Listen();
        }

        public Client GetClient(int id)  //этот метод нужен чтобы не передавать модель
        {
            return ClientsModel.GetClientById(id);
        }
        

        public void SaveClientsModel()
        {
            fileStorage.SaveData("clients.xml", ClientsModel.GetAll());
        }

        public void LoadClientsModel()
        {
            bool isExist = fileStorage.ChekExistingFile("clients.xml");
            if (isExist == true)
            {
                List<Client> clients = fileStorage.LoadData<List<Client>>("clients.xml");
                ClientsModel.ReplaceCatalog(clients);
            }
        }

        private void SaveNewClient(Client client)
        {
            ClientsModel.AddClient(client);//добавляем клиента в модель
            SaveClientsModel();//сохраняем модель
            clientParametersView.Close();//закрываем форму
            ClientsView.RefreshList(ClientsModel.GetAll());//обновляем списк клиентов в окне 
        }

        private void SaveExistingClient(Client client)
        {
            ClientsModel.ModifyClient(client);//редактируем клиента
            SaveClientsModel(); //сохраняем модель
            clientParametersView.Close();//закрываем форму
            ClientsView.RefreshList(ClientsModel.GetAll());//обновляем списк клиентов в окне 
        }

        public void Listen()
        {

            //создать
            ClientsView.CreateClient += () =>
            {
                clientParametersView.SaveClientAction += SaveNewClient;
                clientParametersView.ShowDialog();
                clientParametersView.SaveClientAction -= SaveNewClient;
            };

            ///удалить
            ClientsView.DeleteClient += (id) =>
            {
                ClientsModel.RemoveClient(id);
                SaveClientsModel();
                ClientsView.RefreshList(ClientsModel.GetAll());
            };

            //изменить клиенta
            ClientsView.ModifyClient += (id) =>
            {
                clientParametersView.SaveClientAction += SaveExistingClient;
                Client cl = ClientsModel.GetClientById(id);
                clientParametersView.ShowView(cl);
                clientParametersView.SaveClientAction -= SaveExistingClient;
            };
        }







}
}
