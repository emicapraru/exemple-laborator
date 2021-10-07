using System;
using LAB1_Capraru_Emil_Ionut.Domain;
using System.Collections.Generic;
using static LAB1_Capraru_Emil_Ionut.Domain.ShopCarts;

namespace LAB1_Capraru_Emil_Ionut
{
    class Program
    {
        private static readonly Random random = new Random();

        static void Main(string[] args)
        {
            var listOfShopCarts = ReadListOfShopCarts().ToArray();
            EmptyShopCarts emptyShopCarts = new(listOfShopCarts);
            IShopcarts result = Validate_ShopCarts(emptyShopCarts);
            result.Match(
                whenEmptyShopCarts: emptyResult => emptyShopCarts,
                whenUnvalidated_ShopCarts: unvalidatedResult => unvalidatedResult,
                whenPaid_ShopCarts: paidResult => paidResult,
                whenValidated_ShopCarts: validatedResult => PayShoppingCart(validatedResult)
            );

            Console.WriteLine("Hello World!");
        }

        private static List<EmptyShopCart> ReadListOfShopCarts()
        {
            List<EmptyShopCart> listOfShopCarts = new();
            do
            {
                //read registration number and grade and create a list of greads
                var quantity = ReadValue("Introduceti cantitatea produsului comandat: ");
                if (string.IsNullOrEmpty(quantity))
                {
                    break;
                }

                var product_code = ReadValue("Introduceti codul produsului: ");
                if (string.IsNullOrEmpty(product_code))
                {
                    break;
                }

                var address = ReadValue("Introduceti adresa: ");
                if (string.IsNullOrEmpty(address))
                {
                    break;
                }

                listOfShopCarts.Add(new(quantity, product_code, address));
            } while (true);
            return listOfShopCarts;
        }

        private static IShopcarts Validate_ShopCarts(EmptyShopCarts emptyShopCarts) =>
            random.Next(100) > 50 ?
            new ShopCarts.Unvalidated_ShopCarts(new List<ShopCarts.Unvalidated_ShopCarts>(), "Random errror")
            : new ShopCarts.Validated_ShopCarts(new List<ShopCarts.Validated_ShopCarts>());

        private static IShopcarts PayShoppingCart(ShopCarts.Validated_ShopCarts validExamGrades) =>
            new Paid_ShopCarts(new List<ShopCarts.Validated_ShopCarts>(), DateTime.Now);

        private static string? ReadValue(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
