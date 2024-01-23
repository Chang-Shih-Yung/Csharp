

namespace MyNamespace
{
    public class MyClass1
    {
        public void dataOperation()
        {

            //運算符

            int a1 = 3, a2 = 2;  //一次聲明多個
            int r1 = a1 / a2; // 1，因為int是取整數，所以小樹數無條件刪除
            Console.WriteLine(r1);
            int r2 = a1 % a2;
            Console.WriteLine(r2); // 1，取餘數

            // a1也可以拿來判斷是否可以被2整除，true是偶數，反之則奇數
            bool r4 = a1 % a2 == 0;
            Console.WriteLine(r4); //false

            float a3 = 3, a4 = 2;
            float r3 = a3 / a4;
            Console.WriteLine(r3); //1.5，取商


            string x1 = "henry", x2 = "ok";
            string r5 = x1 + x2;// 字符串拼接

            // 比較運算符> < >= <= == !=
            bool r6 = x1 == x2; //比較文本是否相同，＝為賦值（把右賦予左），==為等於

            //邏輯運算符 &&(與and，一假全假，檢查假) ||(或or，一真全真，檢查真) !(非，取反)，看布爾關係

            int z1 = 1;
            z1 += 3; // z1 = z1 + 3;
            Console.WriteLine(z1);


            //一元運算符，根據操作數劃分：++ --

            //無論先加還是後加，對於”下一條指令“都是都是自增以後的值。對於當前指令才有變化
            int z2 = 1;
            z2++; //後自增，先賦值，結果：自增以前。Console.Write(z2++); -> 1。z2=z2+1
            Console.WriteLine("z2:" + z2++); //2，解釋對於”下一條指令“都是都是自增以後的值。

            int z = 1;
            ++z; //先自增，後賦值，結果：自增以後。Console.Write(++z); -> 2
            Console.WriteLine("z:" + z++); //2，解釋對於”下一條指令“都是都是自增以後的值

            //三元運算符： 數據類型 變量名= 條件？ 滿足條件結果：不滿足條件結果

            string z3 = 1 > 2 ? "ok" : "no"; //string取決於結果類型，所以後面結果的類型必須一致
            float z4 = 1 == 1 ? 0.1f : 0.2f; //float取決於結果類型，所以後面結果的類型必須一致

            //優先級，先乘除後加減

        }
    }
}