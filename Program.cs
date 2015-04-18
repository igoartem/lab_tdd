using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


namespace Lab3_test
{
    class Program
    {
        public static List<Gamer> list_gamer;
        public static List<Melody> list_melody;
        

        static void load_melody()
        {
            try
            {
                using (StreamReader sr = new StreamReader("music.txt"))
                {
                    string line,name;
                    int kol_note,fr,sleep,dur;
                    list_melody = new List<Melody>();
                    List<Note> list_note = new List<Note>();

                    while ((line = sr.ReadLine()) != null)
                    {
                        name = line;
                        
                        line = sr.ReadLine();
                        kol_note = Convert.ToInt32(line);
                        for (int i = 0; i < kol_note; i++)
                        {
                            line = sr.ReadLine();
                            sleep = Convert.ToInt32(line);
                            line = sr.ReadLine();
                            fr = Convert.ToInt32(line);
                            line = sr.ReadLine();
                            dur = Convert.ToInt32(line);
                            list_note.Add(new Note(fr, dur, sleep));
                        }
                        list_melody.Add(new Melody(list_note,name));
                        list_note.Clear();
                            

                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("error file!");
            }
        }


        static void load_gamer()
        {
            Console.WriteLine("Введите количство игроков: ");
            string line = Console.ReadLine();
            int kol_gamer = Convert.ToInt32(line);
            list_gamer = new List<Gamer>();
            Console.Clear();
            for (int i = 0; i < kol_gamer; i++)
            {
                Console.WriteLine("Введите имя игрока №" + (i + 1) + ": ");
                line = Console.ReadLine();
                list_gamer.Add(new Gamer(line, i));
            }

            Console.Clear();
        }

        static void view_menu()
        {
            Console.WriteLine("1 - Играть");
            Console.WriteLine("9 - Выход");
            Console.WriteLine("Выберите пункт меню: ");
        }

        static void menu()
        {
            int punkt_menu=-1;
            string line;
            while (punkt_menu != 9)
            {
                Console.Clear();

                view_menu();
                line = Console.ReadLine();
                punkt_menu = Convert.ToInt32(line);
                switch (punkt_menu)
                {
                    case 1:  game(); break; 

                    default: break;

                }

            }

        }
        static void game()
        {

            int kol_vo_mel=list_melody.Count;
            int kol_gamer = list_gamer.Count;
            for (int i = 0; i < kol_vo_mel; i++)
            {
                for (int j = 0; j < kol_gamer; j++)
                {
                    gameGamer(j,i);

                    

                }

            }
        }
        static void gameGamer(int num,int num_mel)
        {
            Console.Clear();
            Console.WriteLine("Играет игрок №" + list_gamer[num].number+1);
            int punkt_menu=0;
            string line;
            bool flag=true;
            while (flag)
            {
                viewmenumusic();
                line = Console.ReadLine();
                punkt_menu = Convert.ToInt32(line);

                switch (punkt_menu)
                {
                    case 1:  Console.Clear();
                        Console.WriteLine("Проигрывается мелодия №" + num_mel + 1);
                        list_melody[num_mel].play_melody();
                        Console.Clear();
                        Console.WriteLine("Выберите вариант ответа:");

                        flag = false;
                        break;

                    default: break;

                }
            }

        }

        static void viewmenumusic()
        {
            Console.WriteLine("Выберите пункт меню:");
            Console.WriteLine("1 - Прослушать мелодию");
            Console.WriteLine("2 - Пропустить");
            Console.WriteLine("3 - Угадать");
        }
        static void Main(string[] args)
        {
            load_melody();
            load_gamer();
           
            list_melody[0].list_note[0].playNote();
            menu();
           
        
            

            

            //Thread.Sleep(1000);
            
            //Console.Beep(264, 125);
            //Thread.Sleep(250);
            //Console.Beep(264, 125);
            //Thread.Sleep(125);
            //Console.Beep(297, 500);
            //Thread.Sleep(125);
            //Console.Beep(264, 500);
            //Thread.Sleep(125);
            //Console.Beep(352, 500);
            //Thread.Sleep(125);
            //Console.Beep(330, 1000);
            //Thread.Sleep(250);
            //Console.Beep(264, 125);
            //Thread.Sleep(250);
            //Console.Beep(264, 125);
            //Thread.Sleep(125);
            //Console.Beep(297, 500);
            //Thread.Sleep(125);
            //Console.Beep(264, 500);
            //Thread.Sleep(125);
            //Console.Beep(396, 500);
            //Thread.Sleep(125);
            //Console.Beep(352, 1000);
            //Thread.Sleep(250);
            //Console.Beep(264, 125);
            //Thread.Sleep(250);
            //Console.Beep(264, 125);
            //Thread.Sleep(125);
            //Console.Beep(2642, 500);
            //Thread.Sleep(125);
            //Console.Beep(440, 500);
            //Thread.Sleep(125);
            //Console.Beep(352, 250);
            //Thread.Sleep(125);
            //Console.Beep(352, 125);
            //Thread.Sleep(125);
            //Console.Beep(330, 500);
            //Thread.Sleep(125);
            //Console.Beep(297, 1000);
            //Thread.Sleep(250);
            //Console.Beep(466, 125);
            //Thread.Sleep(250);
            //Console.Beep(466, 125);
            //Thread.Sleep(125);
            //Console.Beep(440, 500);
            //Thread.Sleep(125);
            //Console.Beep(352, 500);
            //Thread.Sleep(125);
            //Console.Beep(396, 500);
            //Thread.Sleep(125);
            //Console.Beep(352, 1000);


            //Console.Beep(659, 125);
            //Console.Beep(659, 125);
            //Thread.Sleep(125);
            //Console.Beep(659, 125);
            //Thread.Sleep(167);
            //Console.Beep(523, 125);
            //Console.Beep(659, 125);
            //Thread.Sleep(125);
            //Console.Beep(784, 125);
            //Thread.Sleep(375);
            //Console.Beep(392, 125);
            //Thread.Sleep(375);
            //Console.Beep(523, 125);
            //Thread.Sleep(250);
            //Console.Beep(392, 125);
            //Thread.Sleep(250);
            //Console.Beep(330, 125);
            //Thread.Sleep(250);
            //Console.Beep(440, 125);
            //Thread.Sleep(125);
            //Console.Beep(494, 125);
            //Thread.Sleep(125);
            //Console.Beep(466, 125);
            //Thread.Sleep(42);
            //Console.Beep(440, 125);
            //Thread.Sleep(125);
            //Console.Beep(392, 125);
            //Thread.Sleep(125);
            //Console.Beep(659, 125);
            //Thread.Sleep(125);
            //Console.Beep(784, 125);
            //Thread.Sleep(125);
            //Console.Beep(880, 125);
            //Thread.Sleep(125);
            //Console.Beep(698, 125);
            //Console.Beep(784, 125);
            //Thread.Sleep(125);
            //Console.Beep(659, 125);
            //Thread.Sleep(125);
            //Console.Beep(523, 125);
            //Thread.Sleep(125);
            //Console.Beep(587, 125);
            //Console.Beep(494, 125);
            //Thread.Sleep(125);
            //Console.Beep(523, 125);
            //Thread.Sleep(250);
            //Console.Beep(392, 125);
            //Thread.Sleep(250);
            //Console.Beep(330, 125);
            //Thread.Sleep(250);
            //Console.Beep(440, 125);
            //Thread.Sleep(125);
            //Console.Beep(494, 125);
            //Thread.Sleep(125);
            //Console.Beep(466, 125);
            //Thread.Sleep(42);
            //Console.Beep(440, 125);
            //Thread.Sleep(125);
            //Console.Beep(392, 125);
            //Thread.Sleep(125);
            //Console.Beep(659, 125);
            //Thread.Sleep(125);
            //Console.Beep(784, 125);
            //Thread.Sleep(125);
            //Console.Beep(880, 125);
            //Thread.Sleep(125);
            //Console.Beep(698, 125);
            //Console.Beep(784, 125);
            //Thread.Sleep(125);
            //Console.Beep(659, 125);
            //Thread.Sleep(125);
            //Console.Beep(523, 125);
            //Thread.Sleep(125);
            //Console.Beep(587, 125);
            //Console.Beep(494, 125);
            //Thread.Sleep(375);
            //Console.Beep(784, 125);
            //Console.Beep(740, 125);
            //Console.Beep(698, 125);
            //Thread.Sleep(42);
            //Console.Beep(622, 125);
            //Thread.Sleep(125);
            //Console.Beep(659, 125);
            //Thread.Sleep(167);
            //Console.Beep(415, 125);
            //Console.Beep(440, 125);
            //Console.Beep(523, 125);
            //Thread.Sleep(125);
            //Console.Beep(440, 125);
            //Console.Beep(523, 125);
            //Console.Beep(587, 125);
            //Thread.Sleep(250);
            //Console.Beep(784, 125);
            //Console.Beep(740, 125);
            //Console.Beep(698, 125);
            //Thread.Sleep(42);
            //Console.Beep(622, 125);
            //Thread.Sleep(125);
            //Console.Beep(659, 125);
            //Thread.Sleep(167);
            //Console.Beep(698, 125);
            //Thread.Sleep(125);
            //Console.Beep(698, 125);
            //Console.Beep(698, 125);
            //Thread.Sleep(625);
            //Console.Beep(784, 125);
            //Console.Beep(740, 125);
            //Console.Beep(698, 125);
            //Thread.Sleep(42);
            //Console.Beep(622, 125);
            //Thread.Sleep(125);
            //Console.Beep(659, 125);
            //Thread.Sleep(167);
            //Console.Beep(415, 125);
            //Console.Beep(440, 125);
            //Console.Beep(523, 125);
            //Thread.Sleep(125);
            //Console.Beep(440, 125);
            //Console.Beep(523, 125);
            //Console.Beep(587, 125);
            //Thread.Sleep(250);
            //Console.Beep(622, 125);
            //Thread.Sleep(250);
            //Console.Beep(587, 125);
            //Thread.Sleep(250);
            //Console.Beep(523, 125);
            //Thread.Sleep(1125);
            //Console.Beep(784, 125);
            //Console.Beep(740, 125);
            //Console.Beep(698, 125);
            //Thread.Sleep(42);
            //Console.Beep(622, 125);
            //Thread.Sleep(125);
            //Console.Beep(659, 125);
            //Thread.Sleep(167);
            //Console.Beep(415, 125);
            //Console.Beep(440, 125);
            //Console.Beep(523, 125);
            //Thread.Sleep(125);
            //Console.Beep(440, 125);
            //Console.Beep(523, 125);
            //Console.Beep(587, 125);
            //Thread.Sleep(250);
            //Console.Beep(784, 125);
            //Console.Beep(740, 125);
            //Console.Beep(698, 125);
            //Thread.Sleep(42);
            //Console.Beep(622, 125);
            //Thread.Sleep(125);
            //Console.Beep(659, 125);
            //Thread.Sleep(167);
            //Console.Beep(698, 125);
            //Thread.Sleep(125);
            //Console.Beep(698, 125);
            //Console.Beep(698, 125);
            //Thread.Sleep(625);
            //Console.Beep(784, 125);
            //Console.Beep(740, 125);
            //Console.Beep(698, 125);
            //Thread.Sleep(42);
            //Console.Beep(622, 125);
            //Thread.Sleep(125);
            //Console.Beep(659, 125);
            //Thread.Sleep(167);
            //Console.Beep(415, 125);
            //Console.Beep(440, 125);
            //Console.Beep(523, 125);
            //Thread.Sleep(125);
            //Console.Beep(440, 125);
            //Console.Beep(523, 125);
            //Console.Beep(587, 125);
            //Thread.Sleep(250);
            //Console.Beep(622, 125);
            //Thread.Sleep(250);
            //Console.Beep(587, 125);
            //Thread.Sleep(250);
            //Console.Beep(523, 125);
            //Thread.Sleep(625);

            
            //    Console.Beep(300, 500);
            //    Thread.Sleep(50);
            //    Console.Beep(300, 500);
            //    Thread.Sleep(50);
            //    Console.Beep(300, 500);
            //    Thread.Sleep(50);
            //    Console.Beep(250, 500);
            //    Thread.Sleep(50);
            //    Console.Beep(350, 250);
            //    Console.Beep(300, 500);
            //    Thread.Sleep(50);
            //    Console.Beep(250, 500);
            //    Thread.Sleep(50);
            //    Console.Beep(350, 250);
            //    Console.Beep(300, 500);
            //    Thread.Sleep(50);

            

            //Console.Beep(247, 500);
            //Console.Beep(417, 500);
            //Console.Beep(417, 500);
            //Console.Beep(370, 500);
            //Console.Beep(417, 500);
            //Console.Beep(329, 500);
            //Console.Beep(247, 500);
            //Console.Beep(247, 500);
            //Console.Beep(247, 500);
            //Console.Beep(417, 500);
            //Console.Beep(417, 500);
            //Console.Beep(370, 500);
            //Console.Beep(417, 500);
            //Console.Beep(497, 500);
            //System.Threading.Thread.Sleep(500);
            //Console.Beep(497, 500);
            //Console.Beep(277, 500);
            //Console.Beep(277, 500);
            //Console.Beep(440, 500);
            //Console.Beep(440, 500);
            //Console.Beep(417, 500);
            //Console.Beep(370, 500);
            //Console.Beep(329, 500);
            //Console.Beep(247, 500);
            //Console.Beep(417, 500);
            //Console.Beep(417, 500);
            //Console.Beep(370, 500);
            //Console.Beep(417, 500);
            //Console.Beep(329, 500);

            //Console.Beep(440, 300);
            //Console.Beep(330, 300);
            //Console.Beep(440, 300);
            //Console.Beep(330, 300);
            //Console.Beep(440, 300);
            //Console.Beep(415, 300);
            //Console.Beep(415, 300);
            //Thread.Sleep(600);
            //Console.Beep(415, 300);
            //Console.Beep(330, 300);
            //Console.Beep(415, 300);
            //Console.Beep(330, 300);
            //Console.Beep(415, 300);
            //Console.Beep(440, 300);
            //Console.Beep(440, 300);
            //Thread.Sleep(600);
            //Console.Beep(440, 300);
            //Console.Beep(494, 300);
            //Console.Beep(494, 100);
            //Console.Beep(494, 100);
            //Console.Beep(494, 300);
            //Console.Beep(494, 300);
            //Console.Beep(523, 300);
            //Console.Beep(523, 100);
            //Console.Beep(523, 100);
            //Console.Beep(523, 300);
            //Console.Beep(523, 300);
            //Console.Beep(523, 300);
            //Console.Beep(494, 300);
            //Console.Beep(440, 300);
            //Console.Beep(415, 300);
            //Console.Beep(440, 800);
          //  Lab3_test.Gamer gg = new Gamer();
        }
    }
   

    
}
