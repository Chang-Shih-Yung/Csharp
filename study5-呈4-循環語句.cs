namespace MyNamespace
{
    public class MyClass4
    {
        public void statement2()
        {
            //循環語句 跳轉語句 方法

            //for循環：預定次數的循環、循環計數器
            //for( 初始化 ; 循環條件 ; 增減變量/更新次數 ) {循環體}
            //順序   1       2  5      4 7     3 6
            //若沒有設循環條件=永遠滿足循環條件，死循環

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i); //打印五次
            }


            //全域變量，作用域是整個類，簡單一點就是看他屬於哪個大括號，就是哪個大括號裡面的變量
            int i2 = 0;
            for (; i2 < 5;)
            {
                Console.WriteLine(i2);
                i2++;
            }
            Console.WriteLine(i2);

            //test1
            //一張紙的厚度為張紙的厚度為0.01mm，，對折30次為多少m?

            float thickness = 0.00001f; //mm換算為0.0001m
            for (int i3 = 1; i3 <= 30; i3++)
            {
                thickness *= 2;
            }
            Console.WriteLine("厚度為：" + thickness);

            //test2
            //1-100內數字能被3整除的累加和
            int num = 0;
            for (int i4 = 1; i4 <= 100; i4++)
            {
                if (i4 % 3 != 0)continue;//如果是!=0，可以用continue<跳過本次循環，繼續下一次循環>，或者用break<跳出循環>
                {
                    num += i4;
                }
            }
            Console.WriteLine(num);

            //while循環：不知道循環次數，但知道循環條件
            //while(循環條件) {循環體}

            //先判斷條件，再執行循環體
            int i5 = 0;//先做初始化
            while (i5 < 5)
            {
                Console.WriteLine("哈哈");
                i5++;//再做增減變量
            }
            //test3
            //一顆球從100m高度落下，每次落地後反彈高度為原高度的一半，再落下，計算總共彈?次最終落地(最小彈起高度0.01m)，總共經過多少m。
            float height = 100;//當前高度
            int count = 0;
            float distance = 100;//初始化第一次落地的距離=height
            //height >= 0.01f是判斷當前高度，但應該要判斷下次彈起後的高度
            while (height / 2 >= 0.01f)
            {
                height /= 2;
                count++; //計數，為什麼不是count+1?因為count++是先把count的值給count，再+1，count+1是先+1，再把值給count

                //累加起落距離，每次落地後反彈高度為原高度的一半，再落下，所以總共經過的距離是每次落地後反彈高度的兩倍
                distance = distance + height * 2;

                Console.WriteLine("經過{0}次，經過{1}m", count, height);
            }
            Console.WriteLine("經過{0}次最終落地", count);
            Console.WriteLine("總共經過的距離：{0:f1}米", distance);

            //do-while循環：不知道循環次數，但知道循環條件
            //do {循環體} while(循環條件)，先執行一次、再判斷條件，成立繼續，條件不成立跳出循環


            //test1
            //隨機產生1-100隨機數，直到玩家猜到為止：提示大了、小了、猜對了，總共猜了幾次
            //創建隨機數工具
            Random random = new Random();
            int r = random.Next(1, 101);//1-100，左等右不等 
            int input = int.Parse(Console.ReadLine());
            int c = 0;
            do
            {
                c++;
                Console.WriteLine("請輸入1-100的數字：");
                if (input > r)
                {
                    Console.WriteLine("大了");
                }
                else if (input < r)
                {
                    Console.WriteLine("小了");
                }
                else
                {
                    Console.WriteLine("猜對了，總共猜了{0}次：", c);
                    break;//跳出循環
                }
            } while (true);//滿足條件執行循環體 ，這裡是猜不對時繼續循環，上面寫break，不然這裏要寫input!=r




        }
    }
}