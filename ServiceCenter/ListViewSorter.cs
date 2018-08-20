using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ServiceCenter
{
    

    //вынести в отдельный файл
    class ListViewItemComparer : IComparer
    {
        private int col;
        private SortOrder order;
        public ListViewItemComparer() //этот констриуктор был в примере но вроде как не нужен
        {
            col = 0;
            order = SortOrder.Ascending;
        }
        public ListViewItemComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }
        
        public int Compare(object x, object y)
        {
            int returnVal = -1;
            ListViewItem a = (ListViewItem)x;
            ListViewItem b = (ListViewItem)y;
            //получам из нужной колонки значения для сравнения
            string first = a.SubItems[col].Text;
            string second = b.SubItems[col].Text;
            //сравниваем и запоминаем результат
            returnVal = String.Compare(first, second);
            // Если сортировка по убыванию
            if (order == SortOrder.Descending)
            {
                returnVal *= -1; //инвертируем
            }
            return returnVal;
  
        }
    }
}
