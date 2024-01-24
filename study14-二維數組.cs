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

            int[,] array1 = new int[2, 3];
            array1[0, 0] = 1;
            array1[1, 1] = 2;


            //打印二維數組
            //二維數組跟兩層fo循環是非常緊密的

            foreach (int i in array1)
            {
                Console.WriteLine(i);
            }

            //打印二維數組。外面控制行，裡面控制列
            //
            for (int f = 0; f < 2; f++)
            {

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(array1[f, i]);//1&0。顯示了第一行的第一列、第二行的第一列
                }
            }

        }


    }
}
