using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        // Описание здания
        static void Main(string[] args)
        {
            MultiBuilding multiBuilding = new MultiBuilding("ул. Красивых молдавских партизан д. 33", 50, 12, 30, 2);                      
            Console.WriteLine("Введите адрес здания");
            multiBuilding.Adress = Console.ReadLine();
            Console.WriteLine("Введите длинну здания");
            multiBuilding.Length = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите ширину здания");
            multiBuilding.Width = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите высоту здания");
            multiBuilding.Height = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите количество этажей здания");
            multiBuilding.Floors = (Convert.ToInt32(Console.ReadLine()));
            multiBuilding.Print();
            Console.ReadKey();
        }    
    }

    class Building
    {
        string adress = "ул. Красивых молдавских партизан д. 33";
        int length = 50;
        int width = 12;
        int height = 30;
        public string Adress { 
            set
            {
                adress = value;
            }
            get { return adress;}
        }
        public int Length {
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Длинна здания не может быть отрицательным. Принято значение по умолчанию " + length);
                }
            }
            get { return length; }
        }
        public int Width {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Ширина здания не может быть отрицательным. Принято значение по умолчанию " + width);
                }
            }
            get { return width; }
        }
        public int Height {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Высота здания не может быть отрицательным. Принято значение по умолчанию " + height);
                }
            }
            get { return height; }
        }

        public Building(string adress, int length, int width, int height)
        {
            this.adress = adress;
            this.length = length;   
            this.width = width;
            this.height = height;
        }

        public void Print()
        {
            Console.WriteLine("Адрес здания " + adress);
            Console.WriteLine("Длинна здания " + length);
            Console.WriteLine("Ширина здания " + width);
            Console.WriteLine("Высота здания " + height);
        }
    }

    sealed class MultiBuilding: Building
    {
        int floors = 2;

        public int Floors
        {
            set
            {
                if (value > 0)
                {
                    floors = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Количество этажей здания не может быть отрицательным. Принято значение по умолчанию " + floors);
                }
            }
            get { return floors; }
        }
        public MultiBuilding(string adress, int length, int width, int height, int floors)
            : base(adress, length, width, height)
        {
            Adress = adress;
            Length = length;   
            Width = width;
            Height = height;
            Floors = floors;
        }

        public new void Print()
        {     
            base.Print();
            Console.WriteLine("количество этажей здания " + floors);
        }
    }
}
