using System.Runtime.InteropServices.Marshalling;

namespace MyNamespace
{
    //public，可被其他程式碼存取，公共類別定義，程式碼的組織單位，它可以包含屬性、方法和其他相關的程式碼
    public class MyClass15
    {
        public void statement13()
        {
            //交錯數組  參數數組  數據類型

            //交錯數組：不規則表格
            int[][] array = new int[3][];//具有三個元素的交錯數組，每個元素都是一個一維數組
            //創建創建一維數組，賦值給交錯數組的每個元素
            //第一行，有....2列
            array[0] = new int[2];//2列
            //第二行，有....4列
            array[1] = new int[4];//4列
            //第三行，有....1列
            array[2] = new int[1];//1列

            

        }





    }
}
