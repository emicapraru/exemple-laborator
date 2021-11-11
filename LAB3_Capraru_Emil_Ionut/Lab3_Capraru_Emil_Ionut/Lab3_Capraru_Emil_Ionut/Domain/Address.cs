﻿using LanguageExt;
using static LanguageExt.Prelude;

using System.Text.RegularExpressions;

namespace Lab3_Capraru_Emil_Ionut.Domain
{
    public record Address
    {
        private static readonly Regex ValidPattern = new("^.*$");

        public string _address { get; }

        public Address(string address)
        {
            if (ValidPattern.IsMatch(address))
            {
                _address = address;
            }
            else
            {
                throw new InvalidAddressException("");
            }
        }

        public override string ToString()
        {
            return _address;
        }
        private static bool IsValid(string stringValue) => ValidPattern.IsMatch(stringValue);

        public static Option<Address> TryParse(string addressString)
        {
            if (IsValid(addressString))
            {
                return Some<Address>(new(addressString));
            }
            else
            {
                return None;
            }
        }

    }
}
