namespace MyNamespace
{
    public class MyClass0
    {
        public void start()
        {
           // See https://aka.ms/new-console-template for more information
//每週末總整理進figma

//寫代碼（.cs）>run>主控台運行

//控制台的標題，title是屬性[修飾]，給名詞的修飾
// Console.Title = "Henry的C#"; 
//在控制台顯示文本

Console.WriteLine("請輸入你的性名");

//Console.ReadLine();表面意思是：讀一行，現象是：暫停程序（等你輸入文本），按enter繼續。input是內存
//string是數據類型
string input = Console.ReadLine();
//將用戶將用戶在控制台將用戶在控制台中輸入的文本，讀取回程序
Console.WriteLine("你好" + input);
//程序暫停
Console.ReadLine();

//Console是類[工具]，它包含WriteLine,ReadLine，叫方法、函數。在unity裡面叫：功能
//類.方法();  調用語句[使用類中的功能]

//----------------------------------------------

// 變量，就是在內存中開闢一塊空間。代碼存在SSD，讀取的時後就拉到內存（RAM），快慢靠CPU處理
//1Byte（字節：電腦最小儲存單位）=8 bit(位：電腦中記憶體最小單位)
//電腦為二進制，只有0,1區別，整數4字節：有符號int、無符號：uint
//整數1、小數1.0f、'1'字符1、"1"字符串1
//十進制255=二進制11111111
//byte 是一種 8 位元（8 bits）的二進制數據類型，所以它的值的範圍是 0 到 255

//----------------------------------------------

//聲明變量，開闢內存空間
string myName;
//賦值。一個等號為賦值，兩個等號才是等於
myName = "Henry";

//----------------------------------------------


float num01 = 1.0f;
Console.WriteLine(num01);
float num02 = 0.9f;
float result = num01 - num02;
bool a = result == 0.1f;
Console.WriteLine(a); //false，元因是float浮點運算會產生誤差

//調適：排除錯誤能力（查看程序運行時，各個變量的取值）

//----------------------------------------------

//練習：在控制台中輸入槍的訊息，“請輸入槍的名稱”請輸入彈夾容量“請輸入當前彈夾內子彈數量”請輸入剩餘子彈數量“
#region
Console.WriteLine("請輸入槍的名稱：");
string gunName = Console.ReadLine();

Console.WriteLine("請輸入彈夾容量：");
string gunClip = Console.ReadLine();

Console.WriteLine("請輸入當前彈夾內子彈數量：");
string bulletNumber = Console.ReadLine();

Console.WriteLine("請輸入剩餘子彈數量：");
string remainNumber = Console.ReadLine();

Console.WriteLine("槍的名稱為：" + gunName + "，彈夾容量為：" + gunClip + "顆，當前彈夾內子彈數量為：" + bulletNumber + "顆，當前剩餘子彈數量為：" + remainNumber + "顆");

//占位符 {位置的編號}，編號大於參數列數量，報錯
string str = string.Format("槍的名稱為：{0}，容量為：{1}。", gunName, gunClip);
Console.WriteLine(str);

Console.ReadLine();
#endregion

//----------------------------------------------


//整形         非整形       非數值
//int         float       char(單個字符)、string(單or多個字符串)、bool

int n1 = 1;
float n2 = 0.1f;  //非整形要加後綴，只有double可以不寫，或寫ｄ
char n3 = '1';
string n4 = "2";
bool f = true;


//----------------------------------------------

//標準數字字符串格式化
Console.WriteLine("金額{0:c}", 10); //貨幣
Console.WriteLine("{0:d2}", 5); //05，不足兩位用0填充
Console.WriteLine("{0:f1}", 1.24); //1.2，根據指定精度表示。小數第一位以後四捨五入
Console.WriteLine("{0:p1}", 0.1); //10.0%，只有p後面無小數 

char n5 = '\0'; //空字符要多寫\0
string n6 = ""; //空字符串這樣寫是可以的
Console.WriteLine("Hi,\r\nI am Henry");  // \r\n 代表跳行

//----------------------------------------------

//.NET程序編譯過程
//原代碼（.cs文本文件）-----> 第一次：CLS編譯(公共語言規範) ------> 通用中間語言(exe、dll)------>第二次：CLR編譯------>機器二進制代碼（0,1）
//                         目的：跨語言                                                   目的：優化/跨平台。ex:unity之所以可以跨多種平台運行


        }
    }
}