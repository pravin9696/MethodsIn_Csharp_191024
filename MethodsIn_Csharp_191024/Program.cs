using System.ComponentModel;

namespace MethodsIn_Csharp_191024
{

    class myClass
    {
        int M;
        public float Area_circle()
        {
            int r;
            Console.WriteLine("enter radius of circle");
            r=int.Parse(Console.ReadLine());
            float a = 3.14f * r * r;
            return a;

        }
        public int add(int n1,int n2)
        {
            int Result = n1 + n2;
            return Result;
        }
        public void showResult()
        {
            /*
            Console.WriteLine("enter number");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine(n);
            */
            Console.WriteLine(M);
        }
        public void sum(int x, int y)
        {
          M= x + y;
           
        }
        public void method2()
        {
            show();
        }
        void show()
        {
            Console.WriteLine("method show...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //how to call method
            //step 1 create object of respective class
            myClass mc1 = new myClass();
            //step 2 call method using object of class and . operator
            // mc1.show();//method calling
            mc1.method2();

            mc1.sum(1, 3);
           mc1.showResult();
            int P = 100;
            int Q = 200;
            mc1.sum(P, Q);
            mc1.showResult();


            //  Console.WriteLine( mc1.add(3, 4));
         int ans= mc1.add(33, 44);
            Console.WriteLine(ans);


            float ar1 = mc1.Area_circle();
            Console.WriteLine("Area of my Circle is "+ar1);
        }
    }
}




