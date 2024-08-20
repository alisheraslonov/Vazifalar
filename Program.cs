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