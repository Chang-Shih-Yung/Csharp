namespace MyNamespace
{
    //public，可被其他程式碼存取，公共類別定義，程式碼的組織單位，它可以包含屬性、方法和其他相關的程式碼
    public class MyClass11
    {
        public void statement9()
        {
            //彩票生成器
            //紅球1-33   抽6個 不能重複
            //藍球1-16   抽1個 不能重複

            //1.購買彩票的方法："請輸入第一/二...個紅球號碼""號碼不能超過33/當前號碼已經存在"

            //2.隨機產生一注的方法int[7]
            //random.Next(1, 34) 。左等右不等1-33
            //紅球號碼不能重複，且由小到大排

            //3.兩著彩票比較方法，返回中獎等級>>先計算紅球、籃球中獎數量

            int[] myTicket = Buyticket();
            int level;
            int cost = 0;//次數從零開始算
            int count = 0;//次數從零次開始算
            do
            {
                cost++;
                count++;
                //放裡面，因為要一直產生隨機數。放外面，只會產生一次
                int[] randomTicket = CreateRandomTicket();
                //把我買的彩票，帶入TicketCompare，與隨機產生的彩票方法做比較
                level = TicketCompare(myTicket, randomTicket);
                if (level != 0)
                {
                    Console.WriteLine("恭喜你中了{0}等獎，累積購買{1}次，累積消費：{2:c}元", level, count, cost * 100);//一張100塊錢
                }
                else
                {
                    Console.WriteLine("很遺憾，你沒有中獎");
                }
            } while (level != 4);//非得買到4等獎不可，不然就一直do，循環下去


        }

        //我買的彩票（方法）
        private static int[] Buyticket()
        {
            int[] score = new int[7];//七個數的數組，六紅一藍
            //前六個紅球
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("請輸入第{0}個紅球號碼", i + 1);
                int RedNumber = int.Parse(Console.ReadLine());
                if (RedNumber < 1 || RedNumber > 33)
                {
                    Console.WriteLine("號碼超過範圍");
                }
                else if (Array.IndexOf(score, RedNumber) >= 0)
                {   //索引值>=0就是存在。不存在就是-1
                    Console.WriteLine("號碼已經存在");
                }
                else
                {
                    score[i] = RedNumber;//上面符合條件，才繼續往下走
                }
            }
            //第七個籃球
            int BlueNumber;
            //當符合條件，就做
            do
            {
                Console.WriteLine("請輸入籃球號碼");
                BlueNumber = int.Parse(Console.ReadLine());

                if (BlueNumber >= 1 || BlueNumber <= 16)
                {
                    score[6] = BlueNumber;
                    break;
                }
                else
                {
                    Console.WriteLine("號碼超過範圍");
                }
            } while (BlueNumber >= 1 || BlueNumber <= 16);

            return score;
        }
        static Random r = new Random();

        //隨機產生球（方法）
        private static int[] CreateRandomTicket()
        {
            int[] score = new int[7];
            for (int i = 0; i < 6;)
            {
                int RedNumber = r.Next(1, 34);//在範圍內產生亂數。左等右不等
                //RedNumber在數組中不存在，才能放進去
                if (Array.IndexOf(score, RedNumber) < 0)
                {
                    score[i++] = RedNumber;
                }
            }
            score[6] = r.Next(1, 17);
            //紅球排序
            Array.Sort(score, 0, 6);//排序
            return score;
        }
        //方法：比較我買的彩票號碼與隨機產生的彩票號碼，返回中獎等級
        private static int TicketCompare(int[] MyTicket, int[] RandomTicket)
        {
            //計算紅藍球中獎數量
            //比較藍球
            int BlueNumber = MyTicket[6] == RandomTicket[6] ? 1 : 0;//存在為1，不存在為0
            //比較紅球。我的第i個紅球，在隨機彩票中的紅球號碼是否存在
            int RedCount = 0;
            for (int i = 0; i < 6; i++)
            {
                if (Array.IndexOf(MyTicket, RandomTicket[i], 0, 6) >= 0)//查找ticket2的索引。從0開始，到6結束，索引存在的話為>1 or 0 [0,1,2,3,4,5]
                {
                    RedCount++;//符合，則中獎數量+1
                }
            }

            int level;
            if (BlueNumber + RedCount == 7)
            {
                level = 1;
            }
            else if (RedCount == 6)
            {
                level = 2;
            }
            else if (RedCount + BlueNumber == 6)
            {
                level = 3;
            }
            else if (RedCount + BlueNumber == 5)
            {
                level = 4;
            }
            else if (RedCount + BlueNumber == 4)
            {
                level = 5;
            }
            else if (BlueNumber == 1)
            {
                level = 6;
            }
            else
            {
                level = 0;
            }
            return level;



        }

    }
}
