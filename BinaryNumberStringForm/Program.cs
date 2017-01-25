using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNumberStringForm
{

    class Program
    {
        static public char Invert(char s)
        {
            return ((s == '0') ? '1' : '0');
        }

        public class Gene
        {
            public Gene(string s)
            {
                if (s.Length != 8)
                    throw new Exception("too big or too small... must be 8 long");
                value = s;
                tail = value.Substring(4);
                head = value.Remove(4, 4);
            }
            string value;
            string tail;
            string head;
            public override string ToString()
            {
                return value;
            }
            public string Head
            {
                get
                {
                    return head;
                }
            }

            public string Tail
            {
                get
                {
                    return tail;
                }
            }
        }
    }

    //    class Program
    //    {
    //        //public string Number(int num)
    //        //{
    //        //    string result;
    //        //    if(num < 286)
    //        //    {
    //        //        result = Convert.ToString(num);
    //        //        return result;
    //        //    }
    //        //    return "not viable";
    //        //}
    //        //public string opposite(string Number)
    //        //{
    //        //    string result;
    //        //    if ()
    //        //    {
    //        //        result =
    //        //        return
    //        //    }
    //        //}
    static void Main(string[] args)
    {

    }
    //    }
}