using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I360
{
    public static class Test
    {
        public static int ToSafeInt(string value)
        {
            int result;

            try 
            {
                result = Convert.ToInt32(value);
            }
            catch
            {
                result = 0;
            }

            return result;
        }

        public static int ToSafeInt(this string value, int? defaultValue)
        {
            int result;

            try
            {
                result = Convert.ToInt32(value);
            }
            catch
            {
                result = defaultValue == null ? 0 : (int)defaultValue;
            }

            return result;
        }

    }
}
