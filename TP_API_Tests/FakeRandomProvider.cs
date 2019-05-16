using System;
using System.Collections.Generic;
using System.Text;
using TP_API;

namespace TP_API_Tests
{
    public class FakeRandomProvider : IRandom
    {
        public int GetRandomValue()
        {
            return 5;
        }
    }
}
