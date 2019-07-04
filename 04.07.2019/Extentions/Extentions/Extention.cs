using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Extentions
{
    public static class Extention
    {
        public static int Pow(this int n, int pow)
        {
            int result = 1;
            for (int i = 0; i < pow; i++)
            {
                result *= n;
            }
            return result;
        }
        public static bool IsEmail(this string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
