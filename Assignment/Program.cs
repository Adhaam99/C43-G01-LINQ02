using System.ComponentModel;
using System.Data.SqlTypes;
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

            //var Result = ProductsList.GroupBy(P => P.Category)
            //    .Select(C => new
            //    {

            //        Category = C.Key,
            //        UnitsInStock = C.Sum(P => P.UnitsInStock)

            //    });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, UnitsInStock : {item.UnitsInStock}");
            //}

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

            //var Result = ProductsList.GroupBy(P => P.Category)
            //    .Select(C => new
            //    {

            //        Category = C.Key,
            //        AveragePrices = C.Average(P => P.UnitPrice)

            //    });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category: {item.Category}");
            //    Console.WriteLine($"Average Prices : {item.AveragePrices}");
            //}

            #endregion

            #endregion

            #region Set Operators

            #region 1. Find the unique Category names from Product List

            //var Result = ProductsList.GroupBy(P => P.Category).Select(C => C.Key);

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and custome names.

            //var Result01 = ProductsList.Select(P => P.ProductName[0]).Distinct();
            //var Result02 = CustomersList.Select(C => C.CustomerName[0]).Distinct();

            //var Result03 = Result01.Union(Result02);

            //foreach (var item in Result03)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.

            //var Result01 = ProductsList.Select(P => P.ProductName[0]).Distinct();
            //var Result02 = CustomersList.Select(C => C.CustomerName[0]).Distinct();

            //var Result03 = Result01.Intersect(Result02);

            //foreach (var item in Result03)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var Result01 = ProductsList.Select(P => P.ProductName[0]).Distinct();
            //var Result02 = CustomersList.Select(C => C.CustomerName[0]).Distinct();

            //var Result03 = Result01.Except(Result02);

            //foreach (var item in Result03)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates.

            //var Result01 = ProductsList.Select(P => P.ProductName.TakeLast(3));
            //var Result02 = CustomersList.Select(C => C.CustomerName.TakeLast(3));

            //var Result03 = Result01.Concat(Result02);

            //foreach (var item in Result03)
            //{
            //    Console.WriteLine();
            //    foreach (var I in item)
            //        Console.Write($"{I}  ");
            //}

            #endregion


            #endregion

            #region Partitioning Operators

            #region 1. Get the first 3 orders from customers in Washington

            //var Result = CustomersList.Where(C => C.City == "Washington").SelectMany(C => C.Orders).Take(3);

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.

            //var Result = CustomersList.Where(C => C.City == "Washington").SelectMany(C => C.Orders).Skip(2);

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.TakeWhile((N, I) => N > I);

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.SkipWhile(N => N % 3 != 0);

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.SkipWhile( (N , I) => N >= I);

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #endregion

            #region Quantifiers

            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //string[] Arr = "dictionary_english.txt".Split('_', '.');

            //var Result = Arr.Any( S => S.Contains("ei"));

            //Console.WriteLine(Result);

            #endregion

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var Result = ProductsList.GroupBy(P => P.Category)
            //    .Where(C => C.Any(P => P.UnitsInStock == 0));

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Key);

            //    foreach (var I in item)
            //        Console.WriteLine($"\t{I}");
            //}

            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.

            //var Result = ProductsList.GroupBy(P => P.Category)
            //    .Where(C => C.All(P => P.UnitsInStock > 0));

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Key);

            //    foreach (var I in item)
            //        Console.WriteLine($"\t{I}");
            //}

            #endregion

            #endregion

            #region Grouping Operators

            #region 1. Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var Result = numbers.GroupBy(N => N % 5)
            //    .OrderBy(C => C.Key)
            //    .Select(C => new
            //    {
            //        Reminder = C.Key,
            //        Nums = C.OrderBy(number => number)
            //    });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Numbers with a reminder of {item.Reminder} when divided by 5:");

            //    foreach (var Num in item.Nums)
            //        Console.WriteLine(Num);
            //}

            #endregion

            #region 2. Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input

            //string[] Words = "dictionary_english.txt".Split('_', '.');

            //var Result = Words.GroupBy(W => W[0])
            //    .OrderBy(C => C.Key)
            //    .Select(C => new
            //    {
            //        FirstLetter = C.Key,
            //        Words = C.OrderBy(W => W)
            //    });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"First Letter ({item.FirstLetter}) :");

            //    foreach (var Word in item.Words)
            //        Console.WriteLine(Word);
            //}

            #endregion

            #region Q3

            //string[] Arr = { "from", "salt", "earn", "last", "near", "form" };

            //var Result = Arr.GroupBy(W => W, new WordComparer())
            //    .Select(C => C);

            //foreach (var item in Result)
            //{
            //    foreach (var Word in item)
            //        Console.WriteLine(Word);

            //    Console.WriteLine("....");
            //}

            #endregion

            #endregion

            #endregion


        }
    }
}
