using System;
using System.Collections.Generic;
using System.Text;
using TP_API;

namespace TP_API_Tests
{
    public class FakeTimestampProvider : ITimestamp
    {
        public string GetCurrentTimestamp()
        {
            return string.Empty;
        }
    }
}
