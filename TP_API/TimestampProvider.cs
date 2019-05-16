using System;
using System.Collections.Generic;
using System.Text;

namespace TP_API
{
    public class TimestampProvider : ITimestamp
    {
        public string GetCurrentTimestamp()
        {
            return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
        }
    }
}
