using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ServiceCenterLibrary;

namespace ServiceCenter.Model
{
    public class WorkersModel
    {
        private List<Worker> listOfWorkers;

        public WorkersModel()
        {
            listOfWorkers = new List<Worker>();
            //workers.Add(new Worker { Name = "John", Surname = "Doe", PhoneNumbers = "055-55-55-555", Position = Position.Repairer });
        }

        internal List<Worker> GetAll()
        {
            return listOfWorkers;
        }
        public void ReplaceCatalog(List<Worker> workers)
        {
            listOfWorkers.Clear();
            this.listOfWorkers = workers;
        }
        public void AddWorker(Worker newWorker)
        {
            int count = listOfWorkers.Count();
            
            newWorker.Id = count;

            listOfWorkers.Add(newWorker);

            
        }
        public void RemoveWorker(int id)
        {
            listOfWorkers.Remove(GetWorkerById(id));
        }
        public Worker GetWorkerById(int id)
        {
            IEnumerable<Worker> qwery = from worker in listOfWorkers where worker.Id == id select worker;  //выбрали всех клиентов с указанным ид
            IEnumerator<Worker> ie = qwery.GetEnumerator(); //получили перечислитель
            ie.MoveNext();//т.к. перечислитель изначачльно располагается ПЕРЕД первым элементом, роэтому передвигаем его

            return ie.Current;
        }

        public void ModifyWorker(Worker worker)
        {

            listOfWorkers.RemoveAt(worker.Id);
            listOfWorkers.Insert(worker.Id, worker);
        }


    }
}
