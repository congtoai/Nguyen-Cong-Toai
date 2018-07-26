using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int n1 = 0;
            Player player1 = new Player();
            Player player2 = new Player();
            player1.Xuat();
            Console.WriteLine("Nguoi choi 1:");
            player1.Nhap();
            player1.SetIDNhap("x");
            player1.Xuat();
            Console.WriteLine("Nguoi choi 2:");
            player2.Nhap();
            player2.SetIDNhap("+");
            player2.Xuat();
            Console.WriteLine("******************* BAT DAU CHOI ****************");
         banlai:
            Console.WriteLine("Den luot nguoi choi 1:");
            player1.Ban();
            if (player1.GetIDBan() == player1.GetIDNhap1() ||
                player1.GetIDBan() == player1.GetIDNhap2() ||
                player1.GetIDBan() == player1.GetIDNhap3())
            {
                Console.WriteLine("Khong duoc ban vao thuyen cua minh: ban lai");
                goto banlai;
            }
            else if (player1.GetX() == player2.GetA() && player1.GetY() == player2.GetB() ||
                   player1.GetX() == player2.GetA1() && player1.GetY() == player2.GetB1() ||
                   player1.GetX() == player2.GetA2() && player1.GetY() == player2.GetB2())
            {
                Console.WriteLine("Chuc Mung: ban trung thuyen dich: ");
                player1.SetIDBan("T");
                player1.Xuat();
                Console.WriteLine("--------------------------------------------------------");
                
                n++;
                if (n == 3)
                {
                    {
                        Console.WriteLine("You Win: Game Over");
                        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        goto gameover;
                    }
                }
            }
         
            else if(player1.GetIDBan() == "T")
            {
                Console.WriteLine("Diem nay da duoc ban roi: ban lai ");
                goto banlai;
            }
            else
            {
                Console.WriteLine("Huhu: Ban xit roi:");
                player1.SetIDBan("o");
                player1.Xuat();
                Console.WriteLine("--------------------------------------------------------");
                
            }

            banlai1:
            Console.WriteLine("den luot nguoi choi 2:");
            player2.Ban();
            if (player2.GetIDBan() == "+")
            {
                Console.WriteLine("Khong duoc ban vao thuyen cua minh: ban lai");
                goto banlai1;
            }
            else if (player2.GetX() == player1.GetA() && player2.GetY() == player1.GetB() ||
                   player2.GetX() == player1.GetA1() && player2.GetY() == player1.GetB1() ||
                   player2.GetX() == player1.GetA2() && player2.GetY() == player1.GetB2())
            {
                Console.WriteLine("Chuc Mung: ban trung thuyen dich: ");
                player2.SetIDBan("T");
                player2.Xuat();
                Console.WriteLine("--------------------------------------------------------");
                
                n1++;
                if (n1 == 3)
                {
                    {
                        Console.WriteLine("You Win: Game Over");
                        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        goto gameover;
                    }
                }
            }
            else if (player2.GetIDBan() == "T")
            {
                Console.WriteLine("Diem nay da duoc ban roi: ban lai ");
                goto banlai1;
            }
            else
            {
                Console.WriteLine("Huhu: Ban xit roi:");
                player2.SetIDBan("o");
                player2.Xuat();
                Console.WriteLine("--------------------------------------------------------");
                
            }
            goto banlai;
            gameover:
            Console.ReadKey();

        }
    }

}
