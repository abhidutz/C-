using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    class Program
    {


        public void dataTypes() {
            ///this method holds all the available datatypes in .net framework
            ///
            /*
            int a = 0;//4 bytes value ranges between -2^31 to 2^31-1
            System.Int32 b = 0; // 8 bytes can only take whole numbers
            long l = 1.1;//8 bytes values ranges between -2^63 to 2^63-1 same as int but bigger range
            float f; // 4 byte
            double df; // 8 byte

            decimal d; // 16 byte
            DateTime dt; ; //8 byte
            char ch = ""; // 2 byte
            Boolean b;//1 byte

            int d2 = 0;
            byte b = 224;
            SByte a = (SByte)(b);
            */







        }
        static void Main(string[] args)
        {
            string str = "";
            if (str is object && str is string)// type of object checkcing
            { //do somehting
            }




            checked {
                //checked can be written as a block. THis is used to checkc overflow airthmatic
                //this can be turned off in performance critical taks
                    }
            Console.WriteLine(unchecked(2147483647 + 10));
            Console.ReadLine();


            //null coaleace operator
            int? a = 3;
            int y = a ?? 0;  // cannot simply assign non nullable type to nuallable type










                    }
    }
}
