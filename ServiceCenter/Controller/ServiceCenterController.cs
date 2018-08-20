using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ServiceCenter.View;
using ServiceCenter.Model;
using ServiceCenterLibrary;

using ServiceCenter.DataStorage;


namespace ServiceCenter.Controller
{
    class ServiceCenterController
    {

        private ClientController clientController;

        //private ClientsModel clientsModel;
        public OrdersModel ordersModel;
        private WorkersModel workersModel;

        //private Clients clientsView;
        private Login loginView;
        public MainWindow mainWindowView;
        //private ClientParametesView clientParametersView;
        private OrderParametersView orderParametersView;
        private Orders ordersView;
        private WorkerParametersView workerParametersView;
        private Workers workersView;

        //storage
        
        FileStorage fileStorage;
        



        private Order currentOrder;
        

        public ServiceCenterController()
        {
            //хранилище
            
            fileStorage = new FileStorage();

            //инициализация контроллеров
            clientController = new ClientController();

            ///инициализация моделей
            //clientsModel = new ClientsModel();
            ordersModel = new OrdersModel();
            workersModel = new WorkersModel();

            //LoadClientsModel();//загрузка даннных в модель
            LoadOrdersModel();//загрузка даннных в модель
            LoadWorkersModel();//загрузка даннных в модель

            //создание видов
            loginView = new Login();
            //mainWindowView = new MainWindow();
            mainWindowView = new MainWindow(ordersModel);

            orderParametersView = new OrderParametersView(clientController,ordersModel, workersModel);
            

           
  
           

            ///работа с клиентами
            //clientsView = new Clients(clientsModel.GetAll());
            //clientParametersView = new ClientParametesView();

            //работа с сотрудниками
            workersView = new Workers(workersModel.GetAll());
            workerParametersView = new WorkerParametersView();

            ordersView = new Orders(ordersModel.GetAll());
            currentOrder = new Order();


        }

        /// <summary>
        /// сохранение и загрузка моделей
        /// </summary>
        //public void SaveClientsModel()
        //{
        //    fileStorage.SaveData("clients.xml", clientsModel.GetAll());
        //}

        //public void LoadClientsModel()
        //{
        //    bool isExist = fileStorage.ChekExistingFile("clients.xml");
        //    if (isExist==true)
        //    {
        //        List<Client> clients = fileStorage.LoadData<List<Client>>("clients.xml");
        //        clientsModel.ReplaceCatalog(clients);
        //    }  
        //}
        public void SaveOrdersModel()
        {
            fileStorage.SaveData("orders.xml", ordersModel.GetAll());
        }

        public void LoadOrdersModel()
        {
            bool isExist = fileStorage.ChekExistingFile("orders.xml");
            if (isExist == true)
            {
                List<Order> orders = fileStorage.LoadData<List<Order>>("orders.xml");
                ordersModel.ReplaceCatalog(orders);
            }
        }

        public void SaveworkersModel()
        {
            fileStorage.SaveData("workers.xml", workersModel.GetAll());
        }

        public void LoadWorkersModel()
        {
            bool isExist = fileStorage.ChekExistingFile("workers.xml");
            if (isExist == true)
            {
                List<Worker> workers = fileStorage.LoadData<List<Worker>>("workers.xml");
                workersModel.ReplaceCatalog(workers);
            }
        }





        public void ListenAction()
        {

            //////////////////////////////////////////////////////////////////////////////
            ///главное окно///////////////////////////////////////////////////////////////
            mainWindowView.CreateOrder += () => 
            {
                orderParametersView.SaveOrderAction += SaveNewOrder;
                int countOfOrder = ordersModel.GetOrdersCount(); //получили количество заказов
                int currentNumber = countOfOrder++;//создали новый номер
                currentOrder.Id = currentNumber;//присвоили номер новому заказу
                orderParametersView.SetDefaultValues();//установка значений по умолчанию в полях формы
                orderParametersView.SetOrderNumber(currentNumber);//передали номер в форму заказа
                orderParametersView.ShowDialog();//вызвали форму нового заказа
                orderParametersView.SaveOrderAction -= SaveNewOrder;
            };

            mainWindowView.ShowWorkers += () =>
            {
                workersView.ShowDialog();
            };

            mainWindowView.ShowClients += () =>
            {
                
                clientController.ClientsView.ShowDialog();
                //clientsView.ShowDialog();
            };

            mainWindowView.EditeOrders += () =>
            {
                ordersView.RefreshList(ordersModel.GetAll());
                ordersView.ShowDialog();

            };






            /////////////////////////////////////////////////////////////////////////////////////////
            ///новый заказ//////////////////////////////////////////////////////////////

            ///выбор клиента
            orderParametersView.SelectClientAction += () => 
            {
                clientController.ClientsView.SelectClient += SelectClient;  //подписываемся на событие только если выбор клиента происходит для добавления в зaказ
                clientController.ClientsView.ShowDialog();
                clientController.ClientsView.SelectClient -= SelectClient; //отписываемся
            };

            orderParametersView.SelectRemonterAction += () =>
            {
                workersView.SelectWorker += SelectWorker;
                workersView.ShowDialog();
                workersView.SelectWorker -= SelectWorker;
            };

            

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            ///заказов///////
            ordersView.ModifyOrder += (id) =>
            {
                orderParametersView.SaveOrderAction  += SaveExistingOrder;
                Order or = ordersModel.GetOrderById(id);
                orderParametersView.ShowView(or);
                orderParametersView.SaveOrderAction -= SaveExistingOrder;
                ordersView.RefreshList(ordersModel.GetAll());

            };


            ////////////////////////////////////////////////////////////////////////////////////////////////////
            ///список клиентов///////////////////////////////////////////////////////////////////////////////////



            ////создать
            //clientsView.CreateClient += () =>
            //{
            //    clientParametersView.SaveClientAction += SaveNewClient;
            //    clientParametersView.ShowDialog();
            //    clientParametersView.SaveClientAction -= SaveNewClient;
            //};

            /////удалить
            //clientsView.DeleteClient += (id) =>
            //{
            //    clientsModel.RemoveClient(id);
            //    SaveClientsModel();
            //    clientsView.RefreshList(clientsModel.GetAll());
            //};

            ////изменить клиенta
            //clientsView.ModifyClient += (id) =>
            //{
            //    clientParametersView.SaveClientAction += SaveExistingClient;
            //    Client cl = clientsModel.GetClientById(id);
            //    clientParametersView.ShowView(cl);
            //    clientParametersView.SaveClientAction -= SaveExistingClient;
            //};



            ///////////////////////////////////////////////////////////////////////////////////////
            ///список сотрудников//////////////////////////////////////////////////////////////////

            //создать
            workersView.CreateWorker += () =>
            {
                workerParametersView.SaveWorker += SaveNewWorker;
                workerParametersView.ShowDialog();
                workerParametersView.SaveWorker -= SaveNewWorker;
            };


            ///удалить
            workersView.DeleteWorker += (id) =>
            {
                workersModel.RemoveWorker(id);
                SaveworkersModel();
                workersView.RefreshList(workersModel.GetAll());
            };


            //изменить
            workersView.ModifyWorker += (id) =>
            {
                workerParametersView.SaveWorker += SaveExistingWorker;
                Worker w = workersModel.GetWorkerById(id);
                workerParametersView.ShowView(w);
                workerParametersView.SaveWorker -= SaveExistingWorker;
            };

        }


        ////////////////////////////////////
        private void SaveExistingOrder(Order order)
        {
            ordersModel.ModifyOrder(order);
            SaveOrdersModel();//сохраняем модель
            orderParametersView.Close();//закрываем форму
        }
        private void SaveNewOrder (Order order)
        {
            //MessageBox.Show("SaveNewOrder");
            //действия по сохранению заказа

            currentOrder.TimeOfAcceptance = order.TimeOfAcceptance;
            currentOrder.Description = order.Description;
            currentOrder.MyDevice = new Device();
            currentOrder.MyDevice.Mark = order.MyDevice.Mark;
            currentOrder.MyDevice.Model = order.MyDevice.Model;
            currentOrder.TimeOfAcceptance = order.TimeOfAcceptance;
            currentOrder.TimeOfReturn = order.TimeOfReturn;
            currentOrder.RepairmansComment = order.RepairmansComment;
            currentOrder.MyStatus = order.MyStatus;
            currentOrder.CostOfRepair = order.CostOfRepair;
            ordersModel.AddNewOrder(currentOrder);


            SaveOrdersModel();
            orderParametersView.Close();

        }

        /// /////////////////////////////////////////////////////////////////


        private void SaveExistingWorker(Worker worker)
        {
            workersModel.ModifyWorker(worker);//редактируем работника
            SaveworkersModel();//сохраняем модель
            workerParametersView.Close();//закрываем форму
            workersView.RefreshList(workersModel.GetAll());//обновляем списк работников в окне в окне 
        }

        private void SaveNewWorker(Worker worker)
        {
            workersModel.AddWorker(worker);//добавляем работника в модель
            SaveworkersModel();//сохраняем модель
            workerParametersView.Close();//закрываем форму
            workersView.RefreshList(workersModel.GetAll());//обновляем списк работников в окне в окне 
        }

        private void SelectWorker(Worker worker) //добавление в заказ выбранного работника
        {
            workersView.Close(); //закрыть форму со списком работников
            
            currentOrder.Repairer = worker;  //добавление работника в текущий заказ
            orderParametersView.ShowWorkerInForm(worker); //показать имя и фамилию работника в текстовом поле нового заказ
        }


        //private void SaveNewClient(Client client)
        //{
        //    clientsModel.AddClient(client);//добавляем клиента в модель
        //    SaveClientsModel();//сохраняем модель
        //    clientParametersView.Close();//закрываем форму
        //    clientsView.RefreshList(clientsModel.GetAll());//обновляем списк клиентов в окне 
        //}

        //private void SaveExistingClient(Client client)
        //{
        //    clientsModel.ModifyClient(client);//редактируем клиента
        //    SaveClientsModel(); //сохраняем модель
        //    clientParametersView.Close();//закрываем форму
        //    clientsView.RefreshList(clientsModel.GetAll());//обновляем списк клиентов в окне 
        //}

        private void SelectClient(Client client) //добавление в заказ выбранного клиента
        {
            clientController.ClientsView.Close(); //закрыть форму со списком клиентов
            currentOrder.MyClient = client;  //добавление клиента в текущий заказ
            orderParametersView.ShowClientInForm(client); //показать имя и фамилию клиента в текстовом поле нового заказ
        }



    }
}
