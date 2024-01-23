// using System;


namespace MyNamespace
{
    //public，可被其他程式碼存取，公共類別定義，程式碼的組織單位，它可以包含屬性、方法和其他相關的程式碼
    public class MyClass6
    {
        //＊＊[訪問權限]+[修飾符]+返回類型+方法名稱（參數列表）{ 方法體  return結果; }＊＊＊＊
        //＊＊返回值：方法定義者告訴方法調用者的結果，像Console.Readine()就是微軟定義好的方法，他告訴你他的結果是string，所以你可以拿變量 接收他的返回值。
        //＊＊參數：調用者需要提供的條件、訊息，像Console.Readine()就是微軟定義好的方法，他告訴你他需要你輸入的值，所以你必須給他一個值，不然他就不會給你返回值。

        //這個方法是一個公開（public）的無回傳值（void）方法。拿來當作主方法
        public void statement4()
        {

            Fun1();

            //如果給了一個變量，那麼就會把方法的返回值賦值給這個變量。也就是開闢內存空間，把返回值賦值給這個內存空間
            int a = Fun2(); //a=1
            Console.WriteLine(a);
            //如果沒有給變量，那麼就等於不接收那個值，也就只是單純執行方法體內的代碼：打印Console.WriteLine("這是一個方法2");
            Fun2();


            //把賦值教給調用方法的人
            //實際參數：調用方法時傳遞給方法的數據，稱為實際參數。對應：順序、數量、類型

            int a4 = 1;
            string b = "ok";
            Fun3(a4, b);//傳遞參數進來而已，所以名字隨意但的有邏輯，當然也可以一樣但沒意義，引數的概念，a4和b是變量，可以是任何名字，但是要和方法裡的數據類型一樣，這樣才能把值傳進去

            //呈上，當然也可以直接
            Fun3(1, "ok");

            //開闢一塊地，把返回值賦值給這塊地。當然也可以直接Fun4();，但就不會接收返回值，沒意義
            string x5 = Fun4();
            Console.WriteLine(x5);


            //test:兩個整數相加功能（你就只留下相加功能在功能內然後在主函數調用，其他的寫去主函數）
            Console.WriteLine("請輸入第一個數");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("請輸入第二個數");
            int input2 = int.Parse(Console.ReadLine());
            Console.WriteLine("答案是："+Fun5(input1, input2));


        }

        //方法，又稱為函數或是過程

        //＊＊方法定義者告訴方法調用者的結果，像Console.Readine()就是微軟定義好的方法，他告訴你他的結果是string，所以你可以拿變量 接收他的返回值。

        //方法是一系列語句的命名、一段代碼的集合，用於實現某個功能
        //提高服用性、可維護性、可讀性
        //[定義修飾符]、[可選修飾符]、返回類型、方法名稱（參數列表）{ 方法體  return結果; }
        //void沒有返回值
        private static void Fun1()
        {
            Console.WriteLine("這是一個方法");
            return;//沒有返回值的方法也可以寫return但沒有值，結束方法（可寫可不寫，反正默認）
        }
        //返回值類型：功能的結果。
        //類型：數據類型：int、double、string、bool、char、decimal、object
        private static int Fun2()
        {
            Console.WriteLine("這是一個方法2");
            return 1;//返回的數據類型必須與方法聲明中的返回類型相同（這裡是int），或者是其子類型
                     //1隨便寫的
                     //return之後程式碼不執行了
        }

        //Console.WriteLine("xxx");前面不可以聲明變量，因為他是void，沒有返回值
        //但是Console.Readine();前面可以聲明變量，因為他有string返回值，但沒有也沒差，就單純暫停。也就是看你有沒有要接收返回值而已


        //形式參數：定義方法時小括號裡的參數，稱為形式參數，也叫參數
        //就像js的引數概念，的目的是將"數據"傳遞給方法，以便方法可以使用這些數據進行運算、處理或返回結果。
        private static void Fun3(int a, string b)//意思是我只是要一個整數跟一個字串，你給我就好，我不管你叫什麼名字，我只要你給我就好
        {
            Console.WriteLine(a + b);
        }

        //看懂方法的定義，看懂方法的調用，看懂方法的返回值
        private static string Fun4()
        {
            //＊＊重點是要學會調用別人提供的方法＊＊//
            //1.看名字、猜描述
            //2.看參數，類型、名稱、描述
            //3.看返回值
            //4.測試

            //test:學習看標籤
            string x1 = "123456";
            x1 = x1.Remove(3, 1); //從3開始，刪除1個字元
            x1 = x1.Replace('2', '9');
            bool x2 = x1.StartsWith("19");//判斷是否以19開頭
            Console.WriteLine(x2);
            bool x3 = x1.Contains('8');//有沒有包含8這個字元
            Console.WriteLine(x3);

            return x1; //string
        }

        //＊＊方法重要觀念，一次就做"一件事"就好＊＊//
        //test:兩個整數相加功能（你就只留下相加功能在這個功能內然後在主函數調用，其他的寫去主函數）
        private static int Fun5(int a, int b)
        {
            //不用return的寫法，inte改void
            // int re = a + b;
            // Console.WriteLine(re);
            //然後上面主函數直接改成Fun5(input1, input2);就好
            return a + b;
            

        }


    }
}