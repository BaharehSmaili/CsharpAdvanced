using System.Collections.Generic;

namespace Try101LinqSamples
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } // عنوان کالا
        public string Category { get; set; } //دستخ
        public decimal UnitPrice { get; set; } // قیمت
        public int UnitsInStock { get; set; } //واحد موجود در انبار
        public override string ToString() =>
            $"ProductID={ProductID} ProductName={ProductName} Category={Category} UnitPrice={UnitPrice:C2} UnitsInStock={UnitsInStock}";

    }

    public static class Products
    {
        public static List<Product> ProductList { get;  } = 
            new List<Product> {
                new Product { ProductID = 1, ProductName = "چای", Category = "نوشیدنی ها", UnitPrice = 18.0000M, UnitsInStock = 40 },
                new Product { ProductID = 2, ProductName = "لیمونات", Category = "نوشیدنی ها", UnitPrice = 19.0000M, UnitsInStock = 30 },
                new Product { ProductID = 3, ProductName = "فلفل سیاه", Category = "چاشنی ها", UnitPrice = 10.0000M, UnitsInStock = 25 },
                new Product { ProductID = 4, ProductName = "فلفل قرمز", Category = "چاشنی ها", UnitPrice = 22.0000M, UnitsInStock = 50 },
                new Product { ProductID = 5, ProductName = "نمک", Category = "چاشنی ها", UnitPrice = 21.3500M, UnitsInStock = 0 },
                new Product { ProductID = 6, ProductName = "شکر", Category = "چاشنی ها", UnitPrice = 25.0000M, UnitsInStock = 120 },
                new Product { ProductID = 7, ProductName = "چیپس", Category = "تنقلات", UnitPrice = 30.0000M, UnitsInStock = 100 },
                new Product { ProductID = 8, ProductName = "زنجبیلe", Category = "چاشنی ها", UnitPrice = 40.0000M, UnitsInStock = 10 },
                new Product { ProductID = 9, ProductName = "راسته گوسفندی", Category = "گوشت / مرغ", UnitPrice = 97.0000M, UnitsInStock = 30 },
                new Product { ProductID = 10, ProductName = "میگو", Category = "غذای دریایی", UnitPrice = 31.0000M, UnitsInStock = 30 },
                new Product { ProductID = 11, ProductName = "شیر", Category = "لبنیات", UnitPrice = 21.0000M, UnitsInStock = 20 },
                new Product { ProductID = 12, ProductName = "خامه", Category = "لبنیات", UnitPrice = 38.0000M, UnitsInStock = 80 },
                new Product { ProductID = 13, ProductName = "قزل آلا", Category = "غذای دریایی", UnitPrice = 6.0000M, UnitsInStock = 20 },
                new Product { ProductID = 14, ProductName = "پفک نمکی", Category = "تنقلات", UnitPrice = 23.2500M, UnitsInStock = 30 },
                new Product { ProductID = 15, ProductName = "زعفران", Category = "چاشنی ها", UnitPrice = 15.5000M, UnitsInStock = 40 },
                new Product { ProductID = 16, ProductName = "دانمارکی", Category = "شیرینی", UnitPrice = 17.4500M, UnitsInStock = 30 },
                new Product { ProductID = 17, ProductName = "فیله گوساله", Category = "گوشت / مرغ", UnitPrice = 39.0000M, UnitsInStock = 0 },
                new Product { ProductID = 18, ProductName = "ماهی شیر", Category = "غذای دریایی", UnitPrice = 62.5000M, UnitsInStock = 40 },
                new Product { ProductID = 19, ProductName = "رولت", Category = "شیرینی", UnitPrice = 9.2000M, UnitsInStock = 25 },
                new Product { ProductID = 20, ProductName = "نان خامه ای", Category = "شیرینی", UnitPrice = 81.0000M, UnitsInStock = 40 },
                new Product { ProductID = 21, ProductName = "رولت", Category = "شیرینی", UnitPrice = 10.0000M, UnitsInStock = 3 },
                new Product { ProductID = 22, ProductName = "لوبیا", Category = "غلات", UnitPrice = 21.0000M, UnitsInStock = 104 },
                new Product { ProductID = 23, ProductName = "نخود", Category = "غلات", UnitPrice = 9.0000M, UnitsInStock = 61 },
                new Product { ProductID = 24, ProductName = "آب پرتقال", Category = "نوشیدنی ها", UnitPrice = 4.5000M, UnitsInStock = 20 },
                new Product { ProductID = 25, ProductName = "ناپلئونی", Category = "شیرینی", UnitPrice = 14.0000M, UnitsInStock = 76 },
                new Product { ProductID = 26, ProductName = "باقلوا", Category = "شیرینی", UnitPrice = 31.2300M, UnitsInStock = 15 },
                new Product { ProductID = 27, ProductName = "زبان", Category = "شیرینی", UnitPrice = 43.9000M, UnitsInStock = 49 },
                new Product { ProductID = 28, ProductName = "پاپ کرون", Category = "تنقلات", UnitPrice = 45.6000M, UnitsInStock = 26 },
                new Product { ProductID = 29, ProductName = "چرخ کرده گوسفندی", Category = "گوشت / مرغ", UnitPrice = 123.7900M, UnitsInStock = 0 },
                new Product { ProductID = 30, ProductName = "ماهی حلوا", Category = "غذای دریایی", UnitPrice = 25.8900M, UnitsInStock = 10 },
                new Product { ProductID = 31, ProductName = "سرشیر", Category = "لبنیات", UnitPrice = 12.5000M, UnitsInStock = 0 },
                new Product { ProductID = 32, ProductName = "شیر کاکائو", Category = "لبنیات", UnitPrice = 32.0000M, UnitsInStock = 9 },
                new Product { ProductID = 33, ProductName = "کره خرم", Category = "لبنیات", UnitPrice = 2.5000M, UnitsInStock = 112 },
                new Product { ProductID = 34, ProductName = "چای سبز", Category = "نوشیدنی ها", UnitPrice = 14.0000M, UnitsInStock = 111 },
                new Product { ProductID = 35, ProductName = "موهیتو", Category = "نوشیدنی ها", UnitPrice = 18.0000M, UnitsInStock = 20 },
                new Product { ProductID = 36, ProductName = "ماهی سفید", Category = "غذای دریایی", UnitPrice = 19.0000M, UnitsInStock = 112 },
                new Product { ProductID = 37, ProductName = "ماهی سرخو", Category = "غذای دریایی", UnitPrice = 26.0000M, UnitsInStock = 11 },
                new Product { ProductID = 38, ProductName = "کاپوچینو", Category = "نوشیدنی ها", UnitPrice = 263.5000M, UnitsInStock = 17 },
                new Product { ProductID = 39, ProductName = "قهوه", Category = "نوشیدنی ها", UnitPrice = 18.0000M, UnitsInStock = 69 },
                new Product { ProductID = 40, ProductName = "شاه میگو", Category = "غذای دریایی", UnitPrice = 18.4000M, UnitsInStock = 123 },
                new Product { ProductID = 41, ProductName = "ماهی کلیکا", Category = "غذای دریایی", UnitPrice = 9.6500M, UnitsInStock = 85 },
                new Product { ProductID = 42, ProductName = "عدس", Category = "غلات", UnitPrice = 14.0000M, UnitsInStock = 26 },
                new Product { ProductID = 43, ProductName = "آیس کافی", Category = "نوشیدنی ها", UnitPrice = 46.0000M, UnitsInStock = 17 },
                new Product { ProductID = 44, ProductName = "زعفران", Category = "چاشنی ها", UnitPrice = 19.4500M, UnitsInStock = 27 },
                new Product { ProductID = 45, ProductName = "ماهی سنگسر", Category = "غذای دریایی", UnitPrice = 9.5000M, UnitsInStock = 5 },
                new Product { ProductID = 46, ProductName = "ماهی تیلاپیلا", Category = "غذای دریایی", UnitPrice = 12.0000M, UnitsInStock = 95 },
                new Product { ProductID = 47, ProductName = "برونی", Category = "شیرینی", UnitPrice = 9.5000M, UnitsInStock = 36 },
                new Product { ProductID = 48, ProductName = "گل محمدی", Category = "شیرینی", UnitPrice = 12.7500M, UnitsInStock = 15 },
                new Product { ProductID = 49, ProductName = "پنجره ای", Category = "شیرینی", UnitPrice = 20.0000M, UnitsInStock = 10 },
                new Product { ProductID = 50, ProductName = "نعلی", Category = "شیرینی", UnitPrice = 16.2500M, UnitsInStock = 65 },
                new Product { ProductID = 51, ProductName = "کرانچی", Category = "تنقلات", UnitPrice = 53.0000M, UnitsInStock = 20 },
                new Product { ProductID = 52, ProductName = "لوبیا چیتی", Category = "غلات", UnitPrice = 7.0000M, UnitsInStock = 38 },
                new Product { ProductID = 53, ProductName = "پای مرغ", Category = "گوشت / مرغ", UnitPrice = 32.8000M, UnitsInStock = 0 },
                new Product { ProductID = 54, ProductName = "فیله مرغ", Category = "گوشت / مرغ", UnitPrice = 7.4500M, UnitsInStock = 21 },
                new Product { ProductID = 55, ProductName = "بال مرغ", Category = "گوشت / مرغ", UnitPrice = 24.0000M, UnitsInStock = 115 },
                new Product { ProductID = 56, ProductName = "جو پرک", Category = "غلات", UnitPrice = 38.0000M, UnitsInStock = 21 },
                new Product { ProductID = 57, ProductName = "جو", Category = "غلات", UnitPrice = 19.5000M, UnitsInStock = 36 },
                new Product { ProductID = 58, ProductName = "ماهی حلوا بندر", Category = "غذای دریایی", UnitPrice = 13.2500M, UnitsInStock = 62 },
                new Product { ProductID = 59, ProductName = "کشک", Category = "لبنیات", UnitPrice = 55.0000M, UnitsInStock = 79 },
                new Product { ProductID = 60, ProductName = "کشک پاکتی", Category = "لبنیات", UnitPrice = 34.0000M, UnitsInStock = 19 },
                new Product { ProductID = 61, ProductName = "زردچوبه", Category = "چاشنی ها", UnitPrice = 28.5000M, UnitsInStock = 113 },
                new Product { ProductID = 62, ProductName = "نخودی", Category = "شیرینی", UnitPrice = 49.3000M, UnitsInStock = 17 },
                new Product { ProductID = 63, ProductName = "نعناع", Category = "چاشنی ها", UnitPrice = 43.9000M, UnitsInStock = 24 },
                new Product { ProductID = 64, ProductName = "لوبیا سفید", Category = "غلات", UnitPrice = 33.2500M, UnitsInStock = 22 },
                new Product { ProductID = 65, ProductName = "آویشن", Category = "چاشنی ها", UnitPrice = 21.0500M, UnitsInStock = 76 },
                new Product { ProductID = 66, ProductName = "پودر سیر", Category = "چاشنی ها", UnitPrice = 17.0000M, UnitsInStock = 4 },
                new Product { ProductID = 67, ProductName = "آب معدنی", Category = "نوشیدنی ها", UnitPrice = 14.0000M, UnitsInStock = 50 },
                new Product { ProductID = 68, ProductName = "برنجی", Category = "شیرینی", UnitPrice = 12.5000M, UnitsInStock = 60 },
                new Product { ProductID = 69, ProductName = "روغن زرد", Category = "لبنیات", UnitPrice = 36.0000M, UnitsInStock = 28 },
                new Product { ProductID = 70, ProductName = "نسکافه", Category = "نوشیدنی ها", UnitPrice = 15.0000M, UnitsInStock = 10 },
                new Product { ProductID = 71, ProductName = "روغن حیوانی", Category = "لبنیات", UnitPrice = 21.5000M, UnitsInStock = 23 },
                new Product { ProductID = 72, ProductName = "پنیر", Category = "لبنیات", UnitPrice = 34.8000M, UnitsInStock = 4 },
                new Product { ProductID = 73, ProductName = "خاویار", Category = "غذای دریایی", UnitPrice = 15.0000M, UnitsInStock = 131 },
                new Product { ProductID = 74, ProductName = "بیسکوئیت", Category = "تنقلات", UnitPrice = 10.0000M, UnitsInStock = 40 },
                new Product { ProductID = 75, ProductName = "اسپرسو", Category = "نوشیدنی ها", UnitPrice = 7.7500M, UnitsInStock = 105 },
                new Product { ProductID = 76, ProductName = "آب آلبالو", Category = "نوشیدنی ها", UnitPrice = 18.0000M, UnitsInStock = 53 },
                new Product { ProductID = 77, ProductName = "دارچین", Category = "چاشنی ها", UnitPrice = 13.0000M, UnitsInStock = 35 }
            };
    }
}
