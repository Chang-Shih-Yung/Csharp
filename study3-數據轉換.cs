

namespace MyNamespace
{
    public class MyClass2
    {
        public void dataConversion()
        {
            //----------------------------------------------

            //string數據類型轉換:Parse
            string number = "18.1";

            // 待轉數據，必須“像”該數據類型
            // int number01 = int.Parse(number); //18
            float number02 = float.Parse(number);
            Console.WriteLine(number02);//18.1，18.0的話0會自動省略

            //任意類型轉換string:To string
            int number01 = 18;
            string str2 = number01.ToString();
            Console.WriteLine(str2);

            //----------------------------------------------
            //練習1，四位數分開宣告
            #region
            Console.WriteLine("請輸入四個整數：");
            string q = Console.ReadLine();
            int q1 = int.Parse(q);
            Console.WriteLine("第一個輸入完畢，enter輸入下一個整數");

            string w = Console.ReadLine();
            int w1 = int.Parse(w);
            Console.WriteLine("第二個輸入完畢，enter輸入下一個整數");

            string e = Console.ReadLine();
            int e1 = int.Parse(e);
            Console.WriteLine("第三個輸入完畢，enter輸入下一個整數");

            string t = Console.ReadLine();
            int t1 = int.Parse(t);
            Console.WriteLine("第四個輸入完畢，enter輸出總和");
            Console.ReadLine();
            int k = q1 + w1 + e1 + t1;
            Console.WriteLine(k);
            #endregion

            //練習2，直接輸入1234，就得到1+2+3+4=10
            Console.WriteLine("請輸入四位整數：");
            string strNum = Console.ReadLine();
            #region 方案一(region/endregion是vs/vscode的用法)
            //string類型轉換成int
            int intNum = int.Parse(strNum);

            int r = intNum % 10; //取餘數，也就是個位
            r += intNum / 10 % 10; //r = r + intNum / 10 % 10;取十位數，因為1234除10取商等於123，%10取餘就是3
            r += intNum / 100 % 10; //取百位
            r += intNum / 1000 % 10; //曲千位
                                     //以上就是個位數＋十位數＋百位數＋千位數
            Console.WriteLine(r);
            #endregion
            //練習3，從字符串裡獲取每個字符
            #region 方案二
            char c1 = strNum[0];
            string s1 = c1.ToString();
            //千位
            int b1 = int.Parse(s1);
            //b1 = b1(千位)+百位
            b1 += int.Parse(strNum[1].ToString());
            //new1.b1 = (千位+百位)+十位
            b1 += int.Parse(strNum[2].ToString());
            //new2.b1 = (千位+百位+十位)+個位
            b1 += int.Parse(strNum[3].ToString());

            Console.WriteLine(b1);

            #endregion


            //----------------------------------------------

            //隱式轉換：自動轉換，小範圍到大範圍的轉換
            byte p1 = 100; //一個byte在內存為8個位置（bit），二進制表示法為01100100
            int p2 = p1;//隱式轉換可行的原因在於int是32位，byte只有8位，可以直接轉換，因為 byte 的範圍是 int 範圍的子集，不會丟失數據

            //顯式轉換：強制轉換，由大範圍到小範圍的強制轉換，可能發生精度丟失
            int p3 = 100;//但如果超過255，byte裝不下了，顯示出來的數字就會不對
            byte p4 = (byte)p3;



            //低精度的數據類型（如 byte）與高精度的數據類型（如 int）進行運算時，低精度的數據會自動提升為高精度，而不需要顯式轉換

            int ii = 1;
            byte bb = 2;
            int rr = ii + bb; //正確

            //不然就要顯式轉換
            byte rr2 = (byte)(ii + bb);

            byte v = 3;
            v += 3; //ok，因為是快捷運算符，不用做類型提升

            v = (byte)(v + 3); //卻要顯式轉換

        }
    }
}