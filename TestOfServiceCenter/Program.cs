using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using ServiceCenterLibrary;
using System.Runtime.Serialization.Formatters.Binary;

namespace TestOfServiceCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker repairman1 = new Worker { Name = "John", Surname = "Doe", PhoneNumbers = "055-55-55-555" , Position = Position.Repairer };
            Worker repairman2 = new Worker { Name = "Serg", Surname = "Mazko", PhoneNumbers =  "073-033-87-27 , 095-210-16-99" , Position = Position.Repairer };
            Worker repairman3 = new Worker { Name = "Bill", Surname = "Gates", PhoneNumbers = "066-238-45-46" , Position = Position.Repairer };

            List<Worker> workers = new List<Worker>();
            workers.Add(repairman1);
            workers.Add(repairman2);
            workers.Add(repairman3);



            Client client1 = new Client { Id = 1, Name = "John", Surname = "Doe", PhoneNumbers =  "055-55-55-555" , Notes = "Mudak" };

            Device device1 = new Device { Mark = "canon", Model = "EOS" };


            Order order = new Order();
            //order.Id = 1;
            order.MyStatus = OrderStatus.New;
            order.MyClient = client1;
            order.MyDevice = device1;
            order.TimeOfAcceptance = DateTime.Now;
            order.TimeOfReturn = DateTime.MinValue;
            order.Repairer = repairman1;
            order.RepairmansComment = "battery replacment";
            order.CostOfRepair = 8000;


            Console.WriteLine(order.MyClient.PhoneNumbers[0]);
            Console.WriteLine(order.TimeOfReturn);

           

            
            
                

                 ////сериализация 
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream("workers.dat", FileMode.Append))
                {
                    //formatter.Serialize(fs, workers);

                    Console.WriteLine("Объект сериализован");
                }


                List<Worker> workers1 = null;
                using (FileStream fs = new FileStream("workers.dat", FileMode.OpenOrCreate))
                {
                    workers1 = (List<Worker>)formatter.Deserialize(fs);
                    Console.WriteLine("Объект десериализован");
                }

                foreach (var w in workers1)
                {
                    Console.WriteLine(w.Name);
                    foreach (var item in w.PhoneNumbers)
                    {
                    Console.WriteLine(item);
                    }
                }


            

            Worker repairman4 = new Worker { Name = "Bill", Surname = "Gates", PhoneNumbers =  "066-238-45-46" , Position = Position.Repairer };

            foreach (var item in workers1)
            {
                if (item.Equals(repairman4))
                {
                    Console.WriteLine("Equals!");
                    break;
                }
               
            }
           


            }



       
    }
}
