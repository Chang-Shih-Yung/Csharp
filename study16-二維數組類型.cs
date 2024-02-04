using System.Runtime.InteropServices.Marshalling;

namespace MyNamespace
{
    //public，可被其他程式碼存取，公共類別定義，程式碼的組織單位，它可以包含屬性、方法和其他相關的程式碼
    public class MyClass15
    {
        public void statement13()
        {
            //交錯數組（不規則表格）  參數數組（params）  數據類型

            //交錯數組：不規則表格，每個元素都是一維數組
            int[][] array = new int[3][];//具有三個元素的交錯數組，每個元素都是一個一維數組
            //創建創建一維數組，賦值給交錯數組的每個元素
            //第一行，有....2列
            array[0] = new int[2];//2列
            //第二行，有....4列
            array[1] = new int[4];//4列
            //第三行，有....1列
            array[2] = new int[1];//1列
            //交錯數組賦值
            array[0][0] = 1;//第一行第一列的值為1


            //獲取交錯數組中所有元素：兩個foreach循環   
            //是int[]，是因為array[0]是一個一維數組
            foreach (int[] array2 in array)
            {
                //再取一維數組裡的值
                foreach (int i in array2)
                {
                    Console.WriteLine(i);
                }
            }

            //array2.Length交錯數組交錯數組元素個數（可以理解為：行數）
            for (int r = 0; r < array.Length; r++)
            {
                //array[r].Length交錯數組每行裡面的元素個數（可以理解為：列數）
                for (int c = 0; c < array[r].Length; c++)
                {
                    Console.Write(array[r][c] + "\t");
                }
                Console.WriteLine();
            }

            //參數數組params
            int sum = add(1, 2, 3, 4, 5);
            Console.WriteLine(sum);//15

        }
        //參數數組params
        //對於方法內部而言：就是個普通數組
        //對於方法外部（調用者）而言，可以直接傳入多個參數，而不需要創建數組
        //傳遞一組數據類型相同傳遞一組數據類型相同的變量集合
        //可以不傳遞參數
        //作用：簡化調用者調用方法的代碼
        private static int add(params int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            return sum;
        }





    }
}
