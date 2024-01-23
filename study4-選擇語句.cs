namespace MyNamespace
{
    public class MyClass3
    {
        public void statement()
        {

            //語句：：選擇語句、循環語句、、跳轉語句

            //test:if.else if.else
            Console.WriteLine("請輸入性別");
            string gender = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrEmpty(gender))
            {
                Console.WriteLine("未輸入性別");
            }
            else if (gender == "男")
            {
                Console.WriteLine("您好，先生");
            }
            else if (gender == "女")
            {
                Console.WriteLine("您好，女士");
            }
            else
            {
                Console.WriteLine("未知");
            }

            //test2
            //在控制台輸入兩個數、 一個運算符，並根據運算符計算兩個數
            //if else裏面若只包一句話，則可以省略大括號

            Console.WriteLine("請輸入第一個數字");
            string a = Console.ReadLine() ?? string.Empty;
            float a2 = float.Parse(a);
            Console.WriteLine("請輸入第二個數字");
            string b = Console.ReadLine() ?? string.Empty;
            float b2 = float.Parse(b);
            Console.WriteLine("請輸入運算符");
            string c = Console.ReadLine() ?? string.Empty;
            float result;

            if (c == "+")
            {
                result = a2 + b2;
            }
            else if (c == "-")
            {
                result = a2 - b2;
            }
            else if (c == "*")
            {
                result = a2 * b2;
            }
            else if (c == "/")
            {
                result = a2 / b2;
            }
            else
            {
                result = 0;
            }
            //判斷結果
            if (c == "+" || c == "-" || c == "*" || c == "/")
            {
                Console.WriteLine("答案等於：" + result);
            }
            else
            {
                Console.WriteLine("運算符號輸入錯誤，請重新輸入");
            }

            //test3
            //用戶輸入成績，判斷成績等級顯示“優秀”“良好”“及格”“不及格”“輸入錯誤”
            Console.WriteLine("請輸入成績");
            string score = Console.ReadLine() ?? string.Empty;
            int score2 = int.Parse(score);
            string message = string.Empty;
            if (score2 < 0 || score2 > 100)
            {
                message = "輸入錯誤";
            }
            else if (score2 >= 90)
            {
                message = "優秀";
            }
            else if (score2 >= 80)
            {
                message = "良好";
            }
            else if (score2 >= 60)
            {
                message = "及格";
            }
            else if (score2 < 60)
            {
                message = "不及格";
            }
            Console.WriteLine(message);

            //-------------------------------------------------------------------------------

            //switch，效率比if else高，但是只能判斷相等的情況，不能判斷大於小於以及範圍。判斷的變量也有限制
            //用test2例子，用switch寫
            Console.WriteLine("請輸入第一個數字");
            string a3 = Console.ReadLine() ?? string.Empty;
            float a4 = float.Parse(a3);
            Console.WriteLine("請輸入第二個數字");
            string b3 = Console.ReadLine() ?? string.Empty;
            float b4 = float.Parse(b3);
            Console.WriteLine("請輸入運算符");
            string c2 = Console.ReadLine() ?? string.Empty;
            float result2 = 0;
            switch (c2)
            {
                //情況1
                case "+":
                    result2 = a4 + b4;
                    break;//跳出switch語句，進這個就不進其他的了，也就是多路分支
                //情況2
                case "-":
                    result2 = a4 - b4;
                    break;//跳出switch語句
                //情況3
                case "*":
                    result2 = a4 * b4;
                    break;//跳出switch語句
                //情況4
                case "/":
                    result2 = a4 / b4;
                    break;//跳出switch語句
                //如果都不是以上情況，默認值，代表，代表其餘結果
                default:
                    result2 = 0;
                    break;//跳出switch
            }
            Console.WriteLine("答案等於：" + result2);

            //switch test2
            //讓用戶在控制台輸入月份，判斷該月份有幾天
            Console.WriteLine("請輸入月份");
            string month = Console.ReadLine() ?? string.Empty;
            int month2 = int.Parse(month);
            string error = "輸入錯誤";
            int days = 0;
            if (month2 >= 1 && month2 <= 12)
            {

                switch (month2)
                {

                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        days = 30;
                        break;
                    case 2:
                        days = 28;
                        break;
                    default:
                        days = 31;
                        break;
                }
            }
            else
            {
                Console.WriteLine(error);
            }

            Console.WriteLine("{0}月有{1}天", month2, days);


            //-------------------------------------------------------------------------------

              //短路短路邏輯
            //&&：與，兩邊都為true，結果才為true。當第一個為false，則不再判斷第二個。用來把簡單的判斷放前面
            //||：或，兩邊都為false，結果才為false。當第一個為true，則不再判斷第二個。用來把複雜的判斷放前面

           

        }
    }
}