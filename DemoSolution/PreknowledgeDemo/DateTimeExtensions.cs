using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreknowledgeDemo;

public static class DateTimeExtensions
{
    public static string ToPrettyString(this DateTime datetime)
    {
        return datetime.ToString("f");
    }
}
