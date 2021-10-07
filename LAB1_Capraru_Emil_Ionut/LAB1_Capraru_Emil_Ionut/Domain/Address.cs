﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LAB1_Capraru_Emil_Ionut.Domain
{
    class Address
    {
        private static readonly Regex ValidPattern = new("{str, nr}");

        public string _address { get; }

        private Address(string address)
        {
            if (ValidPattern.IsMatch(address))
            {
                _address = address;
            }
            else
            {
                throw new Invalid_address("");
            }
        }

        public override string ToString()
        {
            return _address;
        }
    }
}
