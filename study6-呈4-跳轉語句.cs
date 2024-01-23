namespace MyNamespace
{
    public class MyClass5
    {
        public void statement3()
        {

            //跳轉語句

            //goto：跳轉到指定的標籤，盡量不要用，會造成程序混亂

            //continue：跳過本次循環，繼續下一次循環
            //1-100內數字能被3整除的累加和
            int num = 0;
            for (int i4 = 1; i4 <= 100; i4++)
            {
                if (i4 % 3 != 0)//如果是!=0，可以用continue<跳過本次循環，繼續下一次循環>，或者用break<跳出循環>
                {
                    continue;//跳過不能被3整除的數字
                }
                num += i4;
            }
            Console.WriteLine(num);

            //return：結束方法，返回值，後面不能寫代碼，因為return後面的代碼不會執行
            //return 0; //返回值，結束方法


            //break：跳出循環，退出最近的循環或是switch
            //test2
            //用戶輸入一個數字，判斷是否是質數
            Console.WriteLine("請輸入一個數字");
            int input = int.Parse(Console.ReadLine());
            bool isPrime = true;//初始化質數
            for (int i = 2; i < input; i++)
            {   //從2開始，因為0,1和任何數字都能整除，所以不用判斷
                // int a = 2;
                if (input % 2 == 0)
                {
                    isPrime = false;
                    break;//等於零就不是質數，中斷、跳出循環
                }
            }

            if (isPrime)
            {
                Console.WriteLine("是質數");
            }
            else
            {
                Console.WriteLine("不是質數");
            }




        }
    }
}