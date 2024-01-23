namespace MyNamespace
{
    //public，可被其他程式碼存取，公共類別定義，程式碼的組織單位，它可以包含屬性、方法和其他相關的程式碼
    public class MyClass10
    {
        public void statement8()
        {
            //數組，array，一組“相同”數據類型的變量集合
            //元素通過索引（位置序號）進行操作
            //開了地，不放東西，就是默認值，0/0.0/false/null
            //索引：0,1,2,3,4....就是位置編號


            //聲明
            int[] a;//null
            //初始化new int(空間、數據類型)[容量]
            a = new int[5];
            //通過索引，讀寫每個元素
            a[0] = 1;//將將數據1賦值給術組的第一個元素
            a[1] = 2;
            a[2] = 3;
            a[3] = 4;
            a[4] = 5;
            //a[5] = 6;//索引超出範圍，報錯
            int[] b = new int[5];//聲明+初始化

            //Length屬性，獲取數組長度
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);//讀取第一個元素的值
            }


            // CreateScoreArray();
            int[] AddScore = CreateScoreArray(); //將CreateScoreArray()的score返回給AddScore
            Console.WriteLine(AddScore);//AddScore 是一個 int 數組，所以當你嘗試將其輸出到控制台時，它會顯示為 System.Int32[]

            float[] array = new float[4] { 3, 5, 9, 100 };//[3, 5, 9, 100];，[]裡面可不寫、或寫4
            float MaxNum = GetMax(array);
            Console.WriteLine("最大值是：" + MaxNum);


            //又可以寫成：
            float MaxNum2 = GetMax(new float[4] { 3, 5, 9, 100 });//上面array後面的值，直接整包搬進來

            // 又等於:
            float MaxNum3 = GetMax([3, 5, 9, 100]);//上面array後面的值，直接整包搬進來




            Console.WriteLine("請輸入年份");
            //給實際參數
            int year1 = int.Parse(Console.ReadLine());
            Console.WriteLine("請輸入月份");
            //給實際參數
            int month1 = int.Parse(Console.ReadLine());
            Console.WriteLine("請輸入日期");
            //給實際參數
            int day1 = int.Parse(Console.ReadLine());

            int add = AddDays(year1, month1, day1);//實際參數賦值給形式參數day,month,year
            Console.WriteLine("{0}月{1}日是{2}年的第{3}天", month1, day1, year1, add);

            //foreach(元素變量類型 元素變量名 in 數組名){變量名 即 數組每個元素}
            //簡單讀取簡單讀取術組元素的語句
            //指讀取全部元素，不可以修改元素的值
            foreach (int item in array)
            {
                Console.WriteLine(item);
                //直接從頭到尾、按順序打印數組裡面的所有元素 。好用但不靈活

            }

            //var是一個隱式類型，可以自動推斷變量的類型
            var v1 = 1;//int 
            var v2 = "abc";//string
            var v3 = 1.1;//double
            var v4 = true;//bool    

            //object萬類之組，可以存儲任意類型的數據
            //object不可以寫[]
            object o1 = 1;
            object o2 = true;
            object o3 = new int[3] { 1, 2, 3 }; 
           
            
            //Array是數組的類型，可以存儲任意類型的數據
            Array a1 = new int[3] { 2, 6, 9 };
            // Array.IndexOf(a1,2);//IndexOf是Array的方法，用來查找元素的索引，返回值是int
            Console.WriteLine(Array.IndexOf(a1, 2));//查找2的索引，返回值是int，打印出來是0，因為2的索引是0


            float[] a2 = (float[])array.Clone();//需要轉換類型
            Console.WriteLine(a2[2]);//9


        }


        //test:在控制台數入學生成績
        //1.請輸入學生總數
        //2.輸入第一個學生成績
        //3.如果成績不在0-100之間，提示有錯誤
        private static int[] CreateScoreArray()
        {

            Console.WriteLine("請輸入學生總數");
            int count = int.Parse(Console.ReadLine());

            int[] score = new int[count];
            for (int i = 0; i < score.Length;)
            {
                Console.WriteLine("請輸入第{0}個學生成績", i + 1);//i+1是為了不要從0開始顯示
                score[i] = int.Parse(Console.ReadLine());//將輸入的數字返回給score[i]
                if (score[i] >= 0 && score[i] <= 100)
                {
                    i++;//把上方更新用的i++放這，符合才往下走、不符合就不會i++，所以會再繞一圈停在這裡，等待重新輸入
                }
                else
                {
                    Console.WriteLine("輸入錯誤");
                    // i--;//如果輸入錯誤，i--，重新輸入

                }
            }
            return score;

        }


        //test2定義查找數組元素最大值
        //可以先去調用的地方寫要查找的數組，再回來寫方法
        private static float GetMax(float[] array)
        {
            //先獲取第一個元素
            float max = array[0];//是0,1,2都好，反正就是隨機抓一個
            //依次與後面元素比較，跟自己不用比，所以從1開始
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];//如果array[i]大於max，就把array[i]替換成最大值
                }

            }
            return max;
        }


        private static void Defalt()
        {
            //數組其他寫法
            string[] array01 = new string[3] { "哈", "哈", "哈" };
            //聲明＋初始化＋賦值
            bool[] array02 = { false, true, false };
            //聲明＋初始化＋賦值
            float[] array03 = [3, 5, 9, 100];


        }


        //定義方法：根據根據年月日，根據年月日，計算當天是本年的第幾天
        //2016/3/5
        //累加1,2月整月天數
        //再累加當月天數 
        //提示：將每月存儲到數組中
        private static int AddDays(int year, int month, int day)
        {
            //定義一個數組，存儲每月天數
            int[] days = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
            //定義一個變量，存儲總天數，初始化為0
            int sum = 0;
            //累加1,2月整月天數，0是因為數組從0開始(0-11)，month-1是因為主要累加前面的月份ex:算3（索引為2）月，就是累加1月（索引為0）、2月（索引為1）
            for (int i = 0; i < month - 1;)
            {
                sum += days[i++];//sum = sum + days[i];i++;，反正按照邏輯放這些地方都可以，i++是更新的意思
            }
            //再加當個月天數
            sum += day;
            //如果是閏年，2月天數+1
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                sum++;//是閏年的話，多一天
            }
            return sum;
        }



    }

}
