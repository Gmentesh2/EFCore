﻿//------------------------------------------------------------------
//==================================================================
using EFCore.Models;

Console.WriteLine("Hello, World!");


//==================================================================
insertProduct();
readProduct();
updateProduct();
deleteProduct();
//==================================================================
static void insertProduct()
{
    using (var db = new EFContext())
    {
        Product product = new Product();
        product.Name = "Pen Drive";
        db.Add(product);

        product = new Product();
        product.Name = "Memory Card";
        db.Add(product);

        db.SaveChanges();
    }
    return;
}
static void readProduct()
{

    using (var db = new EFContext())
    {
        List<Product> products = db.Products.ToList();
        foreach (Product p in products)
        {
            Console.WriteLine("{0} {1}", p.Id, p.Name);
        }
    }
    return;
}
static void updateProduct()
{
    using (var db = new EFContext())
    {
        Product product = db.Products.Find(1);
        product.Name = "Better Pen Drive";
        db.SaveChanges();
    }
    return;
}
static void deleteProduct()
{
    using (var db = new EFContext())
    {

        Product product = db.Products.Find(1);
        db.Products.Remove(product);
        db.SaveChanges();
    }
    return;
}