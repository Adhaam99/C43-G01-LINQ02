using Assignment.Data;
using static Assignment.ListGenerator;


namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Assignment

            #region Aggregate Operators

            #region 1. Get the total units in stock for each product category.

            //var Result = ProductsList.Count(P => P.UnitsInStock > 0);

            //Console.WriteLine(Result);

            #endregion

            #region 2. Get the cheapest price among each category's products

            //var Result = ProductsList.GroupBy(P => P.Category)
            //    .Select(C => new
            //    {

            //        Category = C.Key,
            //        CheapestPriceProduct = C.MinBy(P => P.UnitPrice)

            //    });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Cheapest Price: {item?.CheapestPriceProduct?.UnitPrice}");
            //}

            #endregion

            #region 3. Get the products with the cheapest price in each category (Use Let)

            //var Result = from P in ProductsList
            //             group P by P.Category into C
            //             let CheapestPrice = C.Min(P => P.UnitPrice)
            //             from P in C
            //             where P.UnitPrice == CheapestPrice
            //             select P;


            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Cheapest Price: {item.UnitPrice}");
            //}

            #endregion

            #region 4. Get the most expensive price among each category's products.

            //var Result = ProductsList.GroupBy(P => P.Category)
            //    .Select(C => new
            //    {

            //        Category = C.Key,
            //        MaxPriceProduct = C.MaxBy(P => P.UnitPrice)

            //    });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Most Expensive Price: {item?.CheapestPriceProduct?.UnitPrice}");
            //}

            #endregion

            #region 5. Get the products with the most expensive price in each category.

            //var Result = ProductsList.GroupBy(P => P.Category)
            //    .Select(C => new
            //    {

            //        Category = C.Key,
            //        CheapestPriceProduct = C.MaxBy(P => P.UnitPrice)

            //    });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category: {item.Category}");
            //    Console.WriteLine($"Most Expensive Price Product : {item.CheapestPriceProduct}");
            //}

            #endregion

            #region 6. Get the average price of each category's products.

            var Result = ProductsList.GroupBy(P => P.Category)
                .Select(C => new
                {

                    Category = C.Key,
                    AveragePrices = C.Average(P => P.UnitPrice)

                });

            foreach (var item in Result)
            {
                Console.WriteLine($"Category: {item.Category}");
                Console.WriteLine($"Average Prices : {item.AveragePrices}");
            }

            #endregion

            #endregion

            #endregion


        }
    }
}
