using System.Runtime.InteropServices.Marshalling;

namespace MyNamespace
{
    //public，可被其他程式碼存取，公共類別定義，程式碼的組織單位，它可以包含屬性、方法和其他相關的程式碼
    public class MyClass14
    {
        public void statement12()
        {
            //2048核心算法
            //分析最重要
            //上移
            //以列為單位，從上到下獲取列的數據，形成一維數組
            //合併----
            //1.-將0元素放到數組最後面（合併之前遇到零，去零）
            //2.-合併數據：相同、相鄰、則合併（將後一個數累加到前一個元素上，後一個元素則清空）
            //3.-將0元素放到數組最後面（合併之後遇到零，去零）
            //4.-將一維數組元素 還原至原列

            //下移1.0
            //以列為單位，從下到上獲取列的數據，形成一維數組
            //合併----
            //1.-將0元素放到數組最後面（合併之前遇到零，去零）
            //2.-合併數據：相同、相鄰、則合併（將後一個數累加到前一個元素上，後一個元素則清空）
            //3.-將0元素放到數組最後面（合併之後遇到零，去零）
            //4.-將一維數組元素 還原至原列

            //所以取數據方向不同後，就可以共用方法



            //左移

            //右移

            //START:
            //A.定義去零方法：針對一維數組，將0移至末尾
            //B.合併數據方法：針對一維數組
            //   1.-將0元素放到數組最後面（合併之前遇到零，去零）
            //   2.-合併數據：相同、相鄰、則合併（將後一個數累加到前一個元素上，後一個元素則清空）
            //   3.-將0元素放到數組最後面（合併之後遇到零，去零）
            //C.上移：
            //   1.從上到下獲取列的數據，形成一維數組
            //   2.調用合併數據方法
            //   3.將一維數組元素 還原至原列
            //D.下移：
            //   1.從下到上獲取列的數據，形成一維數組
            //   2.調用合併數據方法
            //   3.將一維數組元素 還原至原列
            //E.左移：

            //F.右移：


            //假設性賦值
            int[,] map = new int[4, 4]{
                {2,2,4,8},
                {2,4,4,4},
                {0,8,4,8},
                {2,4,0,4}
            };

            //上移



        }
        //定義去零方法：針對一維數組，將0移至末尾 ex.2022
        private static int[] RemoveZero(int[] array)
        {
            //將非零元素，依次賦值給新數組
            int[] newArray = new int[array.Length];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                //如果不等於0，就賦值給新數組
                if (array[i] != 0)
                {
                    newArray[index] = array[i];
                    index++;//下一個array不等於零的元素將要賦過來的值
                }
            }
            return newArray;

        }
        private static int[] Merge(int[] array)
        {
            //將0元素放到數組最後面（合併之前遇到零，去零）
            array = RemoveZero(array);
            //合併數據：相同、相鄰、則合併（將後一個數累加到前一個元素上，後一個元素則清空）
            //2202 變成 2220
            for (int i = 0; i < array.Length - 1; i++)
            {
                //相鄰且相同，原本是零的話就不計算合併
                if (array[i] != 0 && array[i] == array[i + 1])
                {
                    array[i] += array[i];
                    //後者要清空
                    array[i + 1] = 0;
                    //統計合併位置

                }
            }
            //將0元素放到數組最後面（合併之後遇到零，去零）
            array = RemoveZero(array);
            return array;

        }

        private static int[,] MoveUp(int[,] map)
        {
            //以列為單位，從上到下獲取每列的數據，形成一維數組
            /*0,0  0,1  0,2  0,3
              1,0  1,1  1,2  1,3
              2,0  2,1  2,2  2,3
              3,0  3,1  3,2  3,3 
            */
            //創建一維數組（獲取每行）
            int[] mergeArray = new int[map.GetLength(0)];

            for (int c = 0; c < map.GetLength(1); c++)
            {
                
                for (int r = 0; r < map.GetLength(0); r++)
                {
                    mergeArray[r] = map[r, c];
                }
                //調用合併數據方法
                mergeArray = Merge(mergeArray);
                //將一維數組元素 還原至原列
                for (int r = 0; r < map.GetLength(0); r++)
                {
                    map[r, c] = mergeArray[r];
                }
            }
            return map;

        }



    }
}
