using CSharp.Choices;
using System;
using System.Collections.Generic;

namespace LAB1_Capraru_Emil_Ionut.Domain
{
    [AsChoice]
    public static partial class ShopCarts
    {
        public interface IShopcarts { }

        public record EmptyShopCarts(IReadOnlyCollection<EmptyShopCart> ShopCarts) : IShopcarts;

        public record Unvalidated_ShopCarts(IReadOnlyCollection<Unvalidated_ShopCarts> ShopCarts, string reason) : IShopcarts;

        public record Validated_ShopCarts(IReadOnlyCollection<Validated_ShopCarts> ShopCarts) : IShopcarts;

        public record Paid_ShopCarts(IReadOnlyCollection<Validated_ShopCarts> ShopCarts, DateTime PublishedDate) : IShopcarts;
    }
}
