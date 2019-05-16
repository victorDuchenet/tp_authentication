using System;
using System.Collections.Generic;
using System.Text;

namespace TP_API
{
    public class RandomProvider : IRandom
    {
        public int GetRandomValue()
        {
            return new Random().Next();
        }
    }
}
