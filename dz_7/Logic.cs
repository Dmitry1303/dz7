using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_7
{
    class Logic
    {

        public static string Plus(string Row)
        {
            Row = (int.Parse(Row) + 1).ToString();
            return Row;
        }

        public static string Multi2(string Row)
        {
            Row = (int.Parse(Row) * 2).ToString();
            return Row;
        }

        public static string Reset(string Row)
        {
            Stacks qwe = new Stacks();
            return "0";

        }

        public static string Cancel(string Row)
        {

            return Row;
        }


    }
  
}
