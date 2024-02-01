using System.Runtime.InteropServices.Marshalling;

namespace MyNamespace
{
    //public，可被其他程式碼存取，公共類別定義，程式碼的組織單位，它可以包含屬性、方法和其他相關的程式碼
    public class MyClass13
    {
        public void statement11()
        {
            //分類：一維數組、二（多）維數組、交錯數組

            //二維數組[行,列]
            //聲明：int[,] array1＝new int[2,3];。創建一個2行3列的二維數組，但索引值依然從0開始
            //array1.Length==>6

            //array1[0,1]=6;==>第一行第二列的值為6
            //獲取二維數組中所有元素

            int[,] array1 = new int[2, 3];//行列數，非索引值
            array1[0, 0] = 1;
            array1[1, 1] = 2;
            
            //獲取行(x)列(y)的值
            //array1.GetLength(0) = 2;
            //array1.GetLength(1) = 3;


            //打印二維數組
            //二維數組跟兩層fo循環是非常緊密的

            foreach (int i in array1)
            {
                Console.WriteLine(i);
            }

            //打印二維數組。外面控制行，裡面控制列
            //行數執行0，進內圈列數跑完回圈，再回到外圈。以此類推
            for (int f = 0; f < 2; f++)
            {

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(array1[f, i]);
                }
            }

            //array1.GetLength(0)：行數 >>5
            //array1.GetLength(1)：列數 >>3
            for (int f = 0; f < array1.GetLength(0); f++)
            {

                for (int i = 0; i < array1.GetLength(1); i++)
                {
                    Console.Write(array1[f, i] + "\t");
                }
                Console.WriteLine();
            }


            int[,] array = CalculateScore();
            //打印
            PrintScore(array);


        }

        //practice:在控制台輸入學生成績方法、輸入學生總數、科目數、
        //第一個學生學生第一門成績、第一個學生學生第二門成績
        //第二個學生學生第一門成績、第一個學生學生第二門成績
        private static int[,] CalculateScore()
        {
            Console.WriteLine("請輸入學生數");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("請輸入科目數");
            int subjectCount = int.Parse(Console.ReadLine());
            int[,] array1 = new int[studentCount, subjectCount];
            //外層輸入學生數，內層輸入科目數

            for (int f = 0; f < array1.GetLength(0); f++)
            {
                for (int i = 0; i < array1.GetLength(1); i++)
                {
                    Console.WriteLine("請輸入第{0}個學生的第{1}門成績", f + 1, i + 1);
                    array1[f, i] = int.Parse(Console.ReadLine());

                }

            }

            return array1;
        }
        //打印成績為表格
        private static void PrintScore(int[,] array2)
        {
            int f = 0;
            int i = 0;
            for (; f < array2.GetLength(0); f++)
            {

                for (; i < array2.GetLength(1); i++)
                {
                    Console.WriteLine(array2[f, i] + "\t");

                }
                Console.WriteLine();

            }


        }



    }
}
