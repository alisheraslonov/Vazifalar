//Basic. Ketma-ketlik boʻlimi uchun 1-amaliy vazifa

//1-masala

// Console.Write("Radiusni kiriting: ");
// double radius = Convert.ToDouble(Console.ReadLine());
// double S = Math.PI * Math.Pow(radius, 2);
// double L = 2 * Math.PI * radius;
// Console.WriteLine($"S = {S}, L = {L}");

//2-masala

//int kurs = 12400;
// Console.Write("Qiymat: ");
// double qiymat = Convert.ToDouble(Console.ReadLine());
// double L = kurs * qiymat;
// Console.WriteLine($"Output = {L}");

//3-masala

// Console.Write("Foydalanuvchining tug’ilgan yilini: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int S = 2024;
// int L = (S-x)*365;
// Console.WriteLine($"L = {L}");



//Basic.Ketma-ketlik bo'limi uchun 2-amaliy vazifa

//1. Kalkulyator:

// Console.Write("1-raqam: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ishorani kiriting: ");
// char y = Convert.ToChar(Console.ReadLine());
// Console.Write("2-raqam: ");
// int z = Convert.ToInt32(Console.ReadLine());
// if(y=='-')Console.WriteLine(x-z);
// else if(y=='+')Console.WriteLine(x+z);
// else if(y=='*')Console.WriteLine(x*z);
// else Console.WriteLine(x/z);

//2. Raqamlar qatorining yig‘indisini hisoblash:

// Console.Write("input: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int sum=0;
// for(int i=0; i<=x; i++){
//    sum=sum+i;
// }
// System.Console.WriteLine(sum);

//3.  Paritet tekshiruvi:

// System.Console.Write("Soni kiriting: ");
// int x = Convert.ToInt32(Console.ReadLine());
// if(x%2==0)System.Console.WriteLine($"{x} juft son");
// else System.Console.WriteLine($"{x} toq son");

//Basic.Ketma-ketlik bo'limi uchun 3-amaliy vazifa

//1.Tub sonlar:

       // System.Console.Write("Soni kiriting: ");
       // int x = Convert.ToInt32(Console.ReadLine());
       // int y = 1, z = 0;
       // for(int i=2; i<= x; i++){
       //  if(x%i==0){
       //    z=i/i+z;  
       //   }
       // }
       //   if(z>y)System.Console.WriteLine("tub emas");
       //   else System.Console.WriteLine("tub");

//2.Bo'luvchisiz sonlar:

       // Console.Write("Soni kiriting: ");
       // int x = Convert.ToInt32(Console.ReadLine());
       // int z;
       // Console.Write("Bo'luvchilar: ");
       // for(int i=2; i<=10; i++){
       //         if (x%i==0)
       //         {
       //                 z=i;
       //                 Console.Write($" {z} ");
       //         }
       // }

//3. Daraja hisoblash:

       // Console.Write("Soni kiriting: ");
       // int x = Convert.ToInt32(Console.ReadLine());
       // Console.Write("Darajani kiriting: ");
       // int y = Convert.ToInt32(Console.ReadLine());
       // double z=Math.Pow(x,  y);
       // System.Console.WriteLine(z);

//4. Harajatlar to'plamini hisoblash:

       //  Console.Write("Harajatlar miqdorini vergul bilan ajratib kiriting: ");
       //  string input = Console.ReadLine();
       //  string[] parts = input.Split(',');
       //  int total = 0;
       //  foreach (string part in parts)
       //  {
       //      int amount = Convert.ToInt32(part.Trim());
       //      total += amount;
       //  }

       //  Console.WriteLine($"Harajatlar yig'indisi: {total}");

//5-masala Armstrong sonlar

       // using System.Runtime.InteropServices;

       // System.Console.Write("Soni kiritng: ");
       //        int age=Convert.ToInt32(Console.ReadLine());
       //        int shart = age;
       //        int sum=0,qoldiq;
       //        int uzunlik = age.ToString().Length;
       //      for(int i=0; i<=uzunlik; i++){
       //       qoldiq=age%10;
       //       sum+=(int)Math.Pow(qoldiq,uzunlik);
       //       age/=10;
       //      }
       //      if(shart==sum){
       //        System.Console.WriteLine($"{sum} - Armstrong son ");
       //      }
       //      else{
       //        System.Console.WriteLine("Armstrong son emas");
       //      }
       
//6-Sifatli bo'luvchilari:

       // Console.Write("Soni kiriting: ");
       // int x = Convert.ToInt32(Console.ReadLine());
       // int z;
       // Console.Write("Sifatli bo'luvchilar: ");
       // for(int i=1; i<=x; i++){
       //         if (x%i==0&&i<10)
       //         {
       //                 z=i;
       //                 Console.Write($" {z} ");
       //         }
       // }
//Basics.Tanlash bo’limi uchun 1-amaliy vazifa
//1.String ustida amallar

       // System.Console.WriteLine("So'z kiriting: ");
       // string str = System.Console.ReadLine();
       // System.Console.WriteLine("Ixtiyoriy son kiriting: ");
       // int a = Convert.ToInt32(Console.ReadLine());
       // int b = str.Length;
       // if(a>b){
       //        System.Console.WriteLine(str.ToUpper());
       // }
       // else{
       //        System.Console.WriteLine(str.ToLower());
       // }

//2.Quyida ternary operator bilan ifodalandan qiymatni if-else yordamida ifodalang. 

       // int x = 15,y = 10;
       // if(x > y)System.Console.WriteLine("x is greater than y");
       // else if (x < y)System.Console.WriteLine("x less than y");
       // else if(x == y)System.Console.WriteLine("x is equal to y");
       // else System.Console.WriteLine("x and y are not comparable");

//3.Consoleda o’zbek tilida kiritilgan hafta kunini ingliz tiliga o’girib, natijani ekranga chiqaradigan dastur tuzing. Switch expression dan foydalaning!

       //  Console.Write("Hafta kunini o'zbek tilida kiriting: ");
       //  string dayUzbek = Console.ReadLine();
       //  string dayEnglish = dayUzbek switch
       //  {
       //      "Dushanba" => "Monday",
       //      "Seshanba" => "Tuesday",
       //      "Chorshanba" => "Wednesday",
       //      "Payshanba" => "Thursday",
       //      "Juma" => "Friday",
       //      "Shanba" => "Saturday",
       //      "Yakshanba" => "Sunday",
       //      _ => "Noto'g'ri hafta kuni kiritildi!"  
       //  };
       //  Console.WriteLine($"Ingliz tilida: {dayEnglish}");
//Basics.Tanlash bo'limi uchun 2-amaliy vazifa
//1.Vaqt kalkulyatori:

       // System.Console.Write("Daqiqalarni kiriting: ");
       // int a = Convert.ToInt32(Console.ReadLine());
       // int d = a/60;
       // int b = a - d*60;
       // System.Console.WriteLine($"{d}:{b}"); 

//2.Yosh toifasini aniqlash:       

       // System.Console.Write("Yoshingizni kiriting: ");
       // int a = Convert.ToInt32(Console.ReadLine());
       // if(0 < a && a <= 12)System.Console.WriteLine("Bola");
       // else if(12 < a && a <= 19)System.Console.WriteLine("O'smir");
       // else if(19 < a && a <= 59)System.Console.WriteLine("Kattalar");
       // else if(a==60)System.Console.WriteLine("Katta");
       // else if(a<0)System.Console.WriteLine("Yoshingiz manfiy bo'lishi mumkin emas!");
       // else System.Console.WriteLine("Qariyalar");

//3.O'rtacha ballni hisoblash:

       // System.Console.Write("Balingizni kiriting: ");
       // int a = Convert.ToInt32(Console.ReadLine());
       // string message = 
       //     (a >= 80 && a <= 100) ? "A'lo" 
       //     : (a >= 60 && a <= 79) ? "Yaxshi" 
       //     : (a >= 40 && a <= 59) ? "Qoniqarli" 
       //     : (a < 40 && a>=0) ? "Qoniqarsiz" 
       //     : "Noto'g'ri baho kiritildi!";

       // System.Console.WriteLine(message);

//4."Raqamni toping" o'yini:       

       //  Random rand = new Random();
       //  int a = rand.Next(1, 101);
       //  int b = 0;
       //  while (b != a)
       //  {
       //      Console.Write("1 dan 100 gacha bo'lgan sonni taxmin qiling: ");
       //      b = Convert.ToInt32(Console.ReadLine());
       //      string message = 
       //      (b >a) ? "Kichikroq sonni kiriting." 
       //      : (b < a) ? "Kattaroq sonni kiriting." 
       //      : "Tabriklaymiz! Siz to'g'ri topdingiz!";
       //      Console.WriteLine(message);
       //  }
//Basics.Tanlash bo’limi uchun 3-amaliy vazifa
//1.Palindrome Tekshiruvi
       //         Console.Write("So'zni kiriting: ");
       //         string a = Console.ReadLine();
       //         if (Palindrome(a)){
       //             Console.WriteLine("Palindrom");
       //         }
       //         else{
       //             Console.WriteLine("Palindrom emas");
       //         }
       //     static bool Palindrome(string str)    {
       //         int left = 0;
       //         int right = str.Length - 1;
       //         while (left < right){
       //             if (str[left] != str[right]){
       //                 return false;
       //             }
       //             left++;
       //             right--;
       //         }
       //         return true;
       //     }

//2.Temperatura o'girish
       //      System.Console.Write("Graduslar bo'yicha temperaturani kiriting: ");
       //      double a = Convert.ToDouble(Console.ReadLine());
       //      switch(a){
       //        default : 
       //               double b = (a * 9/5) + 32;
       //               double d = a + 273.15;
       //               System.Console.WriteLine($"Selsiyus: {a}, Fahrenheit: {b}, Kelvin: {d}");
       //               break;
                     
       //      }

//3.Sonlarni tartiblash

       //  Console.Write("Sonlarni kiriting: ");
       //  string a = Console.ReadLine();
       //  int[] b = a.Split(',',' ').Select(int.Parse).ToArray();
       //  switch (b.Length)
       //  {
       //      default:
       //          Array.Sort(b);
       //          Console.WriteLine("Tartiblangan qator: " + string.Join(", ", b));
       //          Array.Reverse(b);
       //          Console.WriteLine("Teskari tartib: " + string.Join(", ", b));
       //          break;
       // }

//4.Berilgan matnning simvol sanasini hisoblash

       //  Console.Write("Matnni kiriting: ");
       //  string str = Console.ReadLine();
       //  Dictionary<char, int> charCount = new Dictionary<char, int>();
       //  foreach (char c in str)
       //  {
       //      if (charCount.ContainsKey(c))
       //      {
       //          charCount[c]++;
       //      }
       //      else
       //      {
       //          charCount[c] = 1;
       //      }
       //  }
       //  foreach (var pair in charCount)
       //  {
       //      Console.WriteLine($"'{pair.Key}': {pair.Value} martta");
       //  }       