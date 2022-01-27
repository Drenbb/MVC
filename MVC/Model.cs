using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MVC
{
    static class Model
    {
        //Данные 
        static int n = 0;
        public static List<string> fam = new List<string>() { "Иванов", "Петров", "Сидоров"};
        //Интерфейс
        public static TextBlock tbN;
        public static TextBlock tbList;
        //БЛ
        public static int N 
        { 
            get 
            { 
                return n; 
            }
            set
            {
                n = value;
                tbN.Text = n.ToString();
            }
        }

        public static int Ind 
        {
            set 
            { 
                tbList.Text = fam[value];
            }

        }
    }
}
