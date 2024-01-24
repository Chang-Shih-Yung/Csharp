using System.Runtime.InteropServices.Marshalling;

namespace MyNamespace
{
    //public，可被其他程式碼存取，公共類別定義，程式碼的組織單位，它可以包含屬性、方法和其他相關的程式碼
    public class MyClass12
    {
        public void statement10()
        {
            //for for 二維數組、交錯數組～套娃


            for (int r = 0; r < 3; r++)
            {
                //行
                for (int c = 0; c < 4; c++)
                {
                    Console.Write("ok");
                }
                //列
                Console.WriteLine();

            }

            //practice: 用for迴圈，印出金字塔
            //    *
            //   ***
            //  *****
            // *******
            //*********


            //處理列
            for (int c = 0; c < 5; c++)
            {
                //行，空格:4,3,2,1,0
                for (int r = 0; r < 5 - c; r++)
                {
                    Console.Write(" ");
                }

                //行，星星：1,3,5,7,9

                for (int r = 0; r < 2 * c + 1; r++)
                {
                    Console.Write("*");
                }

                //行處理完，啊就跳下一行
                Console.WriteLine();
            }

            int[] arr = { 1, 8, 6, 2, 14 };
            int[] sortedArr = x(arr);

            foreach (int num in sortedArr)
            {
                Console.Write(num + " ");
                Console.WriteLine();
            }

            int[] arr2 = { 1, 3, 6, 8, 0 };
            bool z = y(arr2);
            Console.WriteLine(z);


        }
        //自定義排序算法
        //冒泡排序法
        //1,8,6,2，由小到大排序
        //  1      8      6       2   >>數組
        //  0      1      2       3   >>索引/位置
        //1 2 3   2 3     3       0   >>1要跟後面(索引+1/索引+2/索引+3)三個數比，8要跟後面兩個數比((索引+1)+1/(索引+1)+2)，6要跟後面一個數比((索引+1+1)+1)

        //  3      2      1       0   >>比較次數

        private static int[] x(int[] array)
        {
            //共比n-1次。需要比較元素索引
            for (int count = 0; count < array.Length - 1; count++)
            {
                //將第i個當拿出來與後面比（索引+1）
                for (int i = count + 1; i < array.Length; i++)
                {//當第一個位置（索引0）要與後面比，後面索引依序是1,2,3～～也就是（count+1/ount+2/ount+3），用循環以此類推
                    if (array[count] > array[i])
                    {//交換
                        int temp = array[count];
                        array[count] = array[i];
                        array[i] = temp;
                    }

                }
            }
            return array;

        }
        //定義檢查數組中是否存在相同數字的方法
        private static bool y(int[] array)
        {//5 3 1 3 8
         //取出元素一個元素
            for (int i = 0; i < array.Length - 1; i++)
            {
                //與後面元素比較
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        return true;

                    }
                }
            }
            //放外面，不然會一直跑迴圈
            return false;

        }


    }
}
