
namespace MyNamespace
{
    //public，可被其他程式碼存取，公共類別定義，程式碼的組織單位，它可以包含屬性、方法和其他相關的程式碼
    public class MyClass7
    {
        //這個方法是一個公開（public）的無回傳值（void）方法。拿來當作主方法
        public void statement5()
        {
            Console.WriteLine("請輸入年份");
            int IWriteAYear = int.Parse(Console.ReadLine());
            PrintyearCalendar(IWriteAYear); //把我輸入的年份數值傳進去
            
        }



        //practice:在主控台根據年份月份顯示月曆

        //先從日、再來月、再來年
        //3.根據年月日，計算星期數
        //2.計算指定月份的天數
        //1.判斷閏年方法：年份能被年份能被4整除但不能被100整除，或者能被400整除


        //1.判斷是否閏年，返回值為bool
        private static bool LeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            //又或者直接：return(year % 4 == 0 && year % 100 != 0) || year % 400 == 0
        }
        //2.判斷指定月份的天數，返回值為:int天數
        private static int GetDayByMonth(int year, int month)
        {
            if (month < 1 && month > 12)
            { return 0; }

            switch (month)
            {

                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if (LeapYear(year))
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                //或是直接return LaepYear(year) ? 29 : 28;
                default:
                    return 31;//剩下的


            }

        }

        //3.這個方法的目的是根據給定的日期，返回該日期是星期幾。返回值為：int星期幾
        private static int GetWeekByDay(int year, int month, int day)
        {
            DateTime dt = new DateTime(year, month, day);
            //強轉換system成int
            return (int)dt.DayOfWeek; //返回該日期是星期幾
            //DayOfWeek是DateTime的屬性，返回值是DayOfWeek列舉類型，列舉類型是一種特殊的整數類型，他的值是固定的，0-6，0是星期日
        }

        //4.顯示月曆
        private static void PrintMonthCalendar(int year, int month)//不用返回值，就是直接全顯示就好
        {
            // 表頭
            Console.WriteLine("");
            Console.WriteLine("{0}年{1}月", year, month);
            Console.WriteLine("");
            Console.WriteLine("日\t一\t二\t三\t四\t五\t六");
            Console.WriteLine("");
            //輸入年月，總要知道顯示的日期是從星期幾”開始“吧？所以抓一號的星期數，顯示空白(ex.星期三前面有三個空白)一週七天，六個空格／week = 7。
            //抓一號星期數，顯示空白
            int week = GetWeekByDay(year, month, 1);
            for (int i = 0; i < week; i++)
            {
                Console.Write("\t.");//不換行打印空格
            }
            //輸入年月顯示當月份天數(1-31)，根據當月總天數(30/31/29/28)顯示日
            //根據當月總天數，顯示日
            int days = GetDayByMonth(year, month); 
            for (int i = 1; i <= days; i++)//假設days=30，依序打印1\t-30\t
            {
                Console.Write(i + "\t");//空格打印、對齊
                //i持續打印過程中，遇到星期六，換行
                if (GetWeekByDay(year, month, i) == 6)
                {
                    Console.WriteLine();//換行打印
                }

            }

        }
        //4-1.輸入年份顯示年曆
        private static void PrintyearCalendar(int year)
        {
            for (int i = 1; i <= 12; i++)
            {
                PrintMonthCalendar(year, i);
                Console.WriteLine();
            }
        }


    }
}