﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TP_API
{
    public interface ISaltProvider
    {
        byte[] GetSalt();
    }
}
