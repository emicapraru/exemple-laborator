﻿namespace Lab4_Capraru_Emil_Ionut.Domain
{
    public record ValidatedShoppingCart(ProductCode productCode, Quantity quantity, Address address, Price price);
}
