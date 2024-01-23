
namespace MyNamespace
{
    //public，可被其他程式碼存取，公共類別定義，程式碼的組織單位，它可以包含屬性、方法和其他相關的程式碼
    public class MyClass8
    {
        //這個方法是一個公開（public）的無回傳值（void）方法。拿來當作主方法
        public void statement6()
        {
            //test
            //根據分鐘數，計算總秒數

            //＊＊方法重載：方法名稱相同、參數列表不同，解決”同一類型“問題。原本下方名字起的不同，但可以按照參數內容來區分，所以可以把名字改成一樣的。主要是效能優化，避免記憶大量方法

            Console.WriteLine("請輸入分鐘數");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}分鐘就是：" + GetSecond(x) + "秒", x);

            //根據分鐘數、根據分鐘數、小時數，計算總秒數
            Console.WriteLine("請輸入小時數");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}小時{1}分鐘就是：" + GetSecond(x, x1) + "秒", x1, x);

            //根據分鐘數、小時數、天數，計算總秒數
            Console.WriteLine("請輸入天數");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}天{1}小時{2}分鐘就是：" + GetSecond(x, x1, x2) + "秒", x2, x1, x);

            
        }
        //1.根據分鐘數，計算總秒數
        private static int GetSecond(int minute)
        {
            //分鐘變秒
            return minute * 60;
        }
        //2.根據小時數，帶入計算分鐘函示，計算總秒數
        private static int GetSecond(int minute, int hour)
        {   
            // int second = GetSecondByMinute(minute + hour * 60);
            // return second;
            //小時變為分鐘，再加上分鐘，再帶入計算分鐘函示
            return GetSecond(minute + hour * 60);
        }
        //3.根據天數，帶入計算小時函示，計算總秒數
        private static int GetSecond(int minute, int hour, int day)
        {
            // int a = GetSecondByMinute(minute);
            // int b = GetSecondByHour(minute, hour);
            // return a + b + day * 24 * 60 * 60;
            return GetSecond(minute) + GetSecond(minute, hour) + day * 24 * 60 * 60;
            //天轉小時，帶入計算小時函示，再帶入計算分鐘函示
            // return GetSecondByHour(minute,hour+day*24);
        }

    }
}