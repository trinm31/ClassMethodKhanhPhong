using System;
using System.Linq.Expressions;

namespace ClassMethod
{
    class Program
    {
        // method
        // <Access-modifier> // public - ai cũng dùng dc , private - chỉ dược sử dụng trong class
        // <return type> // int, string, double - void - output type
        // <parameter> // input variale
        // <Accessmodifier> <return type> <name_method> (<parameter>...){}

        public static void Helloworld()
        {
            Console.WriteLine("Hello World!");
        }
        
        public static string HelloworldString()
        {
            return "Hello World!";
        }

        //public static int age = 10;
        
        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static string Compare(double a, double b)
        {
            if (a>b)
            {
                return $"{a} lơn hơn {b}";
            }
            else
            {
                return $"{a} nhỏ hơn {b}";
            }
        }
        
        // giá trị mặc đinh cho para
        public static double TheTich(double dai = 1, double rong = 1, double cao = 1)
        {
            return dai * rong * cao;
        }

        public static string Fullname(string ho, string ten, string tendem = "")
        {
            return ho + (tendem != "" ? " " + tendem : "") + " " + ten;
        }

        public static void ViDuThamChieu(ref int x)
        {
            x = x + x;
            Console.WriteLine(x);
        }
        
        public static void ViDuKOThamChieu(int x)
        {
            x = x + x;
            Console.WriteLine(x);
        }

        public static void ViduOut(out int x)
        {
            x = 100;
        }
        
        // Hàm đệ quy
        public static int giaiThua(int a)
        {
            // 6! = 6*5*4*3*2*1  // 100! = 100*99*98*...*1
            if (a == 1)
            {
                return 1;
            }
            return a * giaiThua(a - 1); // đẹ quy6
        }

        static void Main(string[] args)
        {
            // var s = Sum(3, 4);
            // Console.WriteLine(s);

            // var s = Compare(3,4);
            // Console.WriteLine(s);

            //var s = TheTich(3,4,5);

            // var name = Fullname("Nguyen", "Tri", "MInh");
            // var name2 = Fullname(ho: "Nguyen", tendem: "Minh", ten: "Tri");
            // Console.WriteLine(name);

            // int a = 4;
            // ViDuThamChieu(ref a);
            // Console.WriteLine(a);

            // int a;
            // ViduOut(out a);
            // Console.WriteLine(a);
            
            
            // class 
            // khởi tạo object
            
            // People Tri = new People();
            // Tri.Age = 21;
            // Tri.Name = "Nguyen Minh Tri";
            // Tri.SkinColor = "Yellow";
            // Tri.Run();
            // Tri.Speak();
            // Tri.Swimming();
            
            People Khanh = new People();
            Khanh.Age = 19;
            Khanh.Name = "Than Le Trong Khanh";
            Khanh.SkinColor = "Yellow";
            Khanh.Run();
            Khanh.Speak();
            Khanh.Swimming();

            People Phong = new People(19, "Phong Thuy", "Yellow");


            var s = SD.name;
            SD.Test();
            
            // Bài tập
            // Viết phần mềm máy tính cầm tay với bốn chức năng cộng trừ nhân chia,
            // guild: 1/ viết class caculator - 2/ viết các các chức năng trong nay - 3/ tông hợp lại tại hàm Main
        }
    }
}