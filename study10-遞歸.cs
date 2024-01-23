
// using System.Globalization;

namespace MyNamespace
{
    //public，可被其他程式碼存取，公共類別定義，程式碼的組織單位，它可以包含屬性、方法和其他相關的程式碼
    public class MyClass9
    {
        //這個方法是一個公開（public）的無回傳值（void）方法。拿來當作主方法
        public void statement7()
        {
            Console.WriteLine(x(6));
            Console.WriteLine(x1(8));
            Console.WriteLine(x2(8));
            Console.WriteLine(x3(15));
        }
        //遞歸實現：n!=n*(n-1)*(n-2)*...*1
        //ex:3!=3*2*1
        //核心思想：將問題將問題轉移給範圍小的將問題轉移給範圍小的子問提
        //適用性：解決問題解決問題過程，又遇到相同問題
        //遞歸優勢：代碼簡潔，可讀性高。將複雜問題簡單化
        //缺點：性能較差
        private static int x(int Num)
        {
            //邊界，如果Num等於1，那麼就返回1，停止遞歸
            if (Num == 1)
            {
                return 1;
            }
            return Num * x(Num - 1);
            //先執行Num是否直到1。
            //數學式拆開來講：若Num=3
            //3x2x1=3x(3-1)x(3-2)
            //一開始num=3，但不等於1啊，往下走：(3-1)。此時x(Num)的Num=2，但不等於1啊，往下走：(2-1)。此時x(Num)的Num=1，等於1啊，不用繼續減了，返回1，停止遞歸 ，一層層返回回去。
            //前面光做減法，沒有乘啊，所以一層層開始乘回去1x1，2x(2-1)，3x(3-1)
            //3  x  (3-1)
            //2  x  (2-1)
            //1  x  return 1
            //遞歸就是你看哪個動作要一直重複做，就把那個重複規律的算試抓出來return,以及前面也要判斷終點直到return 1;(又或者終點是別的)

        }

        //1-2+3-4+5-6+7-8
        //計算參數為8時總和是多少
        private static int x1(int Num)
        {
            int result = 0;
            for (int i = 1; i <= Num; i++)
            {
                //偶數
                if (i % 2 == 0)
                {
                    result += -i;
                }
                else//奇數
                {
                    result += i;
                }
            }
            return result;
        }
        //1-2+3-4+5-6+7-8
        //計算參數為8時總和是多少用遞歸實現
        private static int x2(int Num)
        {
            if (Num == 1) return 1;

            if (Num % 2 == 0)//偶數
            {
                return x2(Num - 1) - Num; //偶數要和上一個數座運算:-8+7
            }
            else//奇數
            {
                return x2(Num - 1) + Num;//奇數也要和上一個數做運算:7-6
            }

        }

        //-1+2-3+4-5+6-7+8
        //計算參數為8時總和是多少用遞歸實現
        private static int x3(int Num)
        {
            if (Num == 1) return -1;//Num表示當前處於的位置（階層數），而不是實際的數字，return終點：-1

            if (Num % 2 == 0)//偶數
            {
                return x3(Num - 1) + Num; //偶數要和上一個數座運算(反正就是由後往前算)
            }
            else//奇數
            {
                return x3(Num - 1) - Num;//奇數也要和上一個數做運算(反正就是由後往前算)
            }

        }
        
    }
}