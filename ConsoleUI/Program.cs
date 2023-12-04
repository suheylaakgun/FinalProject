using Business.Concretes;
using Core.DataAccess.EntityFramework;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.InMemory;

//Data Transformation Object
//IoC
ProductTest();
//CategoryTest();

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    var result = productManager.GetProductDetail();

    if (result.Success == true)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine("Ürün İsmi : " + product.ProductName + " *********Kategori İsmi : " + product.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
}

