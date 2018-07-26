using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game5
{
    class Player
    {
        protected int a, a1, a2, b, b1, b2, x, y;
        public int GetA()
        {

            return a;
        }
        public int GetA1()
        {

            return a1;
        }
        public int GetA2()
        {

            return a;
        }
        public int GetB()
        {
            return b;
        }
        public int GetB1()
        {
            return b1;
        }
        public int GetB2()
        {
            return b2;
        }
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public void SetIDNhap(string o)
        {
            arr[a, b] = o;
            arr[a1, b1] = o;
            arr[a2, b2] = o;
        }
       
        public string GetIDNhap1()
        {
            
            return arr[a, b];
        }
        public string GetIDNhap2()
        {
            return arr[a1, b1];
            
        }
        public string GetIDNhap3()
        {
            
            return arr[a2, b2];
        }
        public string GetIDBan()
        {
            return arr[x, y];
        }
        public void SetIDBan(string o)
        {
            arr[x, y] = o;
        }
        public Player()
        {

        }
        protected string[,] arr = {
                            {"-","-","-","-","-"},
                            {"-","-","-","-","-"},
                            {"-","-","-","-","-"},
                            {"-","-","-","-","-"},
                            {"-","-","-","-","-"}
                        };
        int n = 0;
        public void Xuat()
        {
            Console.WriteLine("    0   1   2   3   4");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(i);
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    Console.Write("{0,4}", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        public void Nhap()
        {

            Console.WriteLine("Nhap toa do 3 diem cua con thuyen: ");
            nhaplai:
            Console.WriteLine("Nhap toa do diem 1 : ");

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a < 0 || a > 4 || b < 0 || b > 4)
            {
                Console.WriteLine("Nhap sai toa do, nhap lai: ");
                goto nhaplai;
            }
            nhaplai1:
            Console.WriteLine("Nhap toa do diem 2 : ");
            a1 = Convert.ToInt32(Console.ReadLine());
            b1 = Convert.ToInt32(Console.ReadLine());
            if (a1 < 0 || a1 > 4 || b1 < 0 || b1 > 4)
            {
                Console.WriteLine("Nhap sai toa do, nhap lai: ");
                goto nhaplai1;
            }
            nhaplai2:
            Console.WriteLine("Nhap toa do diem 3 : ");
            a2 = Convert.ToInt32(Console.ReadLine());
            b2 = Convert.ToInt32(Console.ReadLine());
            if (a2 < 0 || a2 > 4 || b2 < 0 || b2 > 4)
            {
                Console.WriteLine("Nhap sai toa do, nhap lai: ");
                goto nhaplai2;
            }
        }
        public void Ban()
        {

            nhaplai:
            Console.WriteLine("Nhap toa do diem ban: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            if (x < 0 || x > 4 || y < 0 || y > 4)
            {
                Console.WriteLine("nhap sai toa do,nhap lai:");
                goto nhaplai;
            }

        }
    }
}
