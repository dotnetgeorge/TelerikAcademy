/*
 * Create a method that places a new order in the Northwind database. 
 * The order should contain several order items.
 * Use transaction to ensure the data consistency.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindWork.Data;

namespace InsertOrders
{
    class InsertOrders
    {
        static void Main(string[] args)
        {
            InsertOrdersInDB();
        }

        public static void InsertOrdersInDB()
        {
            using (var northWind = new NorthwindEntities())
            {
                using (var transaction = northWind.Database.BeginTransaction())
                {
                    try
                    {
                        var firstOrder = new Order()
                        {
                            CustomerID = "TSTJ",
                            EmployeeID = 10
                        };

                        firstOrder.Order_Details.Add(new Order_Detail() 
                        {
                            OrderID = 2,
                            ProductID = 25,
                            UnitPrice = 20,
                            Quantity = 2,
                            Discount = 0
                        });

                        northWind.Orders.Add(firstOrder);
                        northWind.SaveChanges();

                        var secondOrder = new Order() 
                        {
                            CustomerID = "SUPRD",
                            EmployeeID = 4
                        };

                        secondOrder.Order_Details.Add(new Order_Detail() 
                        {
                            OrderID = 8,
                            ProductID = 15,
                            UnitPrice = 144,
                            Quantity = 1,
                            Discount = 0
                        });

                        northWind.Orders.Add(secondOrder);
                        northWind.SaveChanges();

                        var thirdOrder = new Order() 
                        {
                            CustomerID = "BLONP",
                            EmployeeID = 15
                        };

                        thirdOrder.Order_Details.Add(new Order_Detail() 
                        { 
                            OrderID = thirdOrder.OrderID,
                            ProductID = 10,
                            UnitPrice = 5000,
                            Quantity = 20,
                            Discount = 0
                        });

                        northWind.Orders.Add(thirdOrder);

                        northWind.SaveChanges();

                        transaction.Commit();
                        Console.WriteLine("Successfully inserted orders!");
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine("Error occured: " + ex.Message);
                        transaction.Rollback();
                    }
                }
            }
        }
    }
}
