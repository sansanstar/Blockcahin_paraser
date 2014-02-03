﻿/*
 * BlockChainParser - http://github.com/kria/BlockChainParser
 * 
 * Copyright (C) 2014 Kristian Adrup
 * 
 * This file is part of BlockChainParser.
 * 
 * BlockChainParser is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by the
 * Free Software Foundation, either version 3 of the License, or (at your
 * option) any later version. See included file COPYING for details.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChainParser
{
    static class Utils
    {
        public static string ToHexString(byte[] hash)
        {
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }
    }
}
