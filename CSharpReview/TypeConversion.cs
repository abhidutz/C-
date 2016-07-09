using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    class TypeConversion
    {

        public static void convert() {


            //type conversion
            // 1. using Convert class
            long l = 1;
            int ll = Convert.ToInt32(l);//explicit conversion needed because loss of data possible
            long lg = ll; // impliccit conversion

            //2 type in parentheis

            double d = 32.23;
            float f = (float)d;

            //3. Using methods attached to types. Tryparse() and parse()
            // TryParse() example
            string value = "2";

            int number = 0;
            bool result = Int32.TryParse(value, out number);
            // Parse() example
             number = Int32.Parse(value);

            //In the TryParse() example, the method returns a Boolean result indicating 
            //if the conversion succeeded.   In the Parse() example, if the conversion 
            //does not succeed, an exception will be thrown.





        }



    }
}
