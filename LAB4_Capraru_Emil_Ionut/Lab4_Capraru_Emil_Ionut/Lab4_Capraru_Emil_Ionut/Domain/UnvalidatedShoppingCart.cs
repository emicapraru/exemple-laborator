namespace Lab4_Capraru_Emil_Ionut.Domain
{
    public record UnvalidatedShoppingCart(ProductCode productCode, Quantity quantity, Address address, Price price);
}
