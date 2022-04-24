using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsDeluge.WinForm.Extensions
{
    public static class DateTimeExtension
    {
        public static long Timestamp(this DateTime dateTime)
        {
            return (dateTime.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
        }
    }
}
