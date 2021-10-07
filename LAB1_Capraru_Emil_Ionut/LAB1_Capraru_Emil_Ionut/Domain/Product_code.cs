using System.Text.RegularExpressions;

namespace LAB1_Capraru_Emil_Ionut.Domain
{
    public record Product_code
    {
        private static readonly Regex ValidPattern = new("^1[0-9]{3}$");

        public string Code { get; }

        private Product_code(string value)
        {
            if (ValidPattern.IsMatch(value))
            {
                Code = value;
            }
            else
            {
                throw new Invalid_product_code("");
            }
        }

        public override string ToString()
        {
            return Code;
        }
    }
}
