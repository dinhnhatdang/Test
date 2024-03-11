using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1
{
    internal class Program
    {
        // Code tu day xuong
        static void Main(string[] args)
        {
            /*int tuoi = 18;
            Console.WriteLine("tuoi cua tui la: {0}", tuoi);
            

            const int LT = 300423;
            Console.WriteLine("Day la hang so {0}", LT);
            Console.ReadLine();*/

            /* int a = 10;
             int b = 3;
             Console.WriteLine(a/b);
             Console.WriteLine(a%b);
             Console.ReadKey();*/

            /*float a = 10f;
            float b = 3f;
            Console.WriteLine(a/b);
            Console.ReadKey();  */

            /* int a = 10; int b = 3;
             //Console.WriteLine((float)a/b);
             Console.WriteLine(a/(float)b);
             Console.WriteLine(a%b);
             Console.ReadKey ();*/


            //Gan kieu du lieu nho vao lon =>ok Ví dụ: float gán vào Double ok
            //Gan kieu du lieu lon vao nho => ko ok - Ví dụ Double gán vào float ko ok

            //Trong && (and) chỉ cần 1 thằng sai => Biểu thức sai
            //Trong || (Or) chỉ cần 1 thằng đúng => Biểu thức đúng


            //Toán tử prefix và posfix
            // ++ hoặc -- đứng trước: prefix
            // ++ hoặc -- đứng sau: posfix
            // int a = 10;
            // int d = 10;
            // int b = ++a; // +=1 => a = a+1; pre => tăng a lên 1 trước, rồi gán cho b
            // int c = d++; // =+ => d = d+1; post => gán d cho c trước, rồi mới tăng 1



            //4. Kiểu cấu trúc
            // class => không xài truct

            //5. Kiểu liệt kê
            // enum : không xài nữa - chỉ xài array hoặc list khi đi làm thôi


            //6. Sử dụng thư viện
            int a = -10;  
            int c = Math.Abs(a);
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
