using Mana.Cards.API.Domain;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.Client
{
    public class SaleLineItemsParser
    {
        public static Sale GetSale(string filePath)
        {
            var sale = new Sale();

            sale.Items = SaleLineItemsParser.ParseCSV(filePath).ToList();
            return sale;
        }
        public static IEnumerable<SalesLineItem> ParseCSV(string filePath)
        {
            using (var parser = new TextFieldParser(filePath))
            {
                parser.CommentTokens = new string[] { "#" };
                parser.SetDelimiters(new string[] { "," });
                parser.HasFieldsEnclosedInQuotes = true;

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    yield return GetSalesLineItem(fields);
                }
            }
        }

        public static SalesLineItem GetSalesLineItem(string[] item)
        {
            return new SalesLineItem
                {
                    Barcode = item[0],
                    Title = item[1],
                    Category = item[2],
                    Quantity = Decimal.Parse(item[3]),
                    Price = Decimal.Parse(item[4])
                };
        }
    }
}
