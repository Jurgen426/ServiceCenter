using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using ServiceCenter.Controller;
using ServiceCenter.Model;

namespace ServiceCenter.View
{
    static class Program
    {
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ServiceCenterController serviceCenterController = new ServiceCenterController();
            serviceCenterController.ListenAction();

            Application.Run(serviceCenterController.mainWindowView);

           
        }
    }
}









