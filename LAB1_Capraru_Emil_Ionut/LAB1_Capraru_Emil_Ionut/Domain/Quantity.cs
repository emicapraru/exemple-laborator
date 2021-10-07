namespace LAB1_Capraru_Emil_Ionut.Domain
{
    public record Quantity
    {
        public int Value { get; }

        public Quantity(int value)
        {
            if (value > 0)
            {
                Value = value;
            }
            else
            {
                throw new Invalid_quantity($"{value} is an invalid quantity value.");
            }
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
